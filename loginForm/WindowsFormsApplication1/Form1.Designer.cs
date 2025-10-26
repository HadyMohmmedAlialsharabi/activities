namespace WindowsFormsApplication1
{
    partial class Form1
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
            Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.EmailTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.submitBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.rdMail = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rdFemael = new System.Windows.Forms.RadioButton();
            this.rdOther = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCountruy = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lpColor = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lpresult = new System.Windows.Forms.Label();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 4;
            bunifuElipse1.TargetControl = this.lpresult;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(65, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(61, 47);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(65, 48);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.nameTextBox.HintText = "";
            this.nameTextBox.isPassword = false;
            this.nameTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.nameTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.nameTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.nameTextBox.LineThickness = 3;
            this.nameTextBox.Location = new System.Drawing.Point(219, 67);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(370, 86);
            this.nameTextBox.TabIndex = 8;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmailTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.EmailTextBox.HintText = "";
            this.EmailTextBox.isPassword = false;
            this.EmailTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.EmailTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.EmailTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.EmailTextBox.LineThickness = 3;
            this.EmailTextBox.Location = new System.Drawing.Point(219, 173);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(370, 86);
            this.EmailTextBox.TabIndex = 9;
            this.EmailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // passTextBox
            // 
            this.passTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.passTextBox.HintText = "";
            this.passTextBox.isPassword = true;
            this.passTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.passTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.passTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.passTextBox.LineThickness = 3;
            this.passTextBox.Location = new System.Drawing.Point(219, 267);
            this.passTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(370, 86);
            this.passTextBox.TabIndex = 10;
            this.passTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // submitBtn
            // 
            this.submitBtn.ActiveBorderThickness = 1;
            this.submitBtn.ActiveCornerRadius = 20;
            this.submitBtn.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.submitBtn.ActiveForecolor = System.Drawing.Color.White;
            this.submitBtn.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.submitBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submitBtn.BackgroundImage")));
            this.submitBtn.ButtonText = "Submit";
            this.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBtn.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.submitBtn.IdleBorderThickness = 2;
            this.submitBtn.IdleCornerRadius = 10;
            this.submitBtn.IdleFillColor = System.Drawing.Color.White;
            this.submitBtn.IdleForecolor = System.Drawing.Color.SlateGray;
            this.submitBtn.IdleLineColor = System.Drawing.Color.SlateGray;
            this.submitBtn.Location = new System.Drawing.Point(15, 466);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(356, 79);
            this.submitBtn.TabIndex = 11;
            this.submitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.SteelBlue;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(552, 9);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(96, 55);
            this.bunifuCustomLabel2.TabIndex = 12;
            this.bunifuCustomLabel2.Text = " IN";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(475, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(105, 55);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "LOG";
            // 
            // rdMail
            // 
            this.rdMail.AutoSize = true;
            this.rdMail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMail.ForeColor = System.Drawing.Color.Gray;
            this.rdMail.Location = new System.Drawing.Point(686, 491);
            this.rdMail.Name = "rdMail";
            this.rdMail.Size = new System.Drawing.Size(88, 39);
            this.rdMail.TabIndex = 14;
            this.rdMail.TabStop = true;
            this.rdMail.Text = "Mail";
            this.rdMail.UseVisualStyleBackColor = true;
            this.rdMail.CheckedChanged += new System.EventHandler(this.bunifuCustomTextbox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(492, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 39);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gender ";
            // 
            // rdFemael
            // 
            this.rdFemael.AutoSize = true;
            this.rdFemael.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFemael.ForeColor = System.Drawing.Color.Gray;
            this.rdFemael.Location = new System.Drawing.Point(824, 491);
            this.rdFemael.Name = "rdFemael";
            this.rdFemael.Size = new System.Drawing.Size(114, 39);
            this.rdFemael.TabIndex = 16;
            this.rdFemael.TabStop = true;
            this.rdFemael.Text = "Femail";
            this.rdFemael.UseVisualStyleBackColor = true;
            this.rdFemael.CheckedChanged += new System.EventHandler(this.bunifuCustomTextbox1_TextChanged);
            // 
            // rdOther
            // 
            this.rdOther.AccessibleDescription = "Other";
            this.rdOther.AutoSize = true;
            this.rdOther.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdOther.ForeColor = System.Drawing.Color.Gray;
            this.rdOther.Location = new System.Drawing.Point(976, 492);
            this.rdOther.Name = "rdOther";
            this.rdOther.Size = new System.Drawing.Size(109, 39);
            this.rdOther.TabIndex = 17;
            this.rdOther.TabStop = true;
            this.rdOther.Text = "Other";
            this.rdOther.UseVisualStyleBackColor = true;
            this.rdOther.CheckedChanged += new System.EventHandler(this.bunifuCustomTextbox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(659, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 39);
            this.label5.TabIndex = 19;
            this.label5.Text = "Contury";
            // 
            // cmbCountruy
            // 
            this.cmbCountruy.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCountruy.FormattingEnabled = true;
            this.cmbCountruy.Items.AddRange(new object[] {
            "YEMEN",
            "KSA",
            "UAE",
            "USA",
            "UK",
            "JAPAN",
            "CHINA",
            "OMAN"});
            this.cmbCountruy.Location = new System.Drawing.Point(821, 149);
            this.cmbCountruy.Name = "cmbCountruy";
            this.cmbCountruy.Size = new System.Drawing.Size(244, 43);
            this.cmbCountruy.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(821, 240);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 41);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(659, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 39);
            this.label6.TabIndex = 22;
            this.label6.Text = "Birthdate";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Choose Color";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.IdleBorderThickness = 2;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton21.Location = new System.Drawing.Point(658, 301);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(407, 70);
            this.bunifuThinButton21.TabIndex = 23;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // lpColor
            // 
            this.lpColor.AutoSize = true;
            this.lpColor.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpColor.Location = new System.Drawing.Point(769, 385);
            this.lpColor.Name = "lpColor";
            this.lpColor.Size = new System.Drawing.Size(190, 29);
            this.lpColor.TabIndex = 24;
            this.lpColor.Text = "No Color Selceted";
            // 
            // lpresult
            // 
            this.lpresult.AutoSize = true;
            this.lpresult.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lpresult.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpresult.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lpresult.Location = new System.Drawing.Point(22, 417);
            this.lpresult.Name = "lpresult";
            this.lpresult.Padding = new System.Windows.Forms.Padding(5);
            this.lpresult.Size = new System.Drawing.Size(10, 39);
            this.lpresult.TabIndex = 25;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Silver;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Rest";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton22.IdleBorderThickness = 2;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuThinButton22.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.Location = new System.Drawing.Point(976, 15);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(132, 70);
            this.bunifuThinButton22.TabIndex = 26;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(1123, 560);
            this.panel1.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1123, 560);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.lpresult);
            this.Controls.Add(this.lpColor);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbCountruy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdOther);
            this.Controls.Add(this.rdFemael);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdMail);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CNR";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nameTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmailTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passTextBox;
        private Bunifu.Framework.UI.BunifuThinButton2 submitBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.RadioButton rdOther;
        private System.Windows.Forms.RadioButton rdFemael;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCountruy;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lpColor;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lpresult;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.Panel panel1;
    }
}

