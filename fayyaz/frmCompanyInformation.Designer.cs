namespace testingInventory
{
    partial class frmCompanyInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
hi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompanyInformation));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbcity = new System.Windows.Forms.ComboBox();
            this.cmbcountry = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.chkagree = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txttype = new System.Windows.Forms.TextBox();
            this.doe = new System.Windows.Forms.DateTimePicker();
            this.dor = new System.Windows.Forms.DateTimePicker();
            this.txturl = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::testingInventory.WaitForm1), true, true);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(672, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Software Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbcity);
            this.panel1.Controls.Add(this.cmbcountry);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.chkagree);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.txtaddress);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txttype);
            this.panel1.Controls.Add(this.doe);
            this.panel1.Controls.Add(this.dor);
            this.panel1.Controls.Add(this.txturl);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.txtnumber);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtcname);
            this.panel1.Controls.Add(this.txtlname);
            this.panel1.Controls.Add(this.txtfname);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 349);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbcity
            // 
            this.cmbcity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbcity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbcity.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.cmbcity.FormattingEnabled = true;
            this.cmbcity.Location = new System.Drawing.Point(439, 194);
            this.cmbcity.Name = "cmbcity";
            this.cmbcity.Size = new System.Drawing.Size(214, 22);
            this.cmbcity.TabIndex = 32;
            this.cmbcity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbcity_KeyDown);
            // 
            // cmbcountry
            // 
            this.cmbcountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbcountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbcountry.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.cmbcountry.FormattingEnabled = true;
            this.cmbcountry.Location = new System.Drawing.Point(143, 196);
            this.cmbcountry.Name = "cmbcountry";
            this.cmbcountry.Size = new System.Drawing.Size(240, 22);
            this.cmbcountry.Sorted = true;
            this.cmbcountry.TabIndex = 31;
            this.cmbcountry.SelectedIndexChanged += new System.EventHandler(this.cmbcountry_SelectedIndexChanged);
            this.cmbcountry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbcountry_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(389, 196);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 17);
            this.label15.TabIndex = 30;
            this.label15.Text = "City :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(58, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "Country :";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(191, 318);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(147, 13);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "software terms and conditions";
            // 
            // chkagree
            // 
            this.chkagree.AutoSize = true;
            this.chkagree.Location = new System.Drawing.Point(35, 318);
            this.chkagree.Name = "chkagree";
            this.chkagree.Size = new System.Drawing.Size(161, 17);
            this.chkagree.TabIndex = 27;
            this.chkagree.Text = "I have read and agree to the";
            this.chkagree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkagree.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(397, 230);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(102, 17);
            this.checkBox2.TabIndex = 26;
            this.checkBox2.Text = "Show Password";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txtaddress.Location = new System.Drawing.Point(143, 126);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(510, 62);
            this.txtaddress.TabIndex = 25;
            this.txtaddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtaddress_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(59, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Address :";
            // 
            // txttype
            // 
            this.txttype.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txttype.Location = new System.Drawing.Point(143, 98);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(513, 22);
            this.txttype.TabIndex = 23;
            this.txttype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttype_KeyDown);
            // 
            // doe
            // 
            this.doe.CustomFormat = "yyyy-MM-dd";
            this.doe.Enabled = false;
            this.doe.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.doe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.doe.Location = new System.Drawing.Point(480, 283);
            this.doe.Name = "doe";
            this.doe.Size = new System.Drawing.Size(173, 22);
            this.doe.TabIndex = 19;
            // 
            // dor
            // 
            this.dor.CustomFormat = "yyyy-MM-dd";
            this.dor.Enabled = false;
            this.dor.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.dor.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dor.Location = new System.Drawing.Point(171, 283);
            this.dor.Name = "dor";
            this.dor.Size = new System.Drawing.Size(177, 22);
            this.dor.TabIndex = 18;
            // 
            // txturl
            // 
            this.txturl.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txturl.Location = new System.Drawing.Point(143, 255);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(510, 22);
            this.txturl.TabIndex = 17;
            this.txturl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txturl_KeyDown);
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txtpass.Location = new System.Drawing.Point(143, 227);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(249, 22);
            this.txtpass.TabIndex = 16;
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyDown);
            // 
            // txtnumber
            // 
            this.txtnumber.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txtnumber.Location = new System.Drawing.Point(481, 71);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(172, 22);
            this.txtnumber.TabIndex = 15;
            this.txtnumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnumber_KeyDown);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txtemail.Location = new System.Drawing.Point(143, 71);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(205, 22);
            this.txtemail.TabIndex = 14;
            this.txtemail.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txtemail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtemail_KeyDown);
            // 
            // txtcname
            // 
            this.txtcname.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txtcname.Location = new System.Drawing.Point(143, 45);
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(510, 22);
            this.txtcname.TabIndex = 13;
            this.txtcname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtcname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcname_KeyDown);
            // 
            // txtlname
            // 
            this.txtlname.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txtlname.Location = new System.Drawing.Point(418, 15);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(235, 22);
            this.txtlname.TabIndex = 12;
            this.txtlname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtlname_KeyDown);
            // 
            // txtfname
            // 
            this.txtfname.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txtfname.Location = new System.Drawing.Point(105, 17);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(208, 22);
            this.txtfname.TabIndex = 11;
            this.txtfname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfname_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(362, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Date of Expiry :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(10, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Date of Registration :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(19, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "FB Page or ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(48, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Password :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(17, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Business Type :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(357, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mobile Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(10, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Company Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(19, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(328, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Full Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pictureEdit1);
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Location = new System.Drawing.Point(2, 415);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 47);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(492, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Powered by :";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(564, 4);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 39);
            this.pictureEdit1.TabIndex = 2;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton2.Location = new System.Drawing.Point(111, 10);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(116, 26);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "&Exit Registration";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Teal;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton1.Location = new System.Drawing.Point(11, 10);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 26);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "&Sign up";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmCompanyInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(670, 466);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCompanyInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCompanyInformation_FormClosing);
            this.Load += new System.EventHandler(this.frmCompanyInformation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.DateTimePicker doe;
        private System.Windows.Forms.DateTimePicker dor;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox chkagree;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.ComboBox cmbcity;
        private System.Windows.Forms.ComboBox cmbcountry;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}
