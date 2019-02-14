namespace Adewale.TheAdventuresOfSharkeisha
{
    partial class frmPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPassword));
            this.picThird = new System.Windows.Forms.PictureBox();
            this.picSecond = new System.Windows.Forms.PictureBox();
            this.picFirst = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tmrPictures = new System.Windows.Forms.Timer(this.components);
            this.tmrStart = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picThird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFirst)).BeginInit();
            this.SuspendLayout();
            // 
            // picThird
            // 
            this.picThird.BackColor = System.Drawing.Color.Transparent;
            this.picThird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picThird.Location = new System.Drawing.Point(266, 197);
            this.picThird.Name = "picThird";
            this.picThird.Size = new System.Drawing.Size(100, 76);
            this.picThird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picThird.TabIndex = 15;
            this.picThird.TabStop = false;
            // 
            // picSecond
            // 
            this.picSecond.BackColor = System.Drawing.Color.Transparent;
            this.picSecond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSecond.Location = new System.Drawing.Point(144, 197);
            this.picSecond.Name = "picSecond";
            this.picSecond.Size = new System.Drawing.Size(100, 76);
            this.picSecond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSecond.TabIndex = 14;
            this.picSecond.TabStop = false;
            // 
            // picFirst
            // 
            this.picFirst.BackColor = System.Drawing.Color.Transparent;
            this.picFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picFirst.Location = new System.Drawing.Point(12, 197);
            this.picFirst.Name = "picFirst";
            this.picFirst.Size = new System.Drawing.Size(100, 76);
            this.picFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFirst.TabIndex = 13;
            this.picFirst.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(346, 47);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(130, 31);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(394, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 25);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(394, 176);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(99, 27);
            this.btnEnter.TabIndex = 10;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(-1, 113);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(523, 33);
            this.lblWelcome.TabIndex = 9;
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lblPassword.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPassword.Location = new System.Drawing.Point(178, 47);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(162, 31);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Enter Password :";
            // 
            // tmrPictures
            // 
            this.tmrPictures.Tick += new System.EventHandler(this.tmrPictures_Tick);
            // 
            // tmrStart
            // 
            this.tmrStart.Tick += new System.EventHandler(this.tmrStart_Tick);
            // 
            // frmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Adewale.TheAdventuresOfSharkeisha.Properties.Resources.Custom_Programmable_Access_Control_Systems;
            this.ClientSize = new System.Drawing.Size(521, 320);
            this.Controls.Add(this.picThird);
            this.Controls.Add(this.picSecond);
            this.Controls.Add(this.picFirst);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Required";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPassword_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picThird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFirst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picThird;
        private System.Windows.Forms.PictureBox picSecond;
        private System.Windows.Forms.PictureBox picFirst;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Timer tmrPictures;
        private System.Windows.Forms.Timer tmrStart;
    }
}