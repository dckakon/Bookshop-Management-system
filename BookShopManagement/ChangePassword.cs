using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement
{
    public partial class ChangePassword : Form
    {
        private DataAccess Da { get; set; }
       private String Sql { get; set; }
 
      
        public ChangePassword()
        {
            InitializeComponent();
        }
        public ChangePassword(string id) :this() 
        {
            
            this.Da = new DataAccess();
            this.lblUserId.Text = id;

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (this.txtChangePassword.Text.ToString() != "")
            {
                if (this.txtChangePassword.Text.ToString() == this.txtRetypePass.Text.ToString())
                {
                    this.Sql = @"update login set password ='" + this.txtChangePassword.Text + "' where userId= '" + this.lblUserId.Text + "';";

                    int count = this.Da.ExecuteUpdateQuery(this.Sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Password Changed");
                    }
                    else { MessageBox.Show("Password Changed Failed"); }
                    this.Close();
                }
            }
            else { MessageBox.Show("Invalid"); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
