namespace BookShopManagement
{
    partial class SellerWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerWindow));
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.bookid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noofcopy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisheddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAutoSearchBook = new System.Windows.Forms.TextBox();
            this.cbAutoSearch = new System.Windows.Forms.ComboBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoofCopy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nupQuantity = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUserId = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.contextMenuStripDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.txtReturnAmount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCancelCartOrder = new System.Windows.Forms.Button();
            this.txtTotalBooks = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.contextMenuAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Discount)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.contextMenuStripDelete.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookid,
            this.bookname,
            this.author,
            this.genre,
            this.noofcopy,
            this.publisheddate,
            this.price});
            this.dgvBook.ContextMenuStrip = this.contextMenuAdd;
            this.dgvBook.Location = new System.Drawing.Point(12, 55);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(620, 234);
            this.dgvBook.TabIndex = 0;
            this.dgvBook.DoubleClick += new System.EventHandler(this.dgvBook_DoubleClick);
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
            // author
            // 
            this.author.DataPropertyName = "author";
            this.author.HeaderText = "Author";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // genre
            // 
            this.genre.DataPropertyName = "genre";
            this.genre.HeaderText = "Genre";
            this.genre.Name = "genre";
            this.genre.ReadOnly = true;
            // 
            // noofcopy
            // 
            this.noofcopy.DataPropertyName = "noofcopy";
            this.noofcopy.HeaderText = "No of Copy";
            this.noofcopy.Name = "noofcopy";
            this.noofcopy.ReadOnly = true;
            // 
            // publisheddate
            // 
            this.publisheddate.DataPropertyName = "publisheddate";
            this.publisheddate.HeaderText = "Published Date";
            this.publisheddate.Name = "publisheddate";
            this.publisheddate.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Unit Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // contextMenuAdd
            // 
            this.contextMenuAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.contextMenuAdd.Name = "contextMenuAdd";
            this.contextMenuAdd.Size = new System.Drawing.Size(97, 26);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // txtAutoSearchBook
            // 
            this.txtAutoSearchBook.ForeColor = System.Drawing.Color.DarkGray;
            this.txtAutoSearchBook.Location = new System.Drawing.Point(166, 29);
            this.txtAutoSearchBook.Name = "txtAutoSearchBook";
            this.txtAutoSearchBook.Size = new System.Drawing.Size(146, 20);
            this.txtAutoSearchBook.TabIndex = 1;
            this.txtAutoSearchBook.Text = "Search >>";
            this.txtAutoSearchBook.TextChanged += new System.EventHandler(this.txtAutoSearchBook_TextChanged);
            this.txtAutoSearchBook.Enter += new System.EventHandler(this.txtAutoSearchBook_Enter);
            this.txtAutoSearchBook.Leave += new System.EventHandler(this.txtAutoSearchBook_Leave);
            // 
            // cbAutoSearch
            // 
            this.cbAutoSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutoSearch.FormattingEnabled = true;
            this.cbAutoSearch.Items.AddRange(new object[] {
            "bookid",
            "bookname",
            "author",
            "genre"});
            this.cbAutoSearch.Location = new System.Drawing.Point(318, 29);
            this.cbAutoSearch.Name = "cbAutoSearch";
            this.cbAutoSearch.Size = new System.Drawing.Size(93, 21);
            this.cbAutoSearch.TabIndex = 2;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(137, 3);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(190, 20);
            this.txtOrderId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Order ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Book ID:";
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(136, 43);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.ReadOnly = true;
            this.txtBookId.Size = new System.Drawing.Size(191, 20);
            this.txtBookId.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Book Name:";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(137, 88);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(190, 20);
            this.txtBookName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(2, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "No. of Copy:";
            // 
            // txtNoofCopy
            // 
            this.txtNoofCopy.Location = new System.Drawing.Point(136, 131);
            this.txtNoofCopy.Name = "txtNoofCopy";
            this.txtNoofCopy.ReadOnly = true;
            this.txtNoofCopy.Size = new System.Drawing.Size(191, 20);
            this.txtNoofCopy.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantity:";
            // 
            // nupQuantity
            // 
            this.nupQuantity.Location = new System.Drawing.Point(137, 218);
            this.nupQuantity.Name = "nupQuantity";
            this.nupQuantity.Size = new System.Drawing.Size(190, 20);
            this.nupQuantity.TabIndex = 12;
            this.nupQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupQuantity.ValueChanged += new System.EventHandler(this.nupQuantity_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtTPrice);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtUPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNoofCopy);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nupQuantity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBookName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtOrderId);
            this.panel1.Controls.Add(this.txtBookId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 332);
            this.panel1.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(439, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 85);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(137, 179);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(190, 20);
            this.txtCustomerName.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(2, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Customer Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(439, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 90);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "    Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTPrice
            // 
            this.txtTPrice.Location = new System.Drawing.Point(137, 306);
            this.txtTPrice.Name = "txtTPrice";
            this.txtTPrice.ReadOnly = true;
            this.txtTPrice.Size = new System.Drawing.Size(190, 20);
            this.txtTPrice.TabIndex = 16;
            this.txtTPrice.Text = "0";
            this.txtTPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FloralWhite;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Price(Total):";
            // 
            // txtUPrice
            // 
            this.txtUPrice.Location = new System.Drawing.Point(137, 264);
            this.txtUPrice.Name = "txtUPrice";
            this.txtUPrice.ReadOnly = true;
            this.txtUPrice.Size = new System.Drawing.Size(190, 20);
            this.txtUPrice.TabIndex = 14;
            this.txtUPrice.Text = "0";
            this.txtUPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FloralWhite;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Price(Unit):";
            // 
            // Discount
            // 
            this.Discount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Discount.Location = new System.Drawing.Point(140, 119);
            this.Discount.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Size = new System.Drawing.Size(179, 20);
            this.Discount.TabIndex = 22;
            this.Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Discount.ValueChanged += new System.EventHandler(this.Discount_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Total Amount(Tk.):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Discount(%):";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(141, 166);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(179, 20);
            this.txtTotal.TabIndex = 21;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblUserId);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(13, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 48);
            this.panel2.TabIndex = 14;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(56, 27);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(43, 13);
            this.lblUserId.TabIndex = 3;
            this.lblUserId.Text = "User-ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(4, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "User ID:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Silver;
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(58, 4);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(10, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(4, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Username:";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.ContextMenuStrip = this.contextMenuStripDelete;
            this.dgvOrder.Location = new System.Drawing.Point(638, 62);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(686, 256);
            this.dgvOrder.TabIndex = 15;
            // 
            // contextMenuStripDelete
            // 
            this.contextMenuStripDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStripDelete.Name = "contextMenuStrip";
            this.contextMenuStripDelete.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(140, 19);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(182, 20);
            this.txtSubtotal.TabIndex = 17;
            this.txtSubtotal.Text = "0";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(7, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Sub total(Tk.):";
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.AliceBlue;
            this.panel.Controls.Add(this.btnPrintPreview);
            this.panel.Controls.Add(this.txtReturnAmount);
            this.panel.Controls.Add(this.label17);
            this.panel.Controls.Add(this.txtAmountPaid);
            this.panel.Controls.Add(this.label16);
            this.panel.Controls.Add(this.btnCancelCartOrder);
            this.panel.Controls.Add(this.label13);
            this.panel.Controls.Add(this.Discount);
            this.panel.Controls.Add(this.txtTotal);
            this.panel.Controls.Add(this.btnCheckOut);
            this.panel.Controls.Add(this.txtTotalBooks);
            this.panel.Controls.Add(this.label14);
            this.panel.Controls.Add(this.label12);
            this.panel.Controls.Add(this.label10);
            this.panel.Controls.Add(this.txtSubtotal);
            this.panel.Location = new System.Drawing.Point(638, 324);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(686, 303);
            this.panel.TabIndex = 19;
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintPreview.Image")));
            this.btnPrintPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintPreview.Location = new System.Drawing.Point(422, 116);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(207, 69);
            this.btnPrintPreview.TabIndex = 27;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.UseVisualStyleBackColor = true;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // txtReturnAmount
            // 
            this.txtReturnAmount.Location = new System.Drawing.Point(141, 266);
            this.txtReturnAmount.Name = "txtReturnAmount";
            this.txtReturnAmount.ReadOnly = true;
            this.txtReturnAmount.Size = new System.Drawing.Size(182, 20);
            this.txtReturnAmount.TabIndex = 26;
            this.txtReturnAmount.Text = "0";
            this.txtReturnAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(17, 266);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 20);
            this.label17.TabIndex = 25;
            this.label17.Text = "Balance(Tk.):";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Location = new System.Drawing.Point(141, 216);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(182, 20);
            this.txtAmountPaid.TabIndex = 24;
            this.txtAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmountPaid.TextChanged += new System.EventHandler(this.txtAmountPaid_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 214);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 20);
            this.label16.TabIndex = 23;
            this.label16.Text = "Amount Paid(Tk.):";
            // 
            // btnCancelCartOrder
            // 
            this.btnCancelCartOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCartOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelCartOrder.Image")));
            this.btnCancelCartOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelCartOrder.Location = new System.Drawing.Point(422, 217);
            this.btnCancelCartOrder.Name = "btnCancelCartOrder";
            this.btnCancelCartOrder.Size = new System.Drawing.Size(207, 69);
            this.btnCancelCartOrder.TabIndex = 21;
            this.btnCancelCartOrder.Text = "Cancel Order";
            this.btnCancelCartOrder.UseVisualStyleBackColor = true;
            this.btnCancelCartOrder.Click += new System.EventHandler(this.btnCancelCartOrder_Click);
            // 
            // txtTotalBooks
            // 
            this.txtTotalBooks.Location = new System.Drawing.Point(140, 68);
            this.txtTotalBooks.Name = "txtTotalBooks";
            this.txtTotalBooks.ReadOnly = true;
            this.txtTotalBooks.Size = new System.Drawing.Size(182, 20);
            this.txtTotalBooks.TabIndex = 20;
            this.txtTotalBooks.Text = "0";
            this.txtTotalBooks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(3, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Total Books:";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnLogout.Location = new System.Drawing.Point(1197, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(127, 23);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePassword.BackColor = System.Drawing.Color.White;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChangePassword.Location = new System.Drawing.Point(1046, 6);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(137, 23);
            this.btnChangePassword.TabIndex = 21;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(639, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 20);
            this.label15.TabIndex = 23;
            this.label15.Text = "Cart :";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(1117, 43);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "Date";
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.ShowIcon = false;
            this.printPreviewDialog.Visible = false;
            // 
            // lblOrderId
            // 
            this.lblOrderId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.BackColor = System.Drawing.Color.White;
            this.lblOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderId.Location = new System.Drawing.Point(686, 43);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(14, 20);
            this.lblOrderId.TabIndex = 25;
            this.lblOrderId.Text = "-";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(834, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 20);
            this.label18.TabIndex = 26;
            this.label18.Text = "Customer Name :";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.White;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(966, 43);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(14, 20);
            this.lblCustomerName.TabIndex = 27;
            this.lblCustomerName.Text = "-";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
            this.btnCheckOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckOut.Location = new System.Drawing.Point(422, 16);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(207, 69);
            this.btnCheckOut.TabIndex = 21;
            this.btnCheckOut.Text = "         Check Out";
            this.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // SellerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1336, 632);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbAutoSearch);
            this.Controls.Add(this.txtAutoSearchBook);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "SellerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seller Window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SellerWindow_FormClosed);
            this.Load += new System.EventHandler(this.SellerWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.contextMenuAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Discount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.contextMenuStripDelete.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookname;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn noofcopy;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisheddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.TextBox txtAutoSearchBook;
        private System.Windows.Forms.ComboBox cbAutoSearch;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoofCopy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nupQuantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDelete;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown Discount;
        private System.Windows.Forms.TextBox txtTotalBooks;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.ContextMenuStrip contextMenuAdd;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnCancelCartOrder;
        private System.Windows.Forms.TextBox txtReturnAmount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnCheckOut;
    }
}