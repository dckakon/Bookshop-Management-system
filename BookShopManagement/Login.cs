using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookShopManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                String sql = @"select* from login where userId= '" + txtUserID.Text + "' and password= '" + txtPassword.Text + "' ;";

                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    string type = ds.Tables[0].Rows[0][2].ToString();
                    string name = ds.Tables[0].Rows[0][3].ToString();
                    string id = ds.Tables[0].Rows[0][0].ToString();
                    MessageBox.Show("Login approved for-"+ name +", Type-" + type);

                    if (type == "manager")
                    {

                        ManagerWindow mw = new ManagerWindow(name, id, this);
                        mw.Visible = true;
                        this.Visible = false;

                    }
                    if (type == "seller")
                    {
                        SellerWindow sw = new SellerWindow(name, id, this);
                        sw.Visible = true;
                        this.Visible = false;

                    }
                }
                else
                    MessageBox.Show("Login Invalid");
            }
            catch (Exception exc)
            { MessageBox.Show("Login Invalid"); }

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShowPassword.Checked)
                txtPassword.UseSystemPasswordChar = true;
            else
                txtPassword.UseSystemPasswordChar = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUserID.Text="";
            txtPassword.Text="";
        }
    }
}
