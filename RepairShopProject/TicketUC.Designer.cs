namespace RepairShopProject
{
    partial class TicketUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGCustomer = new System.Windows.Forms.DataGridView();
            this.DTEnd = new System.Windows.Forms.DateTimePicker();
            this.DTStart = new System.Windows.Forms.DateTimePicker();
            this.DGProduct = new System.Windows.Forms.DataGridView();
            this.DGTicket = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBCName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.TBCId = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TBTInfo = new System.Windows.Forms.TextBox();
            this.BTTAdd = new System.Windows.Forms.Button();
            this.BTTRemove = new System.Windows.Forms.Button();
            this.BTTUpdate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TBTId = new System.Windows.Forms.TextBox();
            this.BTTClear = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TBPAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGUsed = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsed)).BeginInit();
            this.SuspendLayout();
            // 
            // DGCustomer
            // 
            this.DGCustomer.AllowUserToAddRows = false;
            this.DGCustomer.AllowUserToDeleteRows = false;
            this.DGCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGCustomer.ColumnHeadersHeight = 24;
            this.DGCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGCustomer.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGCustomer.Location = new System.Drawing.Point(14, 160);
            this.DGCustomer.Name = "DGCustomer";
            this.DGCustomer.ReadOnly = true;
            this.DGCustomer.RowHeadersVisible = false;
            this.DGCustomer.RowHeadersWidth = 125;
            this.DGCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.DGCustomer.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGCustomer.RowTemplate.Height = 64;
            this.DGCustomer.Size = new System.Drawing.Size(206, 482);
            this.DGCustomer.TabIndex = 79;
            this.DGCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCustomer_CellClick);
            // 
            // DTEnd
            // 
            this.DTEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTEnd.Location = new System.Drawing.Point(435, 83);
            this.DTEnd.Name = "DTEnd";
            this.DTEnd.Size = new System.Drawing.Size(191, 20);
            this.DTEnd.TabIndex = 80;
            // 
            // DTStart
            // 
            this.DTStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTStart.Location = new System.Drawing.Point(226, 83);
            this.DTStart.Name = "DTStart";
            this.DTStart.Size = new System.Drawing.Size(191, 20);
            this.DTStart.TabIndex = 81;
            // 
            // DGProduct
            // 
            this.DGProduct.AllowUserToAddRows = false;
            this.DGProduct.AllowUserToDeleteRows = false;
            this.DGProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGProduct.ColumnHeadersHeight = 24;
            this.DGProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGProduct.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGProduct.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGProduct.Location = new System.Drawing.Point(842, 160);
            this.DGProduct.Name = "DGProduct";
            this.DGProduct.ReadOnly = true;
            this.DGProduct.RowHeadersVisible = false;
            this.DGProduct.RowHeadersWidth = 125;
            this.DGProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.DGProduct.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGProduct.RowTemplate.Height = 64;
            this.DGProduct.Size = new System.Drawing.Size(193, 256);
            this.DGProduct.TabIndex = 82;
            this.DGProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGProduct_CellClick);
            // 
            // DGTicket
            // 
            this.DGTicket.AllowUserToAddRows = false;
            this.DGTicket.AllowUserToDeleteRows = false;
            this.DGTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGTicket.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGTicket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGTicket.ColumnHeadersHeight = 24;
            this.DGTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGTicket.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGTicket.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGTicket.Location = new System.Drawing.Point(226, 160);
            this.DGTicket.Name = "DGTicket";
            this.DGTicket.ReadOnly = true;
            this.DGTicket.RowHeadersVisible = false;
            this.DGTicket.RowHeadersWidth = 125;
            this.DGTicket.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.DGTicket.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DGTicket.RowTemplate.Height = 64;
            this.DGTicket.Size = new System.Drawing.Size(609, 482);
            this.DGTicket.TabIndex = 83;
            this.DGTicket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGTicket_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel2.Location = new System.Drawing.Point(37, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 1);
            this.panel2.TabIndex = 87;
            // 
            // TBCName
            // 
            this.TBCName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBCName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBCName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBCName.Location = new System.Drawing.Point(37, 85);
            this.TBCName.Name = "TBCName";
            this.TBCName.Size = new System.Drawing.Size(149, 20);
            this.TBCName.TabIndex = 86;
            this.TBCName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBCName.TextChanged += new System.EventHandler(this.TBCName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Location = new System.Drawing.Point(37, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 1);
            this.panel1.TabIndex = 89;
            // 
            // CBStatus
            // 
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Items.AddRange(new object[] {
            "Current Status",
            "Active",
            "Deactive",
            "Pending"});
            this.CBStatus.Location = new System.Drawing.Point(644, 82);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(191, 21);
            this.CBStatus.TabIndex = 90;
            // 
            // TBCId
            // 
            this.TBCId.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBCId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBCId.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBCId.Location = new System.Drawing.Point(37, 45);
            this.TBCId.Name = "TBCId";
            this.TBCId.Size = new System.Drawing.Size(149, 20);
            this.TBCId.TabIndex = 88;
            this.TBCId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBCId.TextChanged += new System.EventHandler(this.TBCId_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel4.Location = new System.Drawing.Point(226, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 1);
            this.panel4.TabIndex = 98;
            // 
            // TBTInfo
            // 
            this.TBTInfo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBTInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBTInfo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBTInfo.Location = new System.Drawing.Point(226, 43);
            this.TBTInfo.Name = "TBTInfo";
            this.TBTInfo.Size = new System.Drawing.Size(400, 20);
            this.TBTInfo.TabIndex = 97;
            // 
            // BTTAdd
            // 
            this.BTTAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.BTTAdd.FlatAppearance.BorderSize = 0;
            this.BTTAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTTAdd.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTTAdd.ForeColor = System.Drawing.Color.White;
            this.BTTAdd.Location = new System.Drawing.Point(226, 109);
            this.BTTAdd.Name = "BTTAdd";
            this.BTTAdd.Size = new System.Drawing.Size(191, 45);
            this.BTTAdd.TabIndex = 99;
            this.BTTAdd.Text = "ADD";
            this.BTTAdd.UseVisualStyleBackColor = false;
            this.BTTAdd.Click += new System.EventHandler(this.BTTAdd_Click);
            // 
            // BTTRemove
            // 
            this.BTTRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.BTTRemove.FlatAppearance.BorderSize = 0;
            this.BTTRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTTRemove.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTTRemove.ForeColor = System.Drawing.Color.White;
            this.BTTRemove.Location = new System.Drawing.Point(435, 106);
            this.BTTRemove.Name = "BTTRemove";
            this.BTTRemove.Size = new System.Drawing.Size(191, 48);
            this.BTTRemove.TabIndex = 100;
            this.BTTRemove.Text = "REMOVE";
            this.BTTRemove.UseVisualStyleBackColor = false;
            this.BTTRemove.Click += new System.EventHandler(this.BTTRemove_Click);
            // 
            // BTTUpdate
            // 
            this.BTTUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.BTTUpdate.FlatAppearance.BorderSize = 0;
            this.BTTUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTTUpdate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTTUpdate.ForeColor = System.Drawing.Color.White;
            this.BTTUpdate.Location = new System.Drawing.Point(644, 106);
            this.BTTUpdate.Name = "BTTUpdate";
            this.BTTUpdate.Size = new System.Drawing.Size(191, 48);
            this.BTTUpdate.TabIndex = 101;
            this.BTTUpdate.Text = "UPDATE";
            this.BTTUpdate.UseVisualStyleBackColor = false;
            this.BTTUpdate.Click += new System.EventHandler(this.BTTUpdate_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel3.Location = new System.Drawing.Point(678, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(121, 1);
            this.panel3.TabIndex = 103;
            // 
            // TBTId
            // 
            this.TBTId.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBTId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBTId.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBTId.Location = new System.Drawing.Point(678, 43);
            this.TBTId.Name = "TBTId";
            this.TBTId.Size = new System.Drawing.Size(121, 20);
            this.TBTId.TabIndex = 102;
            // 
            // BTTClear
            // 
            this.BTTClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.BTTClear.FlatAppearance.BorderSize = 0;
            this.BTTClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTTClear.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTTClear.ForeColor = System.Drawing.Color.White;
            this.BTTClear.Location = new System.Drawing.Point(939, 3);
            this.BTTClear.Name = "BTTClear";
            this.BTTClear.Size = new System.Drawing.Size(108, 33);
            this.BTTClear.TabIndex = 104;
            this.BTTClear.Text = "Clear";
            this.BTTClear.UseVisualStyleBackColor = false;
            this.BTTClear.Click += new System.EventHandler(this.BTTClear_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel5.Location = new System.Drawing.Point(888, 116);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(108, 1);
            this.panel5.TabIndex = 107;
            // 
            // TBPAdd
            // 
            this.TBPAdd.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBPAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBPAdd.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBPAdd.Location = new System.Drawing.Point(888, 95);
            this.TBPAdd.Name = "TBPAdd";
            this.TBPAdd.Size = new System.Drawing.Size(108, 20);
            this.TBPAdd.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(893, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 110;
            this.label2.Text = "Used Parts";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGUsed
            // 
            this.DGUsed.AllowUserToAddRows = false;
            this.DGUsed.AllowUserToDeleteRows = false;
            this.DGUsed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGUsed.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGUsed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DGUsed.ColumnHeadersHeight = 24;
            this.DGUsed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGUsed.DefaultCellStyle = dataGridViewCellStyle11;
            this.DGUsed.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGUsed.Location = new System.Drawing.Point(842, 441);
            this.DGUsed.Name = "DGUsed";
            this.DGUsed.ReadOnly = true;
            this.DGUsed.RowHeadersVisible = false;
            this.DGUsed.RowHeadersWidth = 125;
            this.DGUsed.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.DGUsed.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DGUsed.RowTemplate.Height = 64;
            this.DGUsed.Size = new System.Drawing.Size(193, 201);
            this.DGUsed.TabIndex = 113;
            this.DGUsed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGUsed_CellClick);
            // 
            // TicketUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.DGUsed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.TBPAdd);
            this.Controls.Add(this.BTTClear);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TBTId);
            this.Controls.Add(this.BTTUpdate);
            this.Controls.Add(this.BTTRemove);
            this.Controls.Add(this.BTTAdd);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.TBTInfo);
            this.Controls.Add(this.CBStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TBCId);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TBCName);
            this.Controls.Add(this.DGTicket);
            this.Controls.Add(this.DGProduct);
            this.Controls.Add(this.DTStart);
            this.Controls.Add(this.DTEnd);
            this.Controls.Add(this.DGCustomer);
            this.Name = "TicketUC";
            this.Size = new System.Drawing.Size(1050, 655);
            this.Load += new System.EventHandler(this.TicketUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGCustomer;
        private System.Windows.Forms.DateTimePicker DTEnd;
        private System.Windows.Forms.DateTimePicker DTStart;
        private System.Windows.Forms.DataGridView DGProduct;
        private System.Windows.Forms.DataGridView DGTicket;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TBCName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.TextBox TBCId;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TBTInfo;
        private System.Windows.Forms.Button BTTAdd;
        private System.Windows.Forms.Button BTTRemove;
        private System.Windows.Forms.Button BTTUpdate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TBTId;
        private System.Windows.Forms.Button BTTClear;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TBPAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGUsed;
    }
}
