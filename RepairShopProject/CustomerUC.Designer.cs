namespace RepairShopProject
{
    partial class CustomerUC
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // BTCSearch
            // 
            this.BTCSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.BTCSearch.FlatAppearance.BorderSize = 0;
            this.BTCSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTCSearch.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTCSearch.ForeColor = System.Drawing.Color.White;
            this.BTCSearch.Location = new System.Drawing.Point(754, 551);
            this.BTCSearch.Name = "BTCSearch";
            this.BTCSearch.Size = new System.Drawing.Size(267, 91);
            this.BTCSearch.TabIndex = 57;
            this.BTCSearch.Text = "SEARCH";
            this.BTCSearch.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(763, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 19);
            this.label8.TabIndex = 56;
            this.label8.Text = "ID";
            // 
            // BTCClear
            // 
            this.BTCClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.BTCClear.FlatAppearance.BorderSize = 0;
            this.BTCClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTCClear.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTCClear.ForeColor = System.Drawing.Color.White;
            this.BTCClear.Location = new System.Drawing.Point(806, 57);
            this.BTCClear.Name = "BTCClear";
            this.BTCClear.Size = new System.Drawing.Size(178, 40);
            this.BTCClear.TabIndex = 55;
            this.BTCClear.Text = "Clear";
            this.BTCClear.UseVisualStyleBackColor = false;
            // 
            // DGCustomer
            // 
            this.DGCustomer.AllowUserToAddRows = false;
            this.DGCustomer.AllowUserToDeleteRows = false;
            this.DGCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGCustomer.ColumnHeadersHeight = 24;
            this.DGCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGCustomer.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGCustomer.Location = new System.Drawing.Point(16, 118);
            this.DGCustomer.Name = "DGCustomer";
            this.DGCustomer.ReadOnly = true;
            this.DGCustomer.RowHeadersVisible = false;
            this.DGCustomer.RowHeadersWidth = 125;
            this.DGCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.DGCustomer.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGCustomer.RowTemplate.Height = 64;
            this.DGCustomer.Size = new System.Drawing.Size(704, 524);
            this.DGCustomer.TabIndex = 54;
            this.DGCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCustomer_CellClick);
            // 
            // TBCId
            // 
            this.TBCId.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBCId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBCId.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBCId.Location = new System.Drawing.Point(806, 23);
            this.TBCId.Name = "TBCId";
            this.TBCId.Size = new System.Drawing.Size(178, 20);
            this.TBCId.TabIndex = 53;
            // 
            // BTCUpdate
            // 
            this.BTCUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.BTCUpdate.FlatAppearance.BorderSize = 0;
            this.BTCUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTCUpdate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTCUpdate.ForeColor = System.Drawing.Color.White;
            this.BTCUpdate.Location = new System.Drawing.Point(754, 312);
            this.BTCUpdate.Name = "BTCUpdate";
            this.BTCUpdate.Size = new System.Drawing.Size(267, 91);
            this.BTCUpdate.TabIndex = 52;
            this.BTCUpdate.Text = "UPDATE";
            this.BTCUpdate.UseVisualStyleBackColor = false;
            // 
            // BTCRemove
            // 
            this.BTCRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.BTCRemove.FlatAppearance.BorderSize = 0;
            this.BTCRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTCRemove.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTCRemove.ForeColor = System.Drawing.Color.White;
            this.BTCRemove.Location = new System.Drawing.Point(754, 215);
            this.BTCRemove.Name = "BTCRemove";
            this.BTCRemove.Size = new System.Drawing.Size(267, 91);
            this.BTCRemove.TabIndex = 51;
            this.BTCRemove.Text = "REMOVE";
            this.BTCRemove.UseVisualStyleBackColor = false;
            // 
            // BTCAdd
            // 
            this.BTCAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.BTCAdd.FlatAppearance.BorderSize = 0;
            this.BTCAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTCAdd.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTCAdd.ForeColor = System.Drawing.Color.White;
            this.BTCAdd.Location = new System.Drawing.Point(754, 118);
            this.BTCAdd.Name = "BTCAdd";
            this.BTCAdd.Size = new System.Drawing.Size(267, 91);
            this.BTCAdd.TabIndex = 50;
            this.BTCAdd.Text = "ADD";
            this.BTCAdd.UseVisualStyleBackColor = false;
            // 
            // TBCPhone
            // 
            this.TBCPhone.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBCPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBCPhone.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBCPhone.Location = new System.Drawing.Point(478, 23);
            this.TBCPhone.Name = "TBCPhone";
            this.TBCPhone.Size = new System.Drawing.Size(242, 20);
            this.TBCPhone.TabIndex = 49;
            // 
            // TBCMail
            // 
            this.TBCMail.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBCMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBCMail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBCMail.Location = new System.Drawing.Point(478, 65);
            this.TBCMail.Name = "TBCMail";
            this.TBCMail.Size = new System.Drawing.Size(242, 20);
            this.TBCMail.TabIndex = 48;
            // 
            // TBCSurname
            // 
            this.TBCSurname.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBCSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBCSurname.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBCSurname.Location = new System.Drawing.Point(105, 64);
            this.TBCSurname.Name = "TBCSurname";
            this.TBCSurname.Size = new System.Drawing.Size(266, 20);
            this.TBCSurname.TabIndex = 47;
            // 
            // TBCName
            // 
            this.TBCName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBCName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBCName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBCName.Location = new System.Drawing.Point(105, 23);
            this.TBCName.Name = "TBCName";
            this.TBCName.Size = new System.Drawing.Size(266, 20);
            this.TBCName.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(395, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 45;
            this.label10.Text = "E-MAIL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(395, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 19);
            this.label11.TabIndex = 44;
            this.label11.Text = "PHONE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(15, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 19);
            this.label12.TabIndex = 43;
            this.label12.Text = "SURNAME";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(16, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 19);
            this.label13.TabIndex = 42;
            this.label13.Text = "NAME";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(754, 515);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 20);
            this.textBox1.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(834, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 59;
            this.label1.Text = "Name / Phone";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Location = new System.Drawing.Point(105, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 1);
            this.panel1.TabIndex = 60;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel2.Location = new System.Drawing.Point(105, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 1);
            this.panel2.TabIndex = 61;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel3.Location = new System.Drawing.Point(478, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 1);
            this.panel3.TabIndex = 62;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel4.Location = new System.Drawing.Point(478, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(242, 1);
            this.panel4.TabIndex = 63;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel5.Location = new System.Drawing.Point(806, 44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 1);
            this.panel5.TabIndex = 64;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel6.Location = new System.Drawing.Point(755, 534);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(266, 1);
            this.panel6.TabIndex = 65;
            // 
            // CustomerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BTCSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BTCClear);
            this.Controls.Add(this.DGCustomer);
            this.Controls.Add(this.TBCId);
            this.Controls.Add(this.BTCUpdate);
            this.Controls.Add(this.BTCRemove);
            this.Controls.Add(this.BTCAdd);
            this.Controls.Add(this.TBCPhone);
            this.Controls.Add(this.TBCMail);
            this.Controls.Add(this.TBCSurname);
            this.Controls.Add(this.TBCName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Name = "CustomerUC";
            this.Size = new System.Drawing.Size(1050, 655);
            this.Load += new System.EventHandler(this.CustomerUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTCSearch;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}
