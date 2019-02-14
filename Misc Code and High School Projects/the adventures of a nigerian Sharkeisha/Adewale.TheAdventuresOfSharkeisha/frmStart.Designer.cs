namespace Adewale.TheAdventuresOfSharkeisha
{
    partial class frmStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblMeh = new System.Windows.Forms.Label();
            this.lblUserN = new System.Windows.Forms.Label();
            this.tmrLogin = new System.Windows.Forms.Timer(this.components);
            this.picAnimate = new System.Windows.Forms.PictureBox();
            this.tmrStart = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picAnimate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(27, 60);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(229, 13);
            this.lblUser.TabIndex = 25;
            this.lblUser.Text = "Please Create Username and Password";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(38, 161);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(73, 13);
            this.lblPass.TabIndex = 24;
            this.lblPass.Text = "Password : ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(40, 124);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(71, 13);
            this.lblUserName.TabIndex = 23;
            this.lblUserName.Text = "Username :";
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Location = new System.Drawing.Point(128, 193);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 22;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(128, 154);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 21;
            this.txtPass.Text = "Enter Password";
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(128, 117);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 20;
            this.txtUser.Text = "Enter Username";
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // lblMeh
            // 
            this.lblMeh.BackColor = System.Drawing.Color.Transparent;
            this.lblMeh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeh.ForeColor = System.Drawing.Color.White;
            this.lblMeh.Location = new System.Drawing.Point(12, 255);
            this.lblMeh.Name = "lblMeh";
            this.lblMeh.Size = new System.Drawing.Size(201, 43);
            this.lblMeh.TabIndex = 26;
            this.lblMeh.Text = "* Note :  Password here differs from password required to open bonus rounds!";
            // 
            // lblUserN
            // 
            this.lblUserN.AutoSize = true;
            this.lblUserN.BackColor = System.Drawing.SystemColors.Control;
            this.lblUserN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserN.Location = new System.Drawing.Point(215, 9);
            this.lblUserN.Name = "lblUserN";
            this.lblUserN.Size = new System.Drawing.Size(41, 13);
            this.lblUserN.TabIndex = 27;
            this.lblUserN.Text = "User :";
            // 
            // tmrLogin
            // 
            this.tmrLogin.Interval = 125;
            this.tmrLogin.Tick += new System.EventHandler(this.tmrLogin_Tick);
            // 
            // picAnimate
            // 
            this.picAnimate.BackColor = System.Drawing.Color.Transparent;
            this.picAnimate.Location = new System.Drawing.Point(252, 116);
            this.picAnimate.Name = "picAnimate";
            this.picAnimate.Size = new System.Drawing.Size(161, 148);
            this.picAnimate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnimate.TabIndex = 28;
            this.picAnimate.TabStop = false;
            // 
            // tmrStart
            // 
            this.tmrStart.Tick += new System.EventHandler(this.tmrStart_Tick);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Adewale.TheAdventuresOfSharkeisha.Properties.Resources._1685061;
            this.ClientSize = new System.Drawing.Size(427, 355);
            this.Controls.Add(this.picAnimate);
            this.Controls.Add(this.lblUserN);
            this.Controls.Add(this.lblMeh);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmStart";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picAnimate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblMeh;
        private System.Windows.Forms.Label lblUserN;
        private System.Windows.Forms.Timer tmrLogin;
        private System.Windows.Forms.PictureBox picAnimate;
        private System.Windows.Forms.Timer tmrStart;
    }
}