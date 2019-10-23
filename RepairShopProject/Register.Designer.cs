namespace RepairShopProject
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBSurname = new System.Windows.Forms.TextBox();
            this.TBPhone = new System.Windows.Forms.TextBox();
            this.TBMail = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.BTRegister = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TBConfirm = new System.Windows.Forms.TextBox();
            this.BTBack = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(184, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(184, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(184, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(184, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(184, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone Number";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(296, 88);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(167, 20);
            this.TBName.TabIndex = 5;
            // 
            // TBSurname
            // 
            this.TBSurname.Location = new System.Drawing.Point(296, 126);
            this.TBSurname.Name = "TBSurname";
            this.TBSurname.Size = new System.Drawing.Size(167, 20);
            this.TBSurname.TabIndex = 6;
            // 
            // TBPhone
            // 
            this.TBPhone.Location = new System.Drawing.Point(296, 166);
            this.TBPhone.Name = "TBPhone";
            this.TBPhone.Size = new System.Drawing.Size(167, 20);
            this.TBPhone.TabIndex = 7;
            // 
            // TBMail
            // 
            this.TBMail.Location = new System.Drawing.Point(296, 206);
            this.TBMail.Name = "TBMail";
            this.TBMail.Size = new System.Drawing.Size(167, 20);
            this.TBMail.TabIndex = 8;
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(296, 244);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(167, 20);
            this.TBPassword.TabIndex = 9;
            this.TBPassword.UseSystemPasswordChar = true;
            // 
            // BTRegister
            // 
            this.BTRegister.Location = new System.Drawing.Point(296, 286);
            this.BTRegister.Name = "BTRegister";
            this.BTRegister.Size = new System.Drawing.Size(167, 39);
            this.BTRegister.TabIndex = 10;
            this.BTRegister.Text = "REGISTER";
            this.BTRegister.UseVisualStyleBackColor = true;
            this.BTRegister.Click += new System.EventHandler(this.BTRegister_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(487, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Confimation Code";
            // 
            // TBConfirm
            // 
            this.TBConfirm.Location = new System.Drawing.Point(490, 305);
            this.TBConfirm.Name = "TBConfirm";
            this.TBConfirm.Size = new System.Drawing.Size(125, 20);
            this.TBConfirm.TabIndex = 12;
            this.TBConfirm.UseSystemPasswordChar = true;
            // 
            // BTBack
            // 
            this.BTBack.ImageKey = "left-arrow.png";
            this.BTBack.ImageList = this.ımageList1;
            this.BTBack.Location = new System.Drawing.Point(729, 24);
            this.BTBack.Name = "BTBack";
            this.BTBack.Size = new System.Drawing.Size(45, 27);
            this.BTBack.TabIndex = 13;
            this.BTBack.UseVisualStyleBackColor = true;
            this.BTBack.Click += new System.EventHandler(this.BTBack_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMsg.Location = new System.Drawing.Point(293, 344);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 18);
            this.lblMsg.TabIndex = 14;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "left-arrow.png");
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.BTBack);
            this.Controls.Add(this.TBConfirm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BTRegister);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBMail);
            this.Controls.Add(this.TBPhone);
            this.Controls.Add(this.TBSurname);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBSurname;
        private System.Windows.Forms.TextBox TBPhone;
        private System.Windows.Forms.TextBox TBMail;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Button BTRegister;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBConfirm;
        private System.Windows.Forms.Button BTBack;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.ImageList ımageList1;
    }
}