namespace RepairShopProject
{
    partial class clockinout
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
            this.BTIn = new System.Windows.Forms.Button();
            this.BTOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTIn
            // 
            this.BTIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BTIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTIn.FlatAppearance.BorderSize = 0;
            this.BTIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTIn.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTIn.ForeColor = System.Drawing.Color.White;
            this.BTIn.Image = global::RepairShopProject.Properties.Resources.clock__2_;
            this.BTIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTIn.Location = new System.Drawing.Point(17, 60);
            this.BTIn.Name = "BTIn";
            this.BTIn.Size = new System.Drawing.Size(125, 40);
            this.BTIn.TabIndex = 0;
            this.BTIn.Text = "  CLOCK IN";
            this.BTIn.UseVisualStyleBackColor = false;
            this.BTIn.Click += new System.EventHandler(this.BTIn_Click);
            // 
            // BTOut
            // 
            this.BTOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BTOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTOut.FlatAppearance.BorderSize = 0;
            this.BTOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTOut.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTOut.ForeColor = System.Drawing.Color.White;
            this.BTOut.Image = global::RepairShopProject.Properties.Resources.clock__2_;
            this.BTOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTOut.Location = new System.Drawing.Point(18, 133);
            this.BTOut.Name = "BTOut";
            this.BTOut.Size = new System.Drawing.Size(125, 40);
            this.BTOut.TabIndex = 1;
            this.BTOut.Text = "     CLOCK OUT";
            this.BTOut.UseVisualStyleBackColor = false;
            this.BTOut.Click += new System.EventHandler(this.BTOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // clockinout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(164, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTOut);
            this.Controls.Add(this.BTIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "clockinout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clockinout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTIn;
        private System.Windows.Forms.Button BTOut;
        private System.Windows.Forms.Label label1;
    }
}