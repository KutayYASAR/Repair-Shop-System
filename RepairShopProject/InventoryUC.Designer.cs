namespace RepairShopProject
{
    partial class InventoryUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BTISearch = new System.Windows.Forms.Button();
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.TBISearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // BTISearch
            // 
            this.BTISearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.BTISearch.FlatAppearance.BorderSize = 0;
            this.BTISearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTISearch.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTISearch.ForeColor = System.Drawing.Color.White;
            this.BTISearch.Location = new System.Drawing.Point(771, 546);
            this.BTISearch.Name = "BTISearch";
            this.BTISearch.Size = new System.Drawing.Size(267, 91);
            this.BTISearch.TabIndex = 42;
            this.BTISearch.Text = "SEARCH";
            this.BTISearch.UseVisualStyleBackColor = false;
            this.BTISearch.Click += new System.EventHandler(this.BTISearch_Click);
            // 
            // BTClear
            // 
            this.BTClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.BTClear.FlatAppearance.BorderSize = 0;
            this.BTClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTClear.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTClear.ForeColor = System.Drawing.Color.White;
            this.BTClear.Location = new System.Drawing.Point(916, 101);
            this.BTClear.Name = "BTClear";
            this.BTClear.Size = new System.Drawing.Size(125, 28);
            this.BTClear.TabIndex = 41;
            this.BTClear.Text = "Clear";
            this.BTClear.UseVisualStyleBackColor = false;
            this.BTClear.Click += new System.EventHandler(this.BTClear_Click);
            // 
            // DGInventory
            // 
            this.DGInventory.AllowUserToAddRows = false;
            this.DGInventory.AllowUserToDeleteRows = false;
            this.DGInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGInventory.ColumnHeadersHeight = 24;
            this.DGInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGInventory.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGInventory.Location = new System.Drawing.Point(23, 113);
            this.DGInventory.Name = "DGInventory";
            this.DGInventory.ReadOnly = true;
            this.DGInventory.RowHeadersVisible = false;
            this.DGInventory.RowHeadersWidth = 125;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.DGInventory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGInventory.RowTemplate.Height = 64;
            this.DGInventory.Size = new System.Drawing.Size(704, 524);
            this.DGInventory.TabIndex = 40;
            this.DGInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGInventory_CellClick);
            // 
            // TBIId
            // 
            this.TBIId.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBIId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBIId.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBIId.Location = new System.Drawing.Point(863, 103);
            this.TBIId.Name = "TBIId";
            this.TBIId.Size = new System.Drawing.Size(47, 20);
            this.TBIId.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(832, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 19);
            this.label7.TabIndex = 38;
            this.label7.Text = "ID";
            // 
            // BTIUpdate
            // 
            this.BTIUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.BTIUpdate.FlatAppearance.BorderSize = 0;
            this.BTIUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTIUpdate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTIUpdate.ForeColor = System.Drawing.Color.White;
            this.BTIUpdate.Location = new System.Drawing.Point(771, 344);
            this.BTIUpdate.Name = "BTIUpdate";
            this.BTIUpdate.Size = new System.Drawing.Size(267, 91);
            this.BTIUpdate.TabIndex = 37;
            this.BTIUpdate.Text = "UPDATE";
            this.BTIUpdate.UseVisualStyleBackColor = false;
            this.BTIUpdate.Click += new System.EventHandler(this.BTIUpdate_Click);
            // 
            // BTIRemove
            // 
            this.BTIRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.BTIRemove.FlatAppearance.BorderSize = 0;
            this.BTIRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTIRemove.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTIRemove.ForeColor = System.Drawing.Color.White;
            this.BTIRemove.Location = new System.Drawing.Point(771, 244);
            this.BTIRemove.Name = "BTIRemove";
            this.BTIRemove.Size = new System.Drawing.Size(267, 91);
            this.BTIRemove.TabIndex = 36;
            this.BTIRemove.Text = "REMOVE";
            this.BTIRemove.UseVisualStyleBackColor = false;
            this.BTIRemove.Click += new System.EventHandler(this.BTIRemove_Click);
            // 
            // BTIAdd
            // 
            this.BTIAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.BTIAdd.FlatAppearance.BorderSize = 0;
            this.BTIAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTIAdd.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTIAdd.ForeColor = System.Drawing.Color.White;
            this.BTIAdd.Location = new System.Drawing.Point(771, 144);
            this.BTIAdd.Name = "BTIAdd";
            this.BTIAdd.Size = new System.Drawing.Size(267, 91);
            this.BTIAdd.TabIndex = 35;
            this.BTIAdd.Text = "ADD";
            this.BTIAdd.UseVisualStyleBackColor = false;
            this.BTIAdd.Click += new System.EventHandler(this.BTIAdd_Click);
            // 
            // CBICategory
            // 
            this.CBICategory.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CBICategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.CBICategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBICategory.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBICategory.FormattingEnabled = true;
            this.CBICategory.Items.AddRange(new object[] {
            "Choose Category",
            "Phone",
            "Computer",
            "Tablet",
            "Home Electronics"});
            this.CBICategory.Location = new System.Drawing.Point(863, 56);
            this.CBICategory.Name = "CBICategory";
            this.CBICategory.Size = new System.Drawing.Size(178, 26);
            this.CBICategory.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(767, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "CATEGORY";
            // 
            // TBIManifact
            // 
            this.TBIManifact.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBIManifact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBIManifact.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBIManifact.Location = new System.Drawing.Point(498, 18);
            this.TBIManifact.Name = "TBIManifact";
            this.TBIManifact.Size = new System.Drawing.Size(242, 20);
            this.TBIManifact.TabIndex = 32;
            // 
            // TBIAmount
            // 
            this.TBIAmount.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBIAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBIAmount.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBIAmount.Location = new System.Drawing.Point(498, 59);
            this.TBIAmount.Name = "TBIAmount";
            this.TBIAmount.Size = new System.Drawing.Size(242, 20);
            this.TBIAmount.TabIndex = 31;
            // 
            // TBIBuyprice
            // 
            this.TBIBuyprice.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBIBuyprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBIBuyprice.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBIBuyprice.Location = new System.Drawing.Point(863, 18);
            this.TBIBuyprice.Name = "TBIBuyprice";
            this.TBIBuyprice.Size = new System.Drawing.Size(178, 20);
            this.TBIBuyprice.TabIndex = 30;
            // 
            // TBIModel
            // 
            this.TBIModel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBIModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBIModel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBIModel.Location = new System.Drawing.Point(92, 59);
            this.TBIModel.Name = "TBIModel";
            this.TBIModel.Size = new System.Drawing.Size(266, 20);
            this.TBIModel.TabIndex = 29;
            // 
            // TBIName
            // 
            this.TBIName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBIName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBIName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBIName.Location = new System.Drawing.Point(92, 18);
            this.TBIName.Name = "TBIName";
            this.TBIName.Size = new System.Drawing.Size(266, 20);
            this.TBIName.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(769, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "BUY PRICE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(364, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "AMOUNT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(364, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "MANIFACTURER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "MODEL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "NAME";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel6.Location = new System.Drawing.Point(772, 539);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(266, 1);
            this.panel6.TabIndex = 92;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(858, 498);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 91;
            this.label8.Text = "NAME / ID";
            // 
            // TBISearch
            // 
            this.TBISearch.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBISearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBISearch.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBISearch.Location = new System.Drawing.Point(771, 520);
            this.TBISearch.Name = "TBISearch";
            this.TBISearch.Size = new System.Drawing.Size(267, 20);
            this.TBISearch.TabIndex = 90;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Location = new System.Drawing.Point(498, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 1);
            this.panel1.TabIndex = 93;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel2.Location = new System.Drawing.Point(498, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 1);
            this.panel2.TabIndex = 94;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel3.Location = new System.Drawing.Point(92, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 1);
            this.panel3.TabIndex = 95;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel4.Location = new System.Drawing.Point(92, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(266, 1);
            this.panel4.TabIndex = 96;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel5.Location = new System.Drawing.Point(863, 39);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 1);
            this.panel5.TabIndex = 97;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel7.Location = new System.Drawing.Point(863, 122);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(47, 1);
            this.panel7.TabIndex = 98;
            // 
            // InventoryUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TBISearch);
            this.Controls.Add(this.BTISearch);
            this.Controls.Add(this.BTClear);
            this.Controls.Add(this.DGInventory);
            this.Controls.Add(this.TBIId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BTIUpdate);
            this.Controls.Add(this.BTIRemove);
            this.Controls.Add(this.BTIAdd);
            this.Controls.Add(this.CBICategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBIManifact);
            this.Controls.Add(this.TBIAmount);
            this.Controls.Add(this.TBIBuyprice);
            this.Controls.Add(this.TBIModel);
            this.Controls.Add(this.TBIName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InventoryUC";
            this.Size = new System.Drawing.Size(1050, 655);
            this.Load += new System.EventHandler(this.InventoryUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTISearch;
        private System.Windows.Forms.Button BTClear;
        private System.Windows.Forms.DataGridView DGInventory;
        private System.Windows.Forms.TextBox TBIId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTIUpdate;
        private System.Windows.Forms.Button BTIRemove;
        private System.Windows.Forms.Button BTIAdd;
        private System.Windows.Forms.ComboBox CBICategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBIManifact;
        private System.Windows.Forms.TextBox TBIAmount;
        private System.Windows.Forms.TextBox TBIBuyprice;
        private System.Windows.Forms.TextBox TBIModel;
        private System.Windows.Forms.TextBox TBIName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBISearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
    }
}
