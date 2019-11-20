namespace RepairShopProject
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TPCustomers = new System.Windows.Forms.TabPage();
            this.BTCSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BTCClear = new System.Windows.Forms.Button();
            this.DGCustomer = new System.Windows.Forms.DataGridView();
            this.TBCId = new System.Windows.Forms.TextBox();
            this.BTCUpdate = new System.Windows.Forms.Button();
            this.BTCRemove = new System.Windows.Forms.Button();
            this.BTCAdd = new System.Windows.Forms.Button();
            this.TBCPhone = new System.Windows.Forms.TextBox();
            this.TBCMail = new System.Windows.Forms.TextBox();
            this.TBCSurname = new System.Windows.Forms.TextBox();
            this.TBCName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TBInventory = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.BTClear = new System.Windows.Forms.Button();
            this.DGInventory = new System.Windows.Forms.DataGridView();
            this.TBIId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BTIUpdate = new System.Windows.Forms.Button();
            this.BTIRemove = new System.Windows.Forms.Button();
            this.BTIAdd = new System.Windows.Forms.Button();
            this.CBICategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBIManifact = new System.Windows.Forms.TextBox();
            this.TBIAmount = new System.Windows.Forms.TextBox();
            this.TBIBuyprice = new System.Windows.Forms.TextBox();
            this.TBIModel = new System.Windows.Forms.TextBox();
            this.TBIName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TPAppointments = new System.Windows.Forms.TabPage();
            this.TPPayment = new System.Windows.Forms.TabPage();
            this.TPSupplier = new System.Windows.Forms.TabPage();
            this.TPTickets = new System.Windows.Forms.TabPage();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.TPCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomer)).BeginInit();
            this.TBInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TPCustomers);
            this.tabControl1.Controls.Add(this.TBInventory);
            this.tabControl1.Controls.Add(this.TPAppointments);
            this.tabControl1.Controls.Add(this.TPPayment);
            this.tabControl1.Controls.Add(this.TPSupplier);
            this.tabControl1.Controls.Add(this.TPTickets);
            this.tabControl1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.ImageList = this.ımageList1;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1240, 657);
            this.tabControl1.TabIndex = 0;
            // 
            // TPCustomers
            // 
            this.TPCustomers.BackColor = System.Drawing.Color.White;
            this.TPCustomers.Controls.Add(this.BTCSearch);
            this.TPCustomers.Controls.Add(this.label8);
            this.TPCustomers.Controls.Add(this.BTCClear);
            this.TPCustomers.Controls.Add(this.DGCustomer);
            this.TPCustomers.Controls.Add(this.TBCId);
            this.TPCustomers.Controls.Add(this.BTCUpdate);
            this.TPCustomers.Controls.Add(this.BTCRemove);
            this.TPCustomers.Controls.Add(this.BTCAdd);
            this.TPCustomers.Controls.Add(this.TBCPhone);
            this.TPCustomers.Controls.Add(this.TBCMail);
            this.TPCustomers.Controls.Add(this.TBCSurname);
            this.TPCustomers.Controls.Add(this.TBCName);
            this.TPCustomers.Controls.Add(this.label10);
            this.TPCustomers.Controls.Add(this.label11);
            this.TPCustomers.Controls.Add(this.label12);
            this.TPCustomers.Controls.Add(this.label13);
            this.TPCustomers.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TPCustomers.ImageKey = "man.png";
            this.TPCustomers.Location = new System.Drawing.Point(4, 32);
            this.TPCustomers.Name = "TPCustomers";
            this.TPCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.TPCustomers.Size = new System.Drawing.Size(1232, 621);
            this.TPCustomers.TabIndex = 0;
            this.TPCustomers.Text = "Customers";
            this.TPCustomers.Enter += new System.EventHandler(this.TPCustomers_Enter);
            // 
            // BTCSearch
            // 
            this.BTCSearch.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTCSearch.Location = new System.Drawing.Point(1092, 333);
            this.BTCSearch.Name = "BTCSearch";
            this.BTCSearch.Size = new System.Drawing.Size(134, 67);
            this.BTCSearch.TabIndex = 41;
            this.BTCSearch.Text = "SEARCH";
            this.BTCSearch.UseVisualStyleBackColor = true;
            this.BTCSearch.Click += new System.EventHandler(this.BTCSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(858, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 19);
            this.label8.TabIndex = 38;
            this.label8.Text = "ID";
            // 
            // BTCClear
            // 
            this.BTCClear.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTCClear.Location = new System.Drawing.Point(908, 42);
            this.BTCClear.Name = "BTCClear";
            this.BTCClear.Size = new System.Drawing.Size(178, 40);
            this.BTCClear.TabIndex = 37;
            this.BTCClear.Text = "Clear";
            this.BTCClear.UseVisualStyleBackColor = true;
            this.BTCClear.Click += new System.EventHandler(this.BTCClear_Click);
            // 
            // DGCustomer
            // 
            this.DGCustomer.AllowUserToAddRows = false;
            this.DGCustomer.AllowUserToDeleteRows = false;
            this.DGCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGCustomer.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCustomer.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGCustomer.Location = new System.Drawing.Point(10, 88);
            this.DGCustomer.Name = "DGCustomer";
            this.DGCustomer.ReadOnly = true;
            this.DGCustomer.RowHeadersVisible = false;
            this.DGCustomer.RowHeadersWidth = 125;
            this.DGCustomer.Size = new System.Drawing.Size(1076, 524);
            this.DGCustomer.TabIndex = 36;
            this.DGCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCustomer_CellClick);
            // 
            // TBCId
            // 
            this.TBCId.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBCId.Location = new System.Drawing.Point(908, 13);
            this.TBCId.Name = "TBCId";
            this.TBCId.Size = new System.Drawing.Size(178, 27);
            this.TBCId.TabIndex = 35;
            // 
            // BTCUpdate
            // 
            this.BTCUpdate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTCUpdate.Location = new System.Drawing.Point(1092, 260);
            this.BTCUpdate.Name = "BTCUpdate";
            this.BTCUpdate.Size = new System.Drawing.Size(134, 67);
            this.BTCUpdate.TabIndex = 34;
            this.BTCUpdate.Text = "UPDATE";
            this.BTCUpdate.UseVisualStyleBackColor = true;
            this.BTCUpdate.Click += new System.EventHandler(this.BTCUpdate_Click);
            // 
            // BTCRemove
            // 
            this.BTCRemove.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTCRemove.Location = new System.Drawing.Point(1092, 187);
            this.BTCRemove.Name = "BTCRemove";
            this.BTCRemove.Size = new System.Drawing.Size(134, 67);
            this.BTCRemove.TabIndex = 33;
            this.BTCRemove.Text = "REMOVE";
            this.BTCRemove.UseVisualStyleBackColor = true;
            this.BTCRemove.Click += new System.EventHandler(this.BTCRemove_Click);
            // 
            // BTCAdd
            // 
            this.BTCAdd.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTCAdd.Location = new System.Drawing.Point(1092, 114);
            this.BTCAdd.Name = "BTCAdd";
            this.BTCAdd.Size = new System.Drawing.Size(134, 67);
            this.BTCAdd.TabIndex = 32;
            this.BTCAdd.Text = "ADD";
            this.BTCAdd.UseVisualStyleBackColor = true;
            this.BTCAdd.Click += new System.EventHandler(this.BTCAdd_Click);
            // 
            // TBCPhone
            // 
            this.TBCPhone.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBCPhone.Location = new System.Drawing.Point(538, 12);
            this.TBCPhone.Name = "TBCPhone";
            this.TBCPhone.Size = new System.Drawing.Size(242, 27);
            this.TBCPhone.TabIndex = 29;
            // 
            // TBCMail
            // 
            this.TBCMail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBCMail.Location = new System.Drawing.Point(538, 55);
            this.TBCMail.Name = "TBCMail";
            this.TBCMail.Size = new System.Drawing.Size(242, 27);
            this.TBCMail.TabIndex = 28;
            // 
            // TBCSurname
            // 
            this.TBCSurname.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBCSurname.Location = new System.Drawing.Point(96, 55);
            this.TBCSurname.Name = "TBCSurname";
            this.TBCSurname.Size = new System.Drawing.Size(266, 27);
            this.TBCSurname.TabIndex = 26;
            // 
            // TBCName
            // 
            this.TBCName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBCName.Location = new System.Drawing.Point(96, 12);
            this.TBCName.Name = "TBCName";
            this.TBCName.Size = new System.Drawing.Size(266, 27);
            this.TBCName.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(422, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "E-MAIL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(424, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "PHONE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(6, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 19);
            this.label12.TabIndex = 21;
            this.label12.Text = "SURNAME";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(6, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 19);
            this.label13.TabIndex = 20;
            this.label13.Text = "NAME";
            // 
            // TBInventory
            // 
            this.TBInventory.BackColor = System.Drawing.Color.White;
            this.TBInventory.Controls.Add(this.button1);
            this.TBInventory.Controls.Add(this.BTClear);
            this.TBInventory.Controls.Add(this.DGInventory);
            this.TBInventory.Controls.Add(this.TBIId);
            this.TBInventory.Controls.Add(this.label7);
            this.TBInventory.Controls.Add(this.BTIUpdate);
            this.TBInventory.Controls.Add(this.BTIRemove);
            this.TBInventory.Controls.Add(this.BTIAdd);
            this.TBInventory.Controls.Add(this.CBICategory);
            this.TBInventory.Controls.Add(this.label6);
            this.TBInventory.Controls.Add(this.TBIManifact);
            this.TBInventory.Controls.Add(this.TBIAmount);
            this.TBInventory.Controls.Add(this.TBIBuyprice);
            this.TBInventory.Controls.Add(this.TBIModel);
            this.TBInventory.Controls.Add(this.TBIName);
            this.TBInventory.Controls.Add(this.label5);
            this.TBInventory.Controls.Add(this.label4);
            this.TBInventory.Controls.Add(this.label3);
            this.TBInventory.Controls.Add(this.label2);
            this.TBInventory.Controls.Add(this.label1);
            this.TBInventory.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBInventory.ImageKey = "boxes.png";
            this.TBInventory.Location = new System.Drawing.Point(4, 32);
            this.TBInventory.Name = "TBInventory";
            this.TBInventory.Padding = new System.Windows.Forms.Padding(3);
            this.TBInventory.Size = new System.Drawing.Size(1232, 621);
            this.TBInventory.TabIndex = 1;
            this.TBInventory.Text = "Inventory";
            this.TBInventory.Enter += new System.EventHandler(this.TBInventory_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1092, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 67);
            this.button1.TabIndex = 22;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BTClear
            // 
            this.BTClear.Location = new System.Drawing.Point(1125, 63);
            this.BTClear.Name = "BTClear";
            this.BTClear.Size = new System.Drawing.Size(74, 28);
            this.BTClear.TabIndex = 19;
            this.BTClear.Text = "Clear";
            this.BTClear.UseVisualStyleBackColor = true;
            this.BTClear.Click += new System.EventHandler(this.BTClear_Click);
            // 
            // DGInventory
            // 
            this.DGInventory.AllowUserToAddRows = false;
            this.DGInventory.AllowUserToDeleteRows = false;
            this.DGInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGInventory.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGInventory.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGInventory.Location = new System.Drawing.Point(12, 95);
            this.DGInventory.Name = "DGInventory";
            this.DGInventory.ReadOnly = true;
            this.DGInventory.RowHeadersVisible = false;
            this.DGInventory.RowHeadersWidth = 125;
            this.DGInventory.Size = new System.Drawing.Size(1076, 524);
            this.DGInventory.TabIndex = 18;
            this.DGInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGInventory_CellClick_1);
            // 
            // TBIId
            // 
            this.TBIId.Location = new System.Drawing.Point(1137, 25);
            this.TBIId.Name = "TBIId";
            this.TBIId.Size = new System.Drawing.Size(47, 27);
            this.TBIId.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1149, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "ID";
            // 
            // BTIUpdate
            // 
            this.BTIUpdate.Location = new System.Drawing.Point(1092, 270);
            this.BTIUpdate.Name = "BTIUpdate";
            this.BTIUpdate.Size = new System.Drawing.Size(134, 67);
            this.BTIUpdate.TabIndex = 15;
            this.BTIUpdate.Text = "UPDATE";
            this.BTIUpdate.UseVisualStyleBackColor = true;
            this.BTIUpdate.Click += new System.EventHandler(this.BTUpdate_Click);
            // 
            // BTIRemove
            // 
            this.BTIRemove.Location = new System.Drawing.Point(1092, 197);
            this.BTIRemove.Name = "BTIRemove";
            this.BTIRemove.Size = new System.Drawing.Size(134, 67);
            this.BTIRemove.TabIndex = 14;
            this.BTIRemove.Text = "REMOVE";
            this.BTIRemove.UseVisualStyleBackColor = true;
            this.BTIRemove.Click += new System.EventHandler(this.BTRemove_Click);
            // 
            // BTIAdd
            // 
            this.BTIAdd.Location = new System.Drawing.Point(1092, 124);
            this.BTIAdd.Name = "BTIAdd";
            this.BTIAdd.Size = new System.Drawing.Size(134, 67);
            this.BTIAdd.TabIndex = 13;
            this.BTIAdd.Text = "ADD";
            this.BTIAdd.UseVisualStyleBackColor = true;
            this.BTIAdd.Click += new System.EventHandler(this.BTAdd_Click);
            // 
            // CBICategory
            // 
            this.CBICategory.FormattingEnabled = true;
            this.CBICategory.Items.AddRange(new object[] {
            "Choose Category",
            "Phone",
            "Computer",
            "Tablet",
            "Home Electronics"});
            this.CBICategory.Location = new System.Drawing.Point(846, 60);
            this.CBICategory.Name = "CBICategory";
            this.CBICategory.Size = new System.Drawing.Size(242, 27);
            this.CBICategory.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(735, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "CATEGORY";
            // 
            // TBIManifact
            // 
            this.TBIManifact.Location = new System.Drawing.Point(487, 17);
            this.TBIManifact.Name = "TBIManifact";
            this.TBIManifact.Size = new System.Drawing.Size(242, 27);
            this.TBIManifact.TabIndex = 10;
            // 
            // TBIAmount
            // 
            this.TBIAmount.Location = new System.Drawing.Point(487, 60);
            this.TBIAmount.Name = "TBIAmount";
            this.TBIAmount.Size = new System.Drawing.Size(242, 27);
            this.TBIAmount.TabIndex = 9;
            // 
            // TBIBuyprice
            // 
            this.TBIBuyprice.Location = new System.Drawing.Point(846, 17);
            this.TBIBuyprice.Name = "TBIBuyprice";
            this.TBIBuyprice.Size = new System.Drawing.Size(242, 27);
            this.TBIBuyprice.TabIndex = 8;
            // 
            // TBIModel
            // 
            this.TBIModel.Location = new System.Drawing.Point(88, 60);
            this.TBIModel.Name = "TBIModel";
            this.TBIModel.Size = new System.Drawing.Size(266, 27);
            this.TBIModel.TabIndex = 7;
            // 
            // TBIName
            // 
            this.TBIName.Location = new System.Drawing.Point(88, 17);
            this.TBIName.Name = "TBIName";
            this.TBIName.Size = new System.Drawing.Size(266, 27);
            this.TBIName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(735, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "BUY PRICE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "AMOUNT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "MANIFACTURER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "MODEL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "NAME";
            // 
            // TPAppointments
            // 
            this.TPAppointments.BackColor = System.Drawing.Color.White;
            this.TPAppointments.ImageKey = "appointment.png";
            this.TPAppointments.Location = new System.Drawing.Point(4, 32);
            this.TPAppointments.Name = "TPAppointments";
            this.TPAppointments.Size = new System.Drawing.Size(1232, 621);
            this.TPAppointments.TabIndex = 2;
            this.TPAppointments.Text = "Appointments";
            // 
            // TPPayment
            // 
            this.TPPayment.BackColor = System.Drawing.Color.White;
            this.TPPayment.ImageKey = "credit-card.png";
            this.TPPayment.Location = new System.Drawing.Point(4, 32);
            this.TPPayment.Name = "TPPayment";
            this.TPPayment.Size = new System.Drawing.Size(1232, 621);
            this.TPPayment.TabIndex = 3;
            this.TPPayment.Text = "Payment";
            // 
            // TPSupplier
            // 
            this.TPSupplier.BackColor = System.Drawing.Color.White;
            this.TPSupplier.ImageKey = "manufacture.png";
            this.TPSupplier.Location = new System.Drawing.Point(4, 32);
            this.TPSupplier.Name = "TPSupplier";
            this.TPSupplier.Size = new System.Drawing.Size(1232, 621);
            this.TPSupplier.TabIndex = 4;
            this.TPSupplier.Text = "Suppliers";
            // 
            // TPTickets
            // 
            this.TPTickets.BackColor = System.Drawing.Color.White;
            this.TPTickets.ImageKey = "customer-support.png";
            this.TPTickets.Location = new System.Drawing.Point(4, 32);
            this.TPTickets.Name = "TPTickets";
            this.TPTickets.Size = new System.Drawing.Size(1232, 621);
            this.TPTickets.TabIndex = 5;
            this.TPTickets.Text = "Tickets";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "appointment.png");
            this.ımageList1.Images.SetKeyName(1, "boxes.png");
            this.ımageList1.Images.SetKeyName(2, "credit-card.png");
            this.ımageList1.Images.SetKeyName(3, "customer-support.png");
            this.ımageList1.Images.SetKeyName(4, "man.png");
            this.ımageList1.Images.SetKeyName(5, "manufacture.png");
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.tabControl1.ResumeLayout(false);
            this.TPCustomers.ResumeLayout(false);
            this.TPCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomer)).EndInit();
            this.TBInventory.ResumeLayout(false);
            this.TBInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TPCustomers;
        private System.Windows.Forms.TabPage TBInventory;
        private System.Windows.Forms.TabPage TPAppointments;
        private System.Windows.Forms.TabPage TPPayment;
        private System.Windows.Forms.TabPage TPSupplier;
        private System.Windows.Forms.TabPage TPTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBIManifact;
        private System.Windows.Forms.TextBox TBIAmount;
        private System.Windows.Forms.TextBox TBIBuyprice;
        private System.Windows.Forms.TextBox TBIModel;
        private System.Windows.Forms.TextBox TBIName;
        private System.Windows.Forms.Button BTIUpdate;
        private System.Windows.Forms.Button BTIRemove;
        private System.Windows.Forms.Button BTIAdd;
        private System.Windows.Forms.ComboBox CBICategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBIId;
        private System.Windows.Forms.DataGridView DGInventory;
        private System.Windows.Forms.Button BTClear;
        private System.Windows.Forms.Button BTCClear;
        private System.Windows.Forms.DataGridView DGCustomer;
        private System.Windows.Forms.TextBox TBCId;
        private System.Windows.Forms.Button BTCUpdate;
        private System.Windows.Forms.Button BTCRemove;
        private System.Windows.Forms.Button BTCAdd;
        private System.Windows.Forms.TextBox TBCPhone;
        private System.Windows.Forms.TextBox TBCMail;
        private System.Windows.Forms.TextBox TBCSurname;
        private System.Windows.Forms.TextBox TBCName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button BTCSearch;
        private System.Windows.Forms.Button button1;
    }
}