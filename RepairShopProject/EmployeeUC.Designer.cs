namespace RepairShopProject
{
    partial class EmployeeUC
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.TBEId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TBEPass = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TBESurname = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TBEPhone = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBEMail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBEName = new System.Windows.Forms.TextBox();
            this.DGAppo = new System.Windows.Forms.DataGridView();
            this.BTAClear = new System.Windows.Forms.Button();
            this.BTAUpdate = new System.Windows.Forms.Button();
            this.BTARemove = new System.Windows.Forms.Button();
            this.BTAAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGAppo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel7.Location = new System.Drawing.Point(675, 163);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(95, 1);
            this.panel7.TabIndex = 158;
            // 
            // TBEId
            // 
            this.TBEId.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBEId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBEId.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBEId.Location = new System.Drawing.Point(675, 142);
            this.TBEId.Name = "TBEId";
            this.TBEId.Size = new System.Drawing.Size(95, 20);
            this.TBEId.TabIndex = 157;
            this.TBEId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBEId.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(713, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 19);
            this.label7.TabIndex = 156;
            this.label7.Text = "ID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(383, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 155;
            this.label5.Text = "PASSWORD";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(78, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 154;
            this.label4.Text = "SURNAME";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(694, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 153;
            this.label2.Text = "PHONE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(401, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 152;
            this.label1.Text = "EMAIL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel5.Location = new System.Drawing.Point(322, 161);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(213, 1);
            this.panel5.TabIndex = 151;
            // 
            // TBEPass
            // 
            this.TBEPass.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBEPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBEPass.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBEPass.Location = new System.Drawing.Point(322, 140);
            this.TBEPass.Name = "TBEPass";
            this.TBEPass.Size = new System.Drawing.Size(213, 20);
            this.TBEPass.TabIndex = 150;
            this.TBEPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel4.Location = new System.Drawing.Point(17, 161);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 1);
            this.panel4.TabIndex = 149;
            // 
            // TBESurname
            // 
            this.TBESurname.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBESurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBESurname.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBESurname.Location = new System.Drawing.Point(17, 140);
            this.TBESurname.Name = "TBESurname";
            this.TBESurname.Size = new System.Drawing.Size(213, 20);
            this.TBESurname.TabIndex = 148;
            this.TBESurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel3.Location = new System.Drawing.Point(619, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 1);
            this.panel3.TabIndex = 147;
            // 
            // TBEPhone
            // 
            this.TBEPhone.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBEPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBEPhone.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBEPhone.Location = new System.Drawing.Point(619, 80);
            this.TBEPhone.Name = "TBEPhone";
            this.TBEPhone.Size = new System.Drawing.Size(213, 20);
            this.TBEPhone.TabIndex = 146;
            this.TBEPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel2.Location = new System.Drawing.Point(322, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 1);
            this.panel2.TabIndex = 145;
            // 
            // TBEMail
            // 
            this.TBEMail.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBEMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBEMail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBEMail.Location = new System.Drawing.Point(322, 80);
            this.TBEMail.Name = "TBEMail";
            this.TBEMail.Size = new System.Drawing.Size(213, 20);
            this.TBEMail.TabIndex = 144;
            this.TBEMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(847, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 111);
            this.button1.TabIndex = 143;
            this.button1.Text = "PROMOTE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(93, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 142;
            this.label3.Text = "NAME";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Location = new System.Drawing.Point(17, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 1);
            this.panel1.TabIndex = 141;
            // 
            // TBEName
            // 
            this.TBEName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBEName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBEName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBEName.Location = new System.Drawing.Point(17, 80);
            this.TBEName.Name = "TBEName";
            this.TBEName.Size = new System.Drawing.Size(213, 20);
            this.TBEName.TabIndex = 140;
            this.TBEName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBEName.TextChanged += new System.EventHandler(this.TBADept_TextChanged);
            // 
            // DGAppo
            // 
            this.DGAppo.AllowUserToAddRows = false;
            this.DGAppo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGAppo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGAppo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGAppo.ColumnHeadersHeight = 24;
            this.DGAppo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGAppo.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGAppo.Location = new System.Drawing.Point(12, 180);
            this.DGAppo.Name = "DGAppo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGAppo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGAppo.RowHeadersVisible = false;
            this.DGAppo.RowHeadersWidth = 125;
            this.DGAppo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.DGAppo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGAppo.RowTemplate.Height = 64;
            this.DGAppo.Size = new System.Drawing.Size(824, 462);
            this.DGAppo.TabIndex = 139;
            this.DGAppo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGAppo_CellClick);
            // 
            // BTAClear
            // 
            this.BTAClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.BTAClear.FlatAppearance.BorderSize = 0;
            this.BTAClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTAClear.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTAClear.ForeColor = System.Drawing.Color.White;
            this.BTAClear.Location = new System.Drawing.Point(847, 12);
            this.BTAClear.Name = "BTAClear";
            this.BTAClear.Size = new System.Drawing.Size(191, 40);
            this.BTAClear.TabIndex = 138;
            this.BTAClear.Text = "Clear";
            this.BTAClear.UseVisualStyleBackColor = false;
            this.BTAClear.Click += new System.EventHandler(this.BTAClear_Click);
            // 
            // BTAUpdate
            // 
            this.BTAUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.BTAUpdate.FlatAppearance.BorderSize = 0;
            this.BTAUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTAUpdate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTAUpdate.ForeColor = System.Drawing.Color.White;
            this.BTAUpdate.Location = new System.Drawing.Point(847, 414);
            this.BTAUpdate.Name = "BTAUpdate";
            this.BTAUpdate.Size = new System.Drawing.Size(191, 111);
            this.BTAUpdate.TabIndex = 137;
            this.BTAUpdate.Text = "UPDATE";
            this.BTAUpdate.UseVisualStyleBackColor = false;
            this.BTAUpdate.Click += new System.EventHandler(this.BTAUpdate_Click);
            // 
            // BTARemove
            // 
            this.BTARemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.BTARemove.FlatAppearance.BorderSize = 0;
            this.BTARemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTARemove.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTARemove.ForeColor = System.Drawing.Color.White;
            this.BTARemove.Location = new System.Drawing.Point(847, 297);
            this.BTARemove.Name = "BTARemove";
            this.BTARemove.Size = new System.Drawing.Size(191, 111);
            this.BTARemove.TabIndex = 136;
            this.BTARemove.Text = "REMOVE";
            this.BTARemove.UseVisualStyleBackColor = false;
            this.BTARemove.Click += new System.EventHandler(this.BTARemove_Click);
            // 
            // BTAAdd
            // 
            this.BTAAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.BTAAdd.FlatAppearance.BorderSize = 0;
            this.BTAAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTAAdd.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTAAdd.ForeColor = System.Drawing.Color.White;
            this.BTAAdd.Location = new System.Drawing.Point(847, 180);
            this.BTAAdd.Name = "BTAAdd";
            this.BTAAdd.Size = new System.Drawing.Size(191, 111);
            this.BTAAdd.TabIndex = 135;
            this.BTAAdd.Text = "ADD";
            this.BTAAdd.UseVisualStyleBackColor = false;
            this.BTAAdd.Click += new System.EventHandler(this.BTAAdd_Click);
            // 
            // EmployeeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.TBEId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.TBEPass);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.TBESurname);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TBEPhone);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TBEMail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TBEName);
            this.Controls.Add(this.DGAppo);
            this.Controls.Add(this.BTAClear);
            this.Controls.Add(this.BTAUpdate);
            this.Controls.Add(this.BTARemove);
            this.Controls.Add(this.BTAAdd);
            this.Name = "EmployeeUC";
            this.Size = new System.Drawing.Size(1050, 655);
            this.Load += new System.EventHandler(this.EmployeeUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGAppo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox TBEId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TBEPass;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TBESurname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TBEPhone;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TBEMail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBEName;
        private System.Windows.Forms.DataGridView DGAppo;
        private System.Windows.Forms.Button BTAClear;
        private System.Windows.Forms.Button BTAUpdate;
        private System.Windows.Forms.Button BTARemove;
        private System.Windows.Forms.Button BTAAdd;
    }
}
