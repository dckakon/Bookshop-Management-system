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
    public partial class ManageSeller : UserControl
    {
        private DataAccess Da{ get; set; }
        private DataSet Ds { get; set; }
        private String Sql { get; set; }
        public ManageSeller()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            
            this.SellerGridView();
            this.AutoGenerateID();


        }

        
        private void SellerGridView(string sql= "Select * from login where type = 'seller'")//optional value
        {
                this.Ds = Da.ExecuteQuery(sql);
                this.dgvSeller.AutoGenerateColumns = false;
                this.dgvSeller.DataSource = Ds.Tables[0];
          

        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "Select * from login where type='seller' and userId like '" + txtAutoSearch.Text + "%';";
            this.SellerGridView(this.Sql);
        }

        private void txtAutoSearch_Enter(object sender, EventArgs e)
        {
            if(txtAutoSearch.Text=="Search by ID")
            {
                txtAutoSearch.Text = "";
                txtAutoSearch.ForeColor = Color.Black;
            }
        }

        private void txtAutoSearch_Leave(object sender, EventArgs e)
        {
            if (txtAutoSearch.Text == "")
            {
                txtAutoSearch.Text = "Search by ID";
                txtAutoSearch.ForeColor = Color.DarkGray;
                this.SellerGridView();
            }

        }


        private void dgvSeller_DoubleClick(object sender, EventArgs e)
        {
            
            this.txtUserID.Text = this.dgvSeller.CurrentRow.Cells["userId"].Value.ToString();
            this.txtSellerUsername.Text = this.dgvSeller.CurrentRow.Cells["username"].Value.ToString();
            this.txtPhoneNumber.Text = this.dgvSeller.CurrentRow.Cells["phone"].Value.ToString();
            this.txtLocation.Text = this.dgvSeller.CurrentRow.Cells["location"].Value.ToString();
            this.txtSalary.Text = this.dgvSeller.CurrentRow.Cells["salary"].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sql = "select * from login where userId='" + this.txtUserID.Text + "';";
                this.Ds = this.Da.ExecuteQuery(this.Sql);

                if (this.Ds.Tables[0].Rows.Count == 1)
                {

                    this.Sql = @"update login set username='" + this.txtSellerUsername.Text + @"',
                           phone='" + this.txtPhoneNumber.Text + "', location='" + this.txtLocation.Text + "',salary=" + this.txtSalary.Text + @"
                           where userId='" + this.txtUserID.Text + "';";

                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {

                        MessageBox.Show("Data Updated");

                    }
                    else
                    {
                        MessageBox.Show("Data Update Failed");
                    }
                    this.SellerGridView();
                    this.ClearAll();
                }


                else
                {
                    Random rd = new Random();
                    int x = rd.Next(999999) + 1000000;

                    this.Sql = @"insert into login(userId,username,phone,location,salary,password,type) values('" + this.txtUserID.Text + @"', 
                      '" + this.txtSellerUsername.Text + "','" + this.txtPhoneNumber.Text + @"',
                      '" + this.txtLocation.Text + "','" + this.txtSalary.Text + "'," + x + ",'seller');";

                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {

                        MessageBox.Show("Data Inserted- User Id-" + this.txtUserID.Text + ", Password-" + x);

                    }
                    else
                    {
                        MessageBox.Show("Data Insertion Failed");
                    }
                    this.SellerGridView();
                    this.ClearAll();
                }
            }
            catch(Exception exc)
            { MessageBox.Show("Invalid"); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string userId = this.dgvSeller.CurrentRow.Cells["userId"].Value.ToString();
            
            this.Sql = "delete from login where userId='"+ userId +"';";

            int count = this.Da.ExecuteUpdateQuery(this.Sql);
            if (count == 1)
            {

                MessageBox.Show("User ID-"+userId+" has been Deleted");

            }
            else
            {
                MessageBox.Show("Data Deletion Failed"); 
            }
            this.SellerGridView();
            this.ClearAll();
        }

        private void AutoGenerateID()
        {
            this.Sql = "Select * from login order by userId desc;";
            DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
            string id = dt.Rows[0][0].ToString();
            string[] str = id.Split('-');
            int number = Convert.ToInt32(str[1]);
            string newId= "s-"+(++number).ToString("d3");

            this.txtUserID.Text = newId;
        }





        private void ClearAll()
        {
            this.txtUserID.Clear();
            this.txtSellerUsername.Clear();
            this.txtPhoneNumber.Clear();
            this.txtLocation.Clear();
            this.txtSalary.Clear();
            this.AutoGenerateID();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
    }
}
