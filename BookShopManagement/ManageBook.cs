using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement
{
    public partial class ManageBook : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private String Sql { get; set; }
        public ManageBook()
        {
            InitializeComponent();
            this.Da = new DataAccess();
          
            this.BookGridView();
            this.AutoGenerateBookID();
            comboBoxAutoSearch.SelectedIndex = 0;
        }
        private void BookGridView(string sql="select * from book")
        {
            this.Ds = Da.ExecuteQuery(sql);
            this.dgvBook.AutoGenerateColumns = false;
            this.dgvBook.DataSource = Ds.Tables[0];
            
        }

        private void AutoSearchBook_TextChanged(object sender, EventArgs e)
        {
           
            this.Sql = "Select * from book where "+comboBoxAutoSearch.SelectedItem+ " like '"+txtAutoSearchBook.Text+"%';";
            this.BookGridView(this.Sql);
        }

        private void txtAutoSearchBook_Enter(object sender, EventArgs e)
        {
            if(txtAutoSearchBook.Text == "Search By ID/Name")
            {
                txtAutoSearchBook.Text = "";
                txtAutoSearchBook.ForeColor = Color.Black;
            }

        }

        private void txtAutoSearchBook_Leave(object sender, EventArgs e)
        {
            if (txtAutoSearchBook.Text == "")
            {
                txtAutoSearchBook.Text = "Search By ID/Name";
                txtAutoSearchBook.ForeColor = Color.DarkGray;
                this.BookGridView();
            }


        }

        private void AutoGenerateBookID()
        {
            this.Sql = "Select * from book order by bookid desc;";
            DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
            string id = dt.Rows[0][0].ToString();
            string[] str = id.Split('b');
            int number = Convert.ToInt32(str[1]);
            string newId = "b" + (++number).ToString("d3");

            this.txtBookId.Text = newId;
        }

        private void dgvBook_DoubleClick(object sender, EventArgs e)
        {
            this.txtBookId.Text = this.dgvBook.CurrentRow.Cells["bookId"].Value.ToString();
            this.txtBookName.Text = this.dgvBook.CurrentRow.Cells["bookname"].Value.ToString();
            this.txtAuthor.Text = this.dgvBook.CurrentRow.Cells["author"].Value.ToString();
            this.txtPrice.Text = this.dgvBook.CurrentRow.Cells["price"].Value.ToString();
            this.txtGenre.Text = this.dgvBook.CurrentRow.Cells["genre"].Value.ToString();
            this.numericUpDownCopy.Text= this.dgvBook.CurrentRow.Cells["noofcopy"].Value.ToString();
            this.dtpublishedDate.Text=this.dgvBook.CurrentRow.Cells["publisheddate"].Value.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                this.Sql = "select * from book where bookid='" + this.txtBookId.Text + "';";
                this.Ds = this.Da.ExecuteQuery(this.Sql);
                if (this.Ds.Tables[0].Rows.Count == 1)
                {

                    this.Sql = @"update book set bookname='" + this.txtBookName.Text + @"',
                           author='" + this.txtAuthor.Text + "',genre ='" + this.txtGenre.Text + "',noofcopy=" + this.numericUpDownCopy.Value + @",
                           publisheddate='" + this.dtpublishedDate.Text + "',price=" + this.txtPrice.Text + " where bookid='" + this.txtBookId.Text + "';";

                    int count = this.Da.ExecuteUpdateQuery(this.Sql);

                    if (count == 1)
                    {

                        MessageBox.Show("Data Updated");

                    }
                    else
                    {
                        MessageBox.Show("Data Update Failed");
                    }
                    this.BookGridView();
                    this.ClearAll();
                }
                else
                {
                    this.Sql = @"insert into book(bookid,bookname,author,price,genre,noofcopy,publisheddate) values('" + this.txtBookId.Text + @"', 
                      '" + this.txtBookName.Text + "','" + this.txtAuthor.Text + @"',
                      " + this.txtPrice.Text + ",'" + this.txtGenre.Text + "'," + this.numericUpDownCopy.Value + ",'" + this.dtpublishedDate.Text + "');";

                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {

                        MessageBox.Show("Data Inserted for- Book Id-" + this.txtBookId.Text);

                    }
                    else
                    {
                        MessageBox.Show("Data Insertion Failed");
                    }
                    this.BookGridView();
                    this.ClearAll();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Invalid");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
        private void ClearAll()
        {
            this.txtBookId.Clear();
            this.txtBookName.Clear();
            this.txtAuthor.Clear();
            this.txtPrice.Clear();
            this.txtGenre.Clear();
            this.numericUpDownCopy.Value = 0;
            this.dtpublishedDate.Text = "";
            this.AutoGenerateBookID();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string bookid = this.dgvBook.CurrentRow.Cells["bookid"].Value.ToString();

            this.Sql = "delete from book where bookid='" + bookid + "';";

            int count = this.Da.ExecuteUpdateQuery(this.Sql);
            if (count == 1)
            {

                MessageBox.Show("User ID-" + bookid + " has been Deleted");

            }
            else
            {
                MessageBox.Show("Data Deletion Failed");
            }
            this.BookGridView();
            this.ClearAll();
        }
    }
}
