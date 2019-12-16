namespace RepairShopProject
{
    partial class ProfitUC
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
            this.DGAppo = new System.Windows.Forms.DataGridView();
            this.DTApp = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBSalePr = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBBuyPr = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TBProfit = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TBSale = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BTAClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGAppo)).BeginInit();
            this.SuspendLayout();
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
            this.DGAppo.Location = new System.Drawing.Point(12, 93);
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
            this.DGAppo.Size = new System.Drawing.Size(824, 550);
            this.DGAppo.TabIndex = 140;
            this.DGAppo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGAppo_CellClick);
            // 
            // DTApp
            // 
            this.DTApp.Location = new System.Drawing.Point(492, 57);
            this.DTApp.Name = "DTApp";
            this.DTApp.Size = new System.Drawing.Size(210, 20);
            this.DTApp.TabIndex = 141;
            this.DTApp.ValueChanged += new System.EventHandler(this.DTApp_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker1.TabIndex = 142;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Location = new System.Drawing.Point(853, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 1);
            this.panel1.TabIndex = 144;
            // 
            // TBSalePr
            // 
            this.TBSalePr.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBSalePr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBSalePr.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBSalePr.Location = new System.Drawing.Point(853, 332);
            this.TBSalePr.Name = "TBSalePr";
            this.TBSalePr.Size = new System.Drawing.Size(188, 20);
            this.TBSalePr.TabIndex = 143;
            this.TBSalePr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel2.Location = new System.Drawing.Point(853, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 1);
            this.panel2.TabIndex = 146;
            // 
            // TBBuyPr
            // 
            this.TBBuyPr.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBBuyPr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBBuyPr.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBBuyPr.Location = new System.Drawing.Point(853, 449);
            this.TBBuyPr.Name = "TBBuyPr";
            this.TBBuyPr.Size = new System.Drawing.Size(188, 20);
            this.TBBuyPr.TabIndex = 145;
            this.TBBuyPr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel3.Location = new System.Drawing.Point(853, 585);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 1);
            this.panel3.TabIndex = 148;
            // 
            // TBProfit
            // 
            this.TBProfit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBProfit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBProfit.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBProfit.Location = new System.Drawing.Point(853, 564);
            this.TBProfit.Name = "TBProfit";
            this.TBProfit.Size = new System.Drawing.Size(188, 20);
            this.TBProfit.TabIndex = 147;
            this.TBProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel4.Location = new System.Drawing.Point(853, 233);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 1);
            this.panel4.TabIndex = 150;
            // 
            // TBSale
            // 
            this.TBSale.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBSale.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBSale.Location = new System.Drawing.Point(853, 212);
            this.TBSale.Name = "TBSale";
            this.TBSale.Size = new System.Drawing.Size(188, 20);
            this.TBSale.TabIndex = 149;
            this.TBSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(182, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 151;
            this.label3.Text = "FIRST DATE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(546, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 152;
            this.label1.Text = "SECOND DATE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(873, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 19);
            this.label2.TabIndex = 153;
            this.label2.Text = "NUMBER OF SALES";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(873, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 19);
            this.label4.TabIndex = 154;
            this.label4.Text = "TOTAL SALE PRICE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(873, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 19);
            this.label5.TabIndex = 155;
            this.label5.Text = "TOTAL BUY PRICE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(886, 542);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 19);
            this.label6.TabIndex = 156;
            this.label6.Text = "TOTAL PROFIT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTAClear
            // 
            this.BTAClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.BTAClear.FlatAppearance.BorderSize = 0;
            this.BTAClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTAClear.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTAClear.ForeColor = System.Drawing.Color.White;
            this.BTAClear.Location = new System.Drawing.Point(915, 12);
            this.BTAClear.Name = "BTAClear";
            this.BTAClear.Size = new System.Drawing.Size(126, 32);
            this.BTAClear.TabIndex = 157;
            this.BTAClear.Text = "Clear";
            this.BTAClear.UseVisualStyleBackColor = false;
            this.BTAClear.Click += new System.EventHandler(this.BTAClear_Click);
            // 
            // ProfitUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.BTAClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.TBSale);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TBProfit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TBBuyPr);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TBSalePr);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DTApp);
            this.Controls.Add(this.DGAppo);
            this.Name = "ProfitUC";
            this.Size = new System.Drawing.Size(1050, 655);
            this.Load += new System.EventHandler(this.ProfitUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGAppo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGAppo;
        private System.Windows.Forms.DateTimePicker DTApp;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBSalePr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TBBuyPr;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TBProfit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TBSale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTAClear;
    }
}
