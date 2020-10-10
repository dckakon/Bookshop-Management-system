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
    public partial class ManagerWindow : Form
    {
        private Login Lgn { get; set; }   //auto implemented property || No validation
        public ManagerWindow()
        {
            InitializeComponent();
        }
        public ManagerWindow(string name,string id,Login lgn):this()
        {
            this.lblUserName.Text = name;
            this.lbluserIDUp.Text = id;
            this.Lgn = lgn;
        }

        private void btnManageSeller_Click(object sender, EventArgs e)
        {
            manageSeller.BringToFront();
            lblTitle.Text = "Manage Seller";

        }

        private void btnManageBook_Click(object sender, EventArgs e)
        {
            manageBook.BringToFront();
            lblTitle.Text = "Manage Book";
        }

        private void ManagerWindow_FormClosed(object sender, FormClosedEventArgs e)
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
            string id=this.lbluserIDUp.Text.ToString();
        
            ChangePassword cp = new ChangePassword(id);
            cp.Visible = true;
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            Records rc = new Records();
            rc.Visible = true;
          
        }
    }
}
