using BookShopManagement.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement
{
    public partial class SellerWindow : Form
    {
        DateTime date = DateTime.Now;

        private Login Lgn { get; set; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private String Sql { get; set; }
        public SellerWindow()
        {
            InitializeComponent();

            this.Da = new DataAccess();

            this.BookGridView();

            this.AutoGenerateOrderID();

            cbAutoSearch.SelectedIndex = 0;


        }

        public SellerWindow(string name, string id, Login lgn) : this()
        {
            this.lblUsername.Text = name;
            this.lblUserId.Text = id;
            this.Lgn = lgn;
        }


        private void BookGridView(string sql = "select * from book")
        {
            this.Ds = Da.ExecuteQuery(sql);
            this.dgvBook.AutoGenerateColumns = false;
            this.dgvBook.DataSource = Ds.Tables[0];

        }


        private void txtAutoSearchBook_TextChanged(object sender, EventArgs e)
        {

            this.Sql = "select * from book where " + cbAutoSearch.SelectedItem + " like '" + txtAutoSearchBook.Text + "%';";
            this.BookGridView(this.Sql);
        }


        private void txtAutoSearchBook_Enter(object sender, EventArgs e)
        {
            if (txtAutoSearchBook.Text == "Search >>")
            {
                txtAutoSearchBook.Text = "";
                txtAutoSearchBook.ForeColor = Color.Black;
            }
        }


        private void txtAutoSearchBook_Leave(object sender, EventArgs e)
        {
            if (txtAutoSearchBook.Text == "")
            {
                txtAutoSearchBook.Text = "Search >>";
                txtAutoSearchBook.ForeColor = Color.DarkGray;
                this.BookGridView();

            }
        }

        private int availablecopy = 0;

        private void dgvBook_DoubleClick(object sender, EventArgs e)
        {
            this.txtBookId.Text = this.dgvBook.CurrentRow.Cells["bookId"].Value.ToString();
            this.txtBookName.Text = this.dgvBook.CurrentRow.Cells["bookname"].Value.ToString();
            this.txtUPrice.Text = this.dgvBook.CurrentRow.Cells["price"].Value.ToString();
            this.txtNoofCopy.Text = this.dgvBook.CurrentRow.Cells["noofcopy"].Value.ToString();

            availablecopy = Convert.ToInt32(this.txtNoofCopy.Text);
            this.txtCustomerName.ReadOnly = false;

            this.nupQuantity.Maximum = Convert.ToInt32(this.txtNoofCopy.Text);

            
            this.txtTPrice.Text = "0";
            
            this.nupQuantity.Value = 0;
        }

        private void nupQuantity_ValueChanged(object sender, EventArgs e)
        {

            if (Convert.ToInt32(this.txtNoofCopy.Text) + 1 > Convert.ToInt32(this.nupQuantity.Value))
            {

                this.txtTPrice.Text = (Convert.ToDouble(this.txtUPrice.Text) * Convert.ToDouble(this.nupQuantity.Value)).ToString();

                
            }
            else
            {
                this.nupQuantity.Maximum = 0;
                MessageBox.Show("Invalid");

            }
        }

        private void AutoGenerateOrderID()
        {
            this.Sql = "Select * from records order by orderid desc;";
            DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
            string id = dt.Rows[0][1].ToString();
            string[] str = id.Split('-');
            int number = Convert.ToInt32(str[1]);
            string newId = "o-" + (++number).ToString("d3");

            this.txtOrderId.Text = newId;
        }


        DataTable dt = new DataTable();

        private void SellerWindow_Load(object sender, EventArgs e)
        {

            this.lblDate.Text = date.ToLongDateString();



            this.txtNoofCopy.Text = "0";

            dt.Columns.Add("Order ID", typeof(string));
            dt.Columns.Add("Book ID", typeof(string));
            dt.Columns.Add("Book Name", typeof(string));
            dt.Columns.Add("Customer Name", typeof(string));
            dt.Columns.Add("Quantity", typeof(string));
            dt.Columns.Add("Price", typeof(string));

            dgvOrder.DataSource = dt;
            this.dgvOrder.Columns[0].Visible = false;
            this.dgvOrder.Columns[3].Visible = false;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtCustomerName.ReadOnly = false;
            this.ClearAll();
        }

        private void ClearAll()
        {
            this.txtOrderId.Clear();
            this.txtBookId.Clear();
            this.txtBookName.Clear();
            this.nupQuantity.Value = 0;
            this.Discount.Value = 0;
            this.txtNoofCopy.Text = "0";
            this.txtUPrice.Text = "0";
            this.AutoGenerateOrderID();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool row = true;
            this.txtCustomerName.ReadOnly = true;
            if (this.nupQuantity.Value > 0 && this.txtCustomerName.Text.ToString() != "")
            {
                this.lblOrderId.Text = this.txtOrderId.Text;
                this.lblCustomerName.Text = this.txtCustomerName.Text;
                try
                {
                    this.Sql = @"update book set noofcopy-=" + this.nupQuantity.Text + " where bookid='" + this.txtBookId.Text + "';";
                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        {
                            for (int x = 0; x < this.dgvOrder.Rows.Count; x++)
                            {
                                if (this.dgvOrder.Rows[x].Cells[1].Value.ToString() == this.txtBookId.Text.ToString())

                                {
                                    this.dgvOrder.Rows[x].Cells[4].Value = Convert.ToInt32(this.dgvOrder.Rows[x].Cells[4].Value) + this.nupQuantity.Value;
                                    this.dgvOrder.Rows[x].Cells[5].Value = Convert.ToDouble(this.dgvOrder.Rows[x].Cells[5].Value) + Convert.ToDouble(this.txtTPrice.Text);
                                    row = false;
                                   
                                    break;
                                    
                                }

                            }
                            if (row == true)
                            {
                                dt.Rows.Add(this.txtOrderId.Text, this.txtBookId.Text, this.txtBookName.Text, this.txtCustomerName.Text, this.nupQuantity.Value, this.txtTPrice.Text);

                              
                            }
                            this.SubTotal();
                            this.TotalBooks();

                            this.BookGridView();
                            this.ClearAll();
                            this.txtAmountPaid.Text = "";
                            this.txtReturnAmount.Text = "0";
                       }
                    }
                    else
                        MessageBox.Show("Invalid");
                }
                catch (Exception exc)
                { MessageBox.Show("Indalid"); }
            }

            else if (this.txtCustomerName.Text.ToString() == "")
            { MessageBox.Show("Enter Customer Name"); }

            else if (this.nupQuantity.Value == 0)
            { MessageBox.Show("Quantity is 0"); }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvOrder.SelectedRows.Count > 0)
            {
                try
                {
                    this.Sql = @"update book set noofcopy+=" + this.dgvOrder.SelectedRows[0].Cells[4].Value + " where bookid='" + this.dgvOrder.SelectedRows[0].Cells[1].Value + "';";
                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        dgvOrder.Rows.RemoveAt(this.dgvOrder.SelectedRows[0].Index);

                        this.SubTotal();

                        this.TotalBooks();
                        this.BookGridView();
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Invalid");
                }

            }
        }



        private void SubTotal()
        {

            double sum = 0;
            for (int x = 0; x < dgvOrder.Rows.Count; ++x)
            {
                sum += Convert.ToInt32(dgvOrder.Rows[x].Cells[5].Value);
            }
            this.txtSubtotal.Text = sum.ToString();

            this.txtTotal.Text = sum.ToString();
        }

        private void Discount_ValueChanged(object sender, EventArgs e)
        {
            this.txtTotal.Text = (Convert.ToDouble(this.txtSubtotal.Text) - ((Convert.ToDouble(this.txtSubtotal.Text) * Convert.ToDouble(this.Discount.Value)) / 100)).ToString();
        }


        private void TotalBooks()
        {
            int totalbooks = 0;
            for (int x = 0; x < dgvOrder.Rows.Count; ++x)
            {
                totalbooks += Convert.ToInt32(dgvOrder.Rows[x].Cells[4].Value);
            }
            this.txtTotalBooks.Text = totalbooks.ToString();
        }


        private int serial;

        private void AutoGenerateSerial()
        {
            this.Sql = "Select * from records order by serial desc;";
            DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
            string id = dt.Rows[0][0].ToString();
            int number = Convert.ToInt32(id);
            serial = (++number);

        }



        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            
            try
            {

                if (this.txtTotal.Text != "0")
                {
                    this.txtCustomerName.Clear();




                    int count2 = 0;

                    for (int i = 0; i < dgvOrder.Rows.Count; i++)
                    {
                        this.AutoGenerateSerial();

                        DateTime orderdate = DateTime.Now;

                        this.Sql = @"insert into records(userid,bookid,bookname,customername,price,orderid,quantity,serial,orderdate) values ('" + this.lblUserId.Text + @"',
                         '" + this.dgvOrder.Rows[i].Cells[1].Value + "','" + this.dgvOrder.Rows[i].Cells[2].Value + "','" + this.dgvOrder.Rows[i].Cells[3].Value + @"',
                         " + this.dgvOrder.Rows[i].Cells[5].Value + ",'" + this.dgvOrder.Rows[i].Cells[0].Value + "'," + this.dgvOrder.Rows[i].Cells[4].Value + "," + serial + ",'" + date.ToString() + "'); ";

                        int count = this.Da.ExecuteUpdateQuery(this.Sql);

                        if (count == 1)
                        {
                            availablecopy = availablecopy - Convert.ToInt32(this.dgvOrder.Rows[i].Cells[4].Value);

                            this.Sql = @"update book set noofcopy=" + availablecopy + " where bookid='" + this.dgvOrder.Rows[i].Cells[1].Value + "';";
                            count2 = this.Da.ExecuteUpdateQuery(this.Sql);

                        }

                    }
                    if (count2 == 1)
                    {
                        MessageBox.Show("Transaction Completed Successfully");

                    }
                    printDocument.Print();

                    this.txtSubtotal.Text = "0";
                    this.txtTotalBooks.Text = "0";
                    this.lblOrderId.Text = "-";
                    this.txtTotal.Text = "0";
                    this.lblCustomerName.Text = "-";
                    this.AutoGenerateOrderID();
                    this.BookGridView();

                    
                    while (this.dgvOrder.Rows.Count > 0)
                    {
                        dgvOrder.Rows.Remove(this.dgvOrder.Rows[0]);
                    }

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Invalid");
            }


        }

        private void SellerWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Lgn.Visible = true;
            this.Lgn.txtUserID.Clear();
            this.Lgn.txtPassword.Clear();

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

            string id = this.lblUserId.Text.ToString();

            ChangePassword cps = new ChangePassword(id);
            cps.Visible = true;
        }


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.txtBookId.Text = this.dgvBook.CurrentRow.Cells["bookId"].Value.ToString();
            this.txtBookName.Text = this.dgvBook.CurrentRow.Cells["bookname"].Value.ToString();
            this.txtUPrice.Text = this.dgvBook.CurrentRow.Cells["price"].Value.ToString();
            this.txtNoofCopy.Text = this.dgvBook.CurrentRow.Cells["noofcopy"].Value.ToString();
            this.txtCustomerName.ReadOnly = false;
            availablecopy = Convert.ToInt32(this.txtNoofCopy.Text);


            this.nupQuantity.Maximum = Convert.ToInt32(this.txtNoofCopy.Text);

            
            this.txtTPrice.Text = "0";
            
        }



        private void btnCancelCartOrder_Click(object sender, EventArgs e)
        {
            this.txtCustomerName.ReadOnly = false;
            this.lblOrderId.Text = "-";
            this.lblCustomerName.Text = "-";
            for (int x = 0; x < this.dgvOrder.Rows.Count; x++)
            {
                try
                {
                    this.Sql = @"update book set noofcopy+=" + this.dgvOrder.Rows[x].Cells[4].Value + " where bookid='" + this.dgvOrder.Rows[x].Cells[1].Value + "';";
                    this.Da.ExecuteUpdateQuery(this.Sql);
                   
                }
                catch (Exception exc)
                { MessageBox.Show("Invalid"); }

            }
            while (this.dgvOrder.Rows.Count > 0)
            {
                dgvOrder.Rows.Remove(this.dgvOrder.Rows[0]);
            }
            this.BookGridView();
            this.txtSubtotal.Text = "0";
            this.txtTotalBooks.Text = "0";
            this.AutoGenerateOrderID();
            this.ClearAll();
        }



        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtReturnAmount.Text = Math.Abs(Convert.ToDouble(this.txtAmountPaid.Text) - Convert.ToDouble(this.txtTotal.Text)).ToString();
            }

            catch (Exception exc)
            { }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Resources.logo;
            e.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);
            e.Graphics.DrawString("Date:" + DateTime.Now, new Font("Arial", 15, FontStyle.Underline), Brushes.Black, new Point(25, 200));
            e.Graphics.DrawString("Order ID: " + this.lblOrderId.Text.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(25, 235));
            e.Graphics.DrawString("Customer Name: " + this.lblCustomerName.Text.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, 270));
            e.Graphics.DrawString("Seller ID: " + this.lblUserId.Text.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(500, 235));
            e.Graphics.DrawString("Seller ID: " + this.lblUsername.Text.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(500, 270));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(23, 300));
            e.Graphics.DrawString("Book Name", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, 320));
            e.Graphics.DrawString("Quantity", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(300, 320));
            e.Graphics.DrawString("Total Price", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 320));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(23, 340));
            int yPos = 360;
            for (int i = 0; i < dgvOrder.Rows.Count; i++)
            {
                e.Graphics.DrawString(this.dgvOrder.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, yPos));
                e.Graphics.DrawString(this.dgvOrder.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(310, yPos));
                e.Graphics.DrawString(this.dgvOrder.Rows[i].Cells[5].Value.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(610, yPos));
                yPos += 40;
            }
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(23, yPos));
            e.Graphics.DrawString("Subtotal:"+this.txtSubtotal.Text.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(585, yPos+30));
            e.Graphics.DrawString("Total Quantity:" + this.txtTotalBooks.Text.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(285, yPos + 30));
            e.Graphics.DrawString("Discount(%):" + this.Discount.Text.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(585, yPos +60));
            e.Graphics.DrawString("Total Amount:" + this.txtTotal.Text.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(585, yPos + 90));
            e.Graphics.DrawString("Amount Paid:" + this.txtAmountPaid.Text.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(585, yPos + 120));
            e.Graphics.DrawString("Balance:" + this.txtReturnAmount.Text.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(585, yPos + 150));
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

      
 
    }
}
