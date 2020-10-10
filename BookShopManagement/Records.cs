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
    public partial class Records : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private String Sql { get; set; }
        public Records()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.RecordsGridView();
            comboBoxSearch.SelectedIndex = 1;
        }
        private void RecordsGridView(string sql = @"select records.serial,records.orderid,records.userid ,login.username,
                                     records.customername, records.bookid, records.bookname, records.quantity, records.price, records.orderdate
                                        from records inner join login on records.userid= login.userId;")//optional value
        {
            this.Ds = Da.ExecuteQuery(sql);
            this.dgvRecords.AutoGenerateColumns = false;
            this.dgvRecords.DataSource = Ds.Tables[0] ;


        }

      //  select sum(price) from records


      

        private void Records_Load(object sender, EventArgs e)
        {
            this.Sql = "select sum(price) from records";
            this.Ds = Da.ExecuteQuery(this.Sql);
            this.lblAccounts.Text = Ds.Tables[0].Rows[0][0].ToString();

            this.Sql = "select sum(quantity) from records";
            this.Ds = Da.ExecuteQuery(this.Sql);
            this.lblSellQuantity.Text = Ds.Tables[0].Rows[0][0].ToString();
        }

        private void Records_Closed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }

        private void txtRecordsSearch_Enter(object sender, EventArgs e)
        {
            if (txtRecordsSearch.Text == "Search >>")
            {
                txtRecordsSearch.Text = "";
                txtRecordsSearch.ForeColor = Color.Black;
            }
        }

        private void txtRecordsSearch_Leave(object sender, EventArgs e)
        {
            if (txtRecordsSearch.Text == "")
            {
                txtRecordsSearch.Text = "Search >>";
                txtRecordsSearch.ForeColor = Color.DarkGray;
                this.RecordsGridView();
            }

        }

        private void txtRecordsSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = @"select records.serial,records.orderid,records.userid ,login.username,
                                     records.customername, records.bookid, records.bookname, records.quantity, records.price, records.orderdate
                                        from records inner join login on records.userid = login.userId where "+ this.comboBoxSearch.Text + " like '" + txtRecordsSearch.Text + "%';";
            this.RecordsGridView(this.Sql);

        }
    }
}
