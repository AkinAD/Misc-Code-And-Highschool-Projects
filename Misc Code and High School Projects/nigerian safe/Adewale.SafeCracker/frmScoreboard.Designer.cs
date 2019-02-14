namespace Adewale.SafeCracker
{
    partial class frmScoreboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScoreboard));
            this.tmrAward = new System.Windows.Forms.Timer(this.components);
            this.lstData = new System.Windows.Forms.ListBox();
            this.tmrData = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblData = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.tmrScore = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.picAward = new System.Windows.Forms.PictureBox();
            this.picAward3 = new System.Windows.Forms.PictureBox();
            this.picAward2 = new System.Windows.Forms.PictureBox();
            this.picAward1 = new System.Windows.Forms.PictureBox();
            this.pnlNoReasonWhyThisPanelExists = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAward3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAward2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAward1)).BeginInit();
            this.pnlNoReasonWhyThisPanelExists.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrAward
            // 
            this.tmrAward.Tick += new System.EventHandler(this.tmrAward_Tick);
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.Location = new System.Drawing.Point(1, 24);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(469, 355);
            this.lstData.TabIndex = 24;
            // 
            // tmrData
            // 
            this.tmrData.Interval = 10;
            this.tmrData.Tick += new System.EventHandler(this.tmrData_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
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
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(-5, 14);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(224, 76);
            this.lblData.TabIndex = 25;
            this.lblData.Text = "List updates automatically after every game played";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(157, 216);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(19, 20);
            this.lblCount.TabIndex = 28;
            this.lblCount.Text = "0";
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTotal.Location = new System.Drawing.Point(17, 145);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(213, 32);
            this.btnTotal.TabIndex = 27;
            this.btnTotal.Text = "HighScore";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Visible = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // tmrScore
            // 
            this.tmrScore.Interval = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Games played : ";
            // 
            // picAward
            // 
            this.picAward.BackColor = System.Drawing.Color.White;
            this.picAward.Image = ((System.Drawing.Image)(resources.GetObject("picAward.Image")));
            this.picAward.Location = new System.Drawing.Point(198, 120);
            this.picAward.Name = "picAward";
            this.picAward.Size = new System.Drawing.Size(95, 81);
            this.picAward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAward.TabIndex = 30;
            this.picAward.TabStop = false;
            this.picAward.Visible = false;
            // 
            // picAward3
            // 
            this.picAward3.BackColor = System.Drawing.Color.White;
            this.picAward3.Image = ((System.Drawing.Image)(resources.GetObject("picAward3.Image")));
            this.picAward3.Location = new System.Drawing.Point(280, 59);
            this.picAward3.Name = "picAward3";
            this.picAward3.Size = new System.Drawing.Size(42, 30);
            this.picAward3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAward3.TabIndex = 31;
            this.picAward3.TabStop = false;
            this.picAward3.Visible = false;
            // 
            // picAward2
            // 
            this.picAward2.BackColor = System.Drawing.Color.White;
            this.picAward2.Image = ((System.Drawing.Image)(resources.GetObject("picAward2.Image")));
            this.picAward2.Location = new System.Drawing.Point(263, 73);
            this.picAward2.Name = "picAward2";
            this.picAward2.Size = new System.Drawing.Size(59, 41);
            this.picAward2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAward2.TabIndex = 32;
            this.picAward2.TabStop = false;
            this.picAward2.Visible = false;
            // 
            // picAward1
            // 
            this.picAward1.BackColor = System.Drawing.Color.White;
            this.picAward1.Image = ((System.Drawing.Image)(resources.GetObject("picAward1.Image")));
            this.picAward1.Location = new System.Drawing.Point(234, 90);
            this.picAward1.Name = "picAward1";
            this.picAward1.Size = new System.Drawing.Size(81, 62);
            this.picAward1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAward1.TabIndex = 33;
            this.picAward1.TabStop = false;
            this.picAward1.Visible = false;
            // 
            // pnlNoReasonWhyThisPanelExists
            // 
            this.pnlNoReasonWhyThisPanelExists.BackgroundImage = global::Adewale.SafeCracker.Properties.Resources.all_da_pepes;
            this.pnlNoReasonWhyThisPanelExists.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNoReasonWhyThisPanelExists.Controls.Add(this.lblData);
            this.pnlNoReasonWhyThisPanelExists.Controls.Add(this.btnTotal);
            this.pnlNoReasonWhyThisPanelExists.Controls.Add(this.lblCount);
            this.pnlNoReasonWhyThisPanelExists.Controls.Add(this.label1);
            this.pnlNoReasonWhyThisPanelExists.Location = new System.Drawing.Point(470, 24);
            this.pnlNoReasonWhyThisPanelExists.Name = "pnlNoReasonWhyThisPanelExists";
            this.pnlNoReasonWhyThisPanelExists.Size = new System.Drawing.Size(262, 355);
            this.pnlNoReasonWhyThisPanelExists.TabIndex = 34;
            // 
            // frmScoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Adewale.SafeCracker.Properties.Resources.PEPE2;
            this.ClientSize = new System.Drawing.Size(732, 397);
            this.Controls.Add(this.pnlNoReasonWhyThisPanelExists);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picAward);
            this.Controls.Add(this.picAward3);
            this.Controls.Add(this.picAward2);
            this.Controls.Add(this.picAward1);
            this.Controls.Add(this.lstData);
            this.Name = "frmScoreboard";
            this.Text = "Scoreboard";
            this.Load += new System.EventHandler(this.frmScoreboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAward3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAward2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAward1)).EndInit();
            this.pnlNoReasonWhyThisPanelExists.ResumeLayout(false);
            this.pnlNoReasonWhyThisPanelExists.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrAward;
        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.Timer tmrData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Timer tmrScore;
        private System.Windows.Forms.PictureBox picAward;
        private System.Windows.Forms.PictureBox picAward3;
        private System.Windows.Forms.PictureBox picAward2;
        private System.Windows.Forms.PictureBox picAward1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlNoReasonWhyThisPanelExists;
    }
}