namespace Adewale.SafeCracker
{
    partial class frmSafeCracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSafeCracker));
            this.pnlBack = new System.Windows.Forms.Panel();
            this.btnTimeTrial = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlSafe = new System.Windows.Forms.Panel();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.rad5Digits = new System.Windows.Forms.RadioButton();
            this.rad4Digits = new System.Windows.Forms.RadioButton();
            this.rad3Digits = new System.Windows.Forms.RadioButton();
            this.rad2Digits = new System.Windows.Forms.RadioButton();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.lblCombo2 = new System.Windows.Forms.Label();
            this.lblCombo3 = new System.Windows.Forms.Label();
            this.lblCombo4 = new System.Windows.Forms.Label();
            this.lblCombo1 = new System.Windows.Forms.Label();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlNum = new System.Windows.Forms.Panel();
            this.lblCombo5 = new System.Windows.Forms.Label();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.tmrBackColor = new System.Windows.Forms.Timer(this.components);
            this.tmrAnimate = new System.Windows.Forms.Timer(this.components);
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.tmrAnimate2 = new System.Windows.Forms.Timer(this.components);
            this.tmrAnimate2b = new System.Windows.Forms.Timer(this.components);
            this.tmrAnimate2a = new System.Windows.Forms.Timer(this.components);
            this.tmrLogo = new System.Windows.Forms.Timer(this.components);
            this.tmrAnimate2C = new System.Windows.Forms.Timer(this.components);
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pnlBack.SuspendLayout();
            this.pnlSafe.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.pnlGame.SuspendLayout();
            this.pnlNum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.pnlBack.Controls.Add(this.btnTimeTrial);
            this.pnlBack.Controls.Add(this.btnHint);
            this.pnlBack.Controls.Add(this.btnStart);
            this.pnlBack.Controls.Add(this.btnExit);
            this.pnlBack.Controls.Add(this.pnlSafe);
            this.pnlBack.Controls.Add(this.grpOptions);
            this.pnlBack.Controls.Add(this.grpResults);
            this.pnlBack.Location = new System.Drawing.Point(920, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(235, 603);
            this.pnlBack.TabIndex = 1;
            // 
            // btnTimeTrial
            // 
            this.btnTimeTrial.BackgroundImage = global::Adewale.SafeCracker.Properties.Resources.clock;
            this.btnTimeTrial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimeTrial.Location = new System.Drawing.Point(145, 532);
            this.btnTimeTrial.Name = "btnTimeTrial";
            this.btnTimeTrial.Size = new System.Drawing.Size(35, 27);
            this.btnTimeTrial.TabIndex = 3;
            this.btnTimeTrial.UseVisualStyleBackColor = true;
            this.btnTimeTrial.Click += new System.EventHandler(this.btnTimeTrial_Click);
            // 
            // btnHint
            // 
            this.btnHint.BackgroundImage = global::Adewale.SafeCracker.Properties.Resources.bulb;
            this.btnHint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHint.Location = new System.Drawing.Point(180, 532);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(35, 27);
            this.btnHint.TabIndex = 3;
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(9, 532);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(130, 27);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(9, 565);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(209, 27);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlSafe
            // 
            this.pnlSafe.Controls.Add(this.btn9);
            this.pnlSafe.Controls.Add(this.btn8);
            this.pnlSafe.Controls.Add(this.btn6);
            this.pnlSafe.Controls.Add(this.btn5);
            this.pnlSafe.Controls.Add(this.btn7);
            this.pnlSafe.Controls.Add(this.btn4);
            this.pnlSafe.Controls.Add(this.btn3);
            this.pnlSafe.Controls.Add(this.btn2);
            this.pnlSafe.Controls.Add(this.btn1);
            this.pnlSafe.Location = new System.Drawing.Point(14, 367);
            this.pnlSafe.Name = "pnlSafe";
            this.pnlSafe.Size = new System.Drawing.Size(202, 159);
            this.pnlSafe.TabIndex = 2;
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(145, 108);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(45, 45);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.MyButtons);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(80, 108);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(45, 45);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.MyButtons);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(145, 56);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(45, 45);
            this.btn6.TabIndex = 2;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.MyButtons);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(80, 56);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(45, 45);
            this.btn5.TabIndex = 2;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.MyButtons);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(14, 108);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(45, 45);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.MyButtons);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(14, 56);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(45, 45);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.MyButtons);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(145, 6);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(45, 45);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.MyButtons);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(80, 6);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(45, 45);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.MyButtons);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(14, 6);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 45);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.MyButtons);
            // 
            // grpOptions
            // 
            this.grpOptions.BackColor = System.Drawing.SystemColors.Control;
            this.grpOptions.Controls.Add(this.rad5Digits);
            this.grpOptions.Controls.Add(this.rad4Digits);
            this.grpOptions.Controls.Add(this.rad3Digits);
            this.grpOptions.Controls.Add(this.rad2Digits);
            this.grpOptions.ForeColor = System.Drawing.Color.DarkRed;
            this.grpOptions.Location = new System.Drawing.Point(14, 8);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(218, 168);
            this.grpOptions.TabIndex = 1;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // rad5Digits
            // 
            this.rad5Digits.BackColor = System.Drawing.SystemColors.Control;
            this.rad5Digits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad5Digits.ForeColor = System.Drawing.Color.DarkRed;
            this.rad5Digits.Location = new System.Drawing.Point(13, 127);
            this.rad5Digits.Name = "rad5Digits";
            this.rad5Digits.Size = new System.Drawing.Size(195, 29);
            this.rad5Digits.TabIndex = 0;
            this.rad5Digits.TabStop = true;
            this.rad5Digits.Text = "5 Digits in Combination";
            this.rad5Digits.UseVisualStyleBackColor = false;
            // 
            // rad4Digits
            // 
            this.rad4Digits.BackColor = System.Drawing.SystemColors.Control;
            this.rad4Digits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad4Digits.ForeColor = System.Drawing.Color.DarkRed;
            this.rad4Digits.Location = new System.Drawing.Point(13, 92);
            this.rad4Digits.Name = "rad4Digits";
            this.rad4Digits.Size = new System.Drawing.Size(195, 29);
            this.rad4Digits.TabIndex = 0;
            this.rad4Digits.TabStop = true;
            this.rad4Digits.Text = "4 Digits in Combination";
            this.rad4Digits.UseVisualStyleBackColor = false;
            // 
            // rad3Digits
            // 
            this.rad3Digits.BackColor = System.Drawing.SystemColors.Control;
            this.rad3Digits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad3Digits.ForeColor = System.Drawing.Color.DarkRed;
            this.rad3Digits.Location = new System.Drawing.Point(10, 57);
            this.rad3Digits.Name = "rad3Digits";
            this.rad3Digits.Size = new System.Drawing.Size(194, 29);
            this.rad3Digits.TabIndex = 0;
            this.rad3Digits.TabStop = true;
            this.rad3Digits.Text = "3 Digits in Combination";
            this.rad3Digits.UseVisualStyleBackColor = false;
            // 
            // rad2Digits
            // 
            this.rad2Digits.BackColor = System.Drawing.SystemColors.Control;
            this.rad2Digits.Checked = true;
            this.rad2Digits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad2Digits.ForeColor = System.Drawing.Color.DarkRed;
            this.rad2Digits.Location = new System.Drawing.Point(10, 15);
            this.rad2Digits.Name = "rad2Digits";
            this.rad2Digits.Size = new System.Drawing.Size(195, 36);
            this.rad2Digits.TabIndex = 0;
            this.rad2Digits.TabStop = true;
            this.rad2Digits.Text = "2 Digits in Combination";
            this.rad2Digits.UseVisualStyleBackColor = false;
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.txtUser);
            this.grpResults.Controls.Add(this.txtResults);
            this.grpResults.Location = new System.Drawing.Point(14, 182);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(209, 179);
            this.grpResults.TabIndex = 4;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results";
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(10, 19);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(191, 150);
            this.txtResults.TabIndex = 0;
            // 
            // lblCombo2
            // 
            this.lblCombo2.BackColor = System.Drawing.Color.Transparent;
            this.lblCombo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCombo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombo2.ForeColor = System.Drawing.Color.Red;
            this.lblCombo2.Location = new System.Drawing.Point(49, 8);
            this.lblCombo2.Name = "lblCombo2";
            this.lblCombo2.Size = new System.Drawing.Size(30, 34);
            this.lblCombo2.TabIndex = 2;
            this.lblCombo2.Text = "0";
            // 
            // lblCombo3
            // 
            this.lblCombo3.BackColor = System.Drawing.Color.Transparent;
            this.lblCombo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCombo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombo3.ForeColor = System.Drawing.Color.Red;
            this.lblCombo3.Location = new System.Drawing.Point(85, 8);
            this.lblCombo3.Name = "lblCombo3";
            this.lblCombo3.Size = new System.Drawing.Size(30, 34);
            this.lblCombo3.TabIndex = 2;
            this.lblCombo3.Text = "0";
            // 
            // lblCombo4
            // 
            this.lblCombo4.BackColor = System.Drawing.Color.Transparent;
            this.lblCombo4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCombo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombo4.ForeColor = System.Drawing.Color.Red;
            this.lblCombo4.Location = new System.Drawing.Point(121, 8);
            this.lblCombo4.Name = "lblCombo4";
            this.lblCombo4.Size = new System.Drawing.Size(30, 34);
            this.lblCombo4.TabIndex = 2;
            this.lblCombo4.Text = "0";
            // 
            // lblCombo1
            // 
            this.lblCombo1.BackColor = System.Drawing.Color.Transparent;
            this.lblCombo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCombo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombo1.ForeColor = System.Drawing.Color.Red;
            this.lblCombo1.Location = new System.Drawing.Point(13, 8);
            this.lblCombo1.Name = "lblCombo1";
            this.lblCombo1.Size = new System.Drawing.Size(30, 34);
            this.lblCombo1.TabIndex = 2;
            this.lblCombo1.Text = "0";
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.Transparent;
            this.pnlGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlGame.Controls.Add(this.lblTime);
            this.pnlGame.Controls.Add(this.pnlNum);
            this.pnlGame.Controls.Add(this.picBack);
            this.pnlGame.Location = new System.Drawing.Point(0, 0);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(1170, 642);
            this.pnlGame.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(842, 558);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(72, 34);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "00";
            // 
            // pnlNum
            // 
            this.pnlNum.BackColor = System.Drawing.Color.Black;
            this.pnlNum.Controls.Add(this.lblCombo2);
            this.pnlNum.Controls.Add(this.lblCombo1);
            this.pnlNum.Controls.Add(this.lblCombo5);
            this.pnlNum.Controls.Add(this.lblCombo4);
            this.pnlNum.Controls.Add(this.lblCombo3);
            this.pnlNum.Location = new System.Drawing.Point(149, 491);
            this.pnlNum.Name = "pnlNum";
            this.pnlNum.Size = new System.Drawing.Size(202, 47);
            this.pnlNum.TabIndex = 1;
            // 
            // lblCombo5
            // 
            this.lblCombo5.BackColor = System.Drawing.Color.Transparent;
            this.lblCombo5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCombo5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombo5.ForeColor = System.Drawing.Color.Red;
            this.lblCombo5.Location = new System.Drawing.Point(158, 8);
            this.lblCombo5.Name = "lblCombo5";
            this.lblCombo5.Size = new System.Drawing.Size(30, 34);
            this.lblCombo5.TabIndex = 2;
            this.lblCombo5.Text = "0";
            // 
            // picBack
            // 
            this.picBack.Image = global::Adewale.SafeCracker.Properties.Resources.giphy;
            this.picBack.Location = new System.Drawing.Point(0, 0);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(923, 603);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBack.TabIndex = 0;
            this.picBack.TabStop = false;
            // 
            // tmrBackColor
            // 
            this.tmrBackColor.Tick += new System.EventHandler(this.tmrBackColor_Tick);
            // 
            // tmrAnimate
            // 
            this.tmrAnimate.Interval = 500;
            this.tmrAnimate.Tick += new System.EventHandler(this.tmrAnimate_Tick);
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 1000;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // tmrAnimate2
            // 
            this.tmrAnimate2.Interval = 200;
            this.tmrAnimate2.Tick += new System.EventHandler(this.tmrAnimate2_Tick);
            // 
            // tmrAnimate2b
            // 
            this.tmrAnimate2b.Interval = 200;
            this.tmrAnimate2b.Tick += new System.EventHandler(this.tmrAnimate2b_Tick);
            // 
            // tmrAnimate2a
            // 
            this.tmrAnimate2a.Interval = 200;
            this.tmrAnimate2a.Tick += new System.EventHandler(this.tmrAnimate2a_Tick);
            // 
            // tmrLogo
            // 
            this.tmrLogo.Interval = 1000;
            this.tmrLogo.Tick += new System.EventHandler(this.tmrLogo_Tick);
            // 
            // tmrAnimate2C
            // 
            this.tmrAnimate2C.Interval = 200;
            this.tmrAnimate2C.Tick += new System.EventHandler(this.tmrAnimate2c_Tick);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(145, 0);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(64, 20);
            this.txtUser.TabIndex = 3;
            this.txtUser.Text = "User";
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // frmSafeCracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1154, 604);
            this.Controls.Add(this.pnlBack);
            this.Controls.Add(this.pnlGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSafeCracker";
            this.Text = "Safe Cracker";
            this.Load += new System.EventHandler(this.frmSafeCracker_Load);
            this.pnlBack.ResumeLayout(false);
            this.pnlSafe.ResumeLayout(false);
            this.grpOptions.ResumeLayout(false);
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.pnlGame.ResumeLayout(false);
            this.pnlNum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Panel pnlSafe;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.RadioButton rad4Digits;
        private System.Windows.Forms.RadioButton rad3Digits;
        private System.Windows.Forms.RadioButton rad2Digits;
        private System.Windows.Forms.Label lblCombo2;
        private System.Windows.Forms.Label lblCombo3;
        private System.Windows.Forms.Label lblCombo4;
        private System.Windows.Forms.Label lblCombo1;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Timer tmrBackColor;
        private System.Windows.Forms.Timer tmrAnimate;
        private System.Windows.Forms.Panel pnlNum;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrAnimate2;
        private System.Windows.Forms.Timer tmrAnimate2b;
        private System.Windows.Forms.Timer tmrAnimate2a;
        private System.Windows.Forms.Timer tmrLogo;
        private System.Windows.Forms.RadioButton rad5Digits;
        private System.Windows.Forms.Label lblCombo5;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Timer tmrAnimate2C;
        private System.Windows.Forms.Button btnTimeTrial;
        private System.Windows.Forms.TextBox txtUser;
    }
}

