namespace Adewale.TheAdventuresOfSharkeisha
{
    partial class frmScoreBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScoreBoard));
            this.lstData = new System.Windows.Forms.ListBox();
            this.tmrData = new System.Windows.Forms.Timer(this.components);
            this.lblData = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUserN = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrPicture = new System.Windows.Forms.Timer(this.components);
            this.picAward = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAward)).BeginInit();
            this.SuspendLayout();
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.Location = new System.Drawing.Point(19, 24);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(469, 355);
            this.lstData.TabIndex = 0;
            // 
            // tmrData
            // 
            this.tmrData.Interval = 1000;
            this.tmrData.Tick += new System.EventHandler(this.tmrData_Tick);
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(486, 30);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(224, 76);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "List updates automatically every 30 seconds";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SaddleBrown;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.BackColor = System.Drawing.Color.SaddleBrown;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.SaddleBrown;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblUserN
            // 
            this.lblUserN.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblUserN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserN.Location = new System.Drawing.Point(469, 0);
            this.lblUserN.Name = "lblUserN";
            this.lblUserN.Size = new System.Drawing.Size(100, 23);
            this.lblUserN.TabIndex = 3;
            this.lblUserN.Text = "User :";
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.SandyBrown;
            this.btnTotal.Location = new System.Drawing.Point(490, 140);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(213, 32);
            this.btnTotal.TabIndex = 4;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(509, 193);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(123, 20);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Feed Stopped";
            this.lblTime.Visible = false;
            // 
            // tmrPicture
            // 
            this.tmrPicture.Interval = 1000;
            this.tmrPicture.Tick += new System.EventHandler(this.tmrPicture_Tick);
            // 
            // picAward
            // 
            this.picAward.BackColor = System.Drawing.Color.Transparent;
            this.picAward.Location = new System.Drawing.Point(538, 259);
            this.picAward.Name = "picAward";
            this.picAward.Size = new System.Drawing.Size(165, 106);
            this.picAward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAward.TabIndex = 6;
            this.picAward.TabStop = false;
            this.picAward.Visible = false;
            // 
            // frmScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Adewale.TheAdventuresOfSharkeisha.Properties.Resources.school_bullitin_board_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 397);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.picAward);
            this.Controls.Add(this.lstData);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.lblUserN);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmScoreBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score Board";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmScoreBoard_FormClosing);
            this.Load += new System.EventHandler(this.frmScoreBoard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAward)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.Timer tmrData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblUserN;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrPicture;
        private System.Windows.Forms.PictureBox picAward;
    }
}