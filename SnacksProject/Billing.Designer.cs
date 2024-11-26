namespace SnacksProject
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbSnack = new System.Windows.Forms.GroupBox();
            this.gbCoolDrink = new System.Windows.Forms.GroupBox();
            this.llExit = new System.Windows.Forms.LinkLabel();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbQuantity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBillCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGst = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFinalbill = new System.Windows.Forms.TextBox();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBilledby = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustomerid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbPayment = new System.Windows.Forms.ComboBox();
            this.txtBillidno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProductid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCoolDrink = new System.Windows.Forms.Button();
            this.btnSnack = new System.Windows.Forms.Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.gbSnack.SuspendLayout();
            this.gbCoolDrink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCoolDrink);
            this.panel1.Controls.Add(this.btnSnack);
            this.panel1.Location = new System.Drawing.Point(12, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 636);
            this.panel1.TabIndex = 0;
            // 
            // gbSnack
            // 
            this.gbSnack.Controls.Add(this.button2);
            this.gbSnack.Controls.Add(this.button1);
            this.gbSnack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSnack.Location = new System.Drawing.Point(260, 56);
            this.gbSnack.Name = "gbSnack";
            this.gbSnack.Size = new System.Drawing.Size(464, 280);
            this.gbSnack.TabIndex = 1;
            this.gbSnack.TabStop = false;
            this.gbSnack.Text = "Snacks";
            // 
            // gbCoolDrink
            // 
            this.gbCoolDrink.Controls.Add(this.button3);
            this.gbCoolDrink.Controls.Add(this.button4);
            this.gbCoolDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCoolDrink.Location = new System.Drawing.Point(260, 56);
            this.gbCoolDrink.Name = "gbCoolDrink";
            this.gbCoolDrink.Size = new System.Drawing.Size(464, 280);
            this.gbCoolDrink.TabIndex = 2;
            this.gbCoolDrink.TabStop = false;
            this.gbCoolDrink.Text = "Cool Drinks";
            this.gbCoolDrink.Enter += new System.EventHandler(this.gbCoolDrink_Enter);
            // 
            // llExit
            // 
            this.llExit.AutoSize = true;
            this.llExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llExit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llExit.LinkColor = System.Drawing.Color.Red;
            this.llExit.Location = new System.Drawing.Point(1122, 9);
            this.llExit.Name = "llExit";
            this.llExit.Size = new System.Drawing.Size(66, 32);
            this.llExit.TabIndex = 3;
            this.llExit.TabStop = true;
            this.llExit.Text = "Exit";
            this.llExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llExit_LinkClicked);
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(750, 103);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(377, 34);
            this.txtProductName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(754, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(759, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cost";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(760, 205);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(373, 34);
            this.txtCost.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(768, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantity";
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.BorderThickness = 3;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(1041, 327);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 45);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productname,
            this.quantity,
            this.amount,
            this.ProductId});
            this.dgvProduct.Location = new System.Drawing.Point(247, 393);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(928, 227);
            this.dgvProduct.TabIndex = 12;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // productname
            // 
            this.productname.HeaderText = "Product Name";
            this.productname.MinimumWidth = 6;
            this.productname.Name = "productname";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.MinimumWidth = 6;
            this.ProductId.Name = "ProductId";
            // 
            // cbQuantity
            // 
            this.cbQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuantity.FormattingEnabled = true;
            this.cbQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbQuantity.Location = new System.Drawing.Point(772, 313);
            this.cbQuantity.Name = "cbQuantity";
            this.cbQuantity.Size = new System.Drawing.Size(234, 33);
            this.cbQuantity.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(242, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Billing Table";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(866, 634);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Bill Cost";
            // 
            // txtBillCost
            // 
            this.txtBillCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillCost.Location = new System.Drawing.Point(991, 629);
            this.txtBillCost.Name = "txtBillCost";
            this.txtBillCost.Size = new System.Drawing.Size(184, 34);
            this.txtBillCost.TabIndex = 15;
            this.txtBillCost.TextChanged += new System.EventHandler(this.txtBillCost_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(911, 677);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "GST";
            // 
            // txtGst
            // 
            this.txtGst.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGst.Location = new System.Drawing.Point(991, 674);
            this.txtGst.Name = "txtGst";
            this.txtGst.Size = new System.Drawing.Size(184, 34);
            this.txtGst.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(861, 717);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "Final Bill";
            // 
            // txtFinalbill
            // 
            this.txtFinalbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalbill.Location = new System.Drawing.Point(991, 714);
            this.txtFinalbill.Name = "txtFinalbill";
            this.txtFinalbill.Size = new System.Drawing.Size(184, 34);
            this.txtFinalbill.TabIndex = 19;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BorderRadius = 5;
            this.btnSubmit.BorderThickness = 3;
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(967, 760);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(208, 45);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "Welcome";
            // 
            // txtBilledby
            // 
            this.txtBilledby.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBilledby.Location = new System.Drawing.Point(31, 117);
            this.txtBilledby.Name = "txtBilledby";
            this.txtBilledby.Size = new System.Drawing.Size(200, 34);
            this.txtBilledby.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(255, 691);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 29);
            this.label9.TabIndex = 25;
            this.label9.Text = "Customer Id";
            // 
            // txtCustomerid
            // 
            this.txtCustomerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerid.Location = new System.Drawing.Point(424, 690);
            this.txtCustomerid.Name = "txtCustomerid";
            this.txtCustomerid.Size = new System.Drawing.Size(215, 34);
            this.txtCustomerid.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(298, 741);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 29);
            this.label10.TabIndex = 27;
            this.label10.Text = "Payment";
            // 
            // cbPayment
            // 
            this.cbPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPayment.FormattingEnabled = true;
            this.cbPayment.Items.AddRange(new object[] {
            "Cash Payment",
            "Online Payment"});
            this.cbPayment.Location = new System.Drawing.Point(424, 736);
            this.cbPayment.Name = "cbPayment";
            this.cbPayment.Size = new System.Drawing.Size(215, 37);
            this.cbPayment.TabIndex = 28;
            // 
            // txtBillidno
            // 
            this.txtBillidno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillidno.Location = new System.Drawing.Point(719, 766);
            this.txtBillidno.Name = "txtBillidno";
            this.txtBillidno.Size = new System.Drawing.Size(89, 34);
            this.txtBillidno.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(687, 727);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 29);
            this.label11.TabIndex = 30;
            this.label11.Text = "Bill Id No";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(671, 634);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 29);
            this.label12.TabIndex = 32;
            this.label12.Text = "Product Id";
            // 
            // txtProductid
            // 
            this.txtProductid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductid.Location = new System.Drawing.Point(703, 672);
            this.txtProductid.Name = "txtProductid";
            this.txtProductid.Size = new System.Drawing.Size(89, 34);
            this.txtProductid.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(277, 646);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 29);
            this.label13.TabIndex = 34;
            this.label13.Text = "Mobile No";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.Location = new System.Drawing.Point(426, 644);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(215, 34);
            this.txtMobileNo.TabIndex = 33;
            this.txtMobileNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMobileNo_KeyDown);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(253, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 112);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(21, 84);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 112);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(253, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 112);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(21, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 112);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCoolDrink
            // 
            this.btnCoolDrink.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCoolDrink.BackgroundImage")));
            this.btnCoolDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCoolDrink.Location = new System.Drawing.Point(19, 168);
            this.btnCoolDrink.Name = "btnCoolDrink";
            this.btnCoolDrink.Size = new System.Drawing.Size(175, 112);
            this.btnCoolDrink.TabIndex = 1;
            this.btnCoolDrink.UseVisualStyleBackColor = true;
            this.btnCoolDrink.Click += new System.EventHandler(this.btnCoolDrink_Click);
            // 
            // btnSnack
            // 
            this.btnSnack.BackgroundImage = global::SnacksProject.Properties.Resources.snack;
            this.btnSnack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSnack.Location = new System.Drawing.Point(19, 16);
            this.btnSnack.Name = "btnSnack";
            this.btnSnack.Size = new System.Drawing.Size(175, 112);
            this.btnSnack.TabIndex = 0;
            this.btnSnack.UseVisualStyleBackColor = true;
            this.btnSnack.Click += new System.EventHandler(this.btnSnack_Click);
            // 
            // btnHome
            // 
            this.btnHome.BorderRadius = 5;
            this.btnHome.BorderThickness = 3;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(14, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(134, 45);
            this.btnHome.TabIndex = 35;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 817);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtProductid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBillidno);
            this.Controls.Add(this.cbPayment);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCustomerid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBilledby);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFinalbill);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGst);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBillCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbQuantity);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.llExit);
            this.Controls.Add(this.gbCoolDrink);
            this.Controls.Add(this.gbSnack);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.panel1.ResumeLayout(false);
            this.gbSnack.ResumeLayout(false);
            this.gbCoolDrink.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSnack;
        private System.Windows.Forms.Button btnCoolDrink;
        private System.Windows.Forms.GroupBox gbSnack;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbCoolDrink;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.LinkLabel llExit;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.ComboBox cbQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBillCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGst;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFinalbill;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBilledby;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustomerid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbPayment;
        private System.Windows.Forms.TextBox txtBillidno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtProductid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMobileNo;
        private Guna.UI2.WinForms.Guna2Button btnHome;
    }
}