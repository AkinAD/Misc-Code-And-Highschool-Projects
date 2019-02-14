namespace Adewale.TheAdventuresOfSharkeisha
{
    partial class frmBonus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBonus));
            this.btnPingPong = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPingPong
            // 
            this.btnPingPong.BackColor = System.Drawing.Color.Turquoise;
            this.btnPingPong.Location = new System.Drawing.Point(12, 12);
            this.btnPingPong.Name = "btnPingPong";
            this.btnPingPong.Size = new System.Drawing.Size(111, 39);
            this.btnPingPong.TabIndex = 0;
            this.btnPingPong.Text = "Ping Pong";
            this.btnPingPong.UseVisualStyleBackColor = false;
            this.btnPingPong.Click += new System.EventHandler(this.btnPingPong_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Turquoise;
            this.btnExit.Location = new System.Drawing.Point(469, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 38);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Adewale.TheAdventuresOfSharkeisha.Properties.Resources.gt_promoimage_1280x720_bonusround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(556, 313);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPingPong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBonus";
            this.Text = "Bonus rounds!!!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBonus_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPingPong;
        private System.Windows.Forms.Button btnExit;
    }
}