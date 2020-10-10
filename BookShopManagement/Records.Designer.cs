namespace BookShopManagement
{
    partial class Records
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Records));
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAccounts = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSellQuantity = new System.Windows.Forms.Label();
            this.txtRecordsSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecords
            // 
            this.dgvRecords.AllowUserToAddRows = false;
            this.dgvRecords.AllowUserToDeleteRows = false;
            this.dgvRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecords.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serial,
            this.orderid,
            this.userid,
            this.username,
            this.customername,
            this.bookid,
            this.bookname,
            this.quantity,
            this.price,
            this.orderdate});
            this.dgvRecords.Location = new System.Drawing.Point(12, 84);
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.ReadOnly = true;
            this.dgvRecords.Size = new System.Drawing.Size(1117, 409);
            this.dgvRecords.TabIndex = 1;
            // 
            // serial
            // 
            this.serial.DataPropertyName = "serial";
            this.serial.HeaderText = "Serial";
            this.serial.Name = "serial";
            this.serial.ReadOnly = true;
            // 
            // orderid
            // 
            this.orderid.DataPropertyName = "orderid";
            this.orderid.HeaderText = "Order ID";
            this.orderid.Name = "orderid";
            this.orderid.ReadOnly = true;
            // 
            // userid
            // 
            this.userid.DataPropertyName = "userid";
            this.userid.HeaderText = "User ID";
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Seller Name";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // customername
            // 
            this.customername.DataPropertyName = "customername";
            this.customername.HeaderText = "Customer Name";
            this.customername.Name = "customername";
            this.customername.ReadOnly = true;
            // 
            // bookid
            // 
            this.bookid.DataPropertyName = "bookid";
            this.bookid.HeaderText = "Book ID";
            this.bookid.Name = "bookid";
            this.bookid.ReadOnly = true;
            // 
            // bookname
            // 
            this.bookname.DataPropertyName = "bookname";
            this.bookname.HeaderText = "Book Name";
            this.bookname.Name = "bookname";
            this.bookname.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // orderdate
            // 
            this.orderdate.DataPropertyName = "orderdate";
            this.orderdate.HeaderText = "Order Date & Time";
            this.orderdate.Name = "orderdate";
            this.orderdate.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Accounts (TK.):";
            // 
            // lblAccounts
            // 
            this.lblAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccounts.AutoSize = true;
            this.lblAccounts.BackColor = System.Drawing.Color.White;
            this.lblAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccounts.Location = new System.Drawing.Point(624, 21);
            this.lblAccounts.Name = "lblAccounts";
            this.lblAccounts.Size = new System.Drawing.Size(20, 24);
            this.lblAccounts.TabIndex = 3;
            this.lblAccounts.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(842, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = " Total Sell Quantity:";
            // 
            // lblSellQuantity
            // 
            this.lblSellQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSellQuantity.AutoSize = true;
            this.lblSellQuantity.BackColor = System.Drawing.Color.White;
            this.lblSellQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellQuantity.Location = new System.Drawing.Point(1007, 21);
            this.lblSellQuantity.Name = "lblSellQuantity";
            this.lblSellQuantity.Size = new System.Drawing.Size(20, 24);
            this.lblSellQuantity.TabIndex = 5;
            this.lblSellQuantity.Text = "0";
            // 
            // txtRecordsSearch
            // 
            this.txtRecordsSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txtRecordsSearch.Location = new System.Drawing.Point(13, 24);
            this.txtRecordsSearch.Name = "txtRecordsSearch";
            this.txtRecordsSearch.Size = new System.Drawing.Size(193, 20);
            this.txtRecordsSearch.TabIndex = 6;
            this.txtRecordsSearch.Text = "Search >>";
            this.txtRecordsSearch.TextChanged += new System.EventHandler(this.txtRecordsSearch_TextChanged);
            this.txtRecordsSearch.Enter += new System.EventHandler(this.txtRecordsSearch_Enter);
            this.txtRecordsSearch.Leave += new System.EventHandler(this.txtRecordsSearch_Leave);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "serial",
            "orderid",
            "userid",
            "bookid"});
            this.comboBoxSearch.Location = new System.Drawing.Point(212, 24);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(85, 21);
            this.comboBoxSearch.TabIndex = 7;
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1131, 495);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.txtRecordsSearch);
            this.Controls.Add(this.lblSellQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAccounts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRecords);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Records";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Records_Closed);
            this.Load += new System.EventHandler(this.Records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccounts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSellQuantity;
        private System.Windows.Forms.TextBox txtRecordsSearch;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderid;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn customername;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdate;
    }
}