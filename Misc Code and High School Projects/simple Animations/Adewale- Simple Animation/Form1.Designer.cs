namespace Adewale__Simple_Animation
{
    partial class frmInvasion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvasion));
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.picAlien = new System.Windows.Forms.PictureBox();
            this.tmrHover = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.radHorizontal = new System.Windows.Forms.RadioButton();
            this.radVertical = new System.Windows.Forms.RadioButton();
            this.tmrHoverX = new System.Windows.Forms.Timer(this.components);
            this.chkPaint = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radRandom = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picAlien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Location = new System.Drawing.Point(25, 12);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(711, 446);
            this.pnlDisplay.TabIndex = 0;
            // 
            // picAlien
            // 
            this.picAlien.Image = global::Adewale__Simple_Animation.Properties.Resources.saucer;
            this.picAlien.Location = new System.Drawing.Point(537, 488);
            this.picAlien.Name = "picAlien";
            this.picAlien.Size = new System.Drawing.Size(149, 66);
            this.picAlien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAlien.TabIndex = 1;
            this.picAlien.TabStop = false;
            // 
            // tmrHover
            // 
            this.tmrHover.Tick += new System.EventHandler(this.tmrHover_Tick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnStart.Location = new System.Drawing.Point(38, 488);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(156, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Invasion";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnExit.Location = new System.Drawing.Point(38, 528);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // radHorizontal
            // 
            this.radHorizontal.AutoSize = true;
            this.radHorizontal.Location = new System.Drawing.Point(17, 52);
            this.radHorizontal.Name = "radHorizontal";
            this.radHorizontal.Size = new System.Drawing.Size(72, 17);
            this.radHorizontal.TabIndex = 3;
            this.radHorizontal.Text = "Horizontal";
            this.radHorizontal.UseVisualStyleBackColor = true;
            // 
            // radVertical
            // 
            this.radVertical.AutoSize = true;
            this.radVertical.Checked = true;
            this.radVertical.Location = new System.Drawing.Point(17, 28);
            this.radVertical.Name = "radVertical";
            this.radVertical.Size = new System.Drawing.Size(60, 17);
            this.radVertical.TabIndex = 4;
            this.radVertical.TabStop = true;
            this.radVertical.Text = "Vertical";
            this.radVertical.UseVisualStyleBackColor = true;
            // 
            // tmrHoverX
            // 
            this.tmrHoverX.Tick += new System.EventHandler(this.tmrHoverX_Tick);
            // 
            // chkPaint
            // 
            this.chkPaint.AutoSize = true;
            this.chkPaint.Location = new System.Drawing.Point(105, 52);
            this.chkPaint.Name = "chkPaint";
            this.chkPaint.Size = new System.Drawing.Size(50, 17);
            this.chkPaint.TabIndex = 5;
            this.chkPaint.Text = "Paint";
            this.chkPaint.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radRandom);
            this.groupBox1.Controls.Add(this.radVertical);
            this.groupBox1.Controls.Add(this.chkPaint);
            this.groupBox1.Controls.Add(this.radHorizontal);
            this.groupBox1.Location = new System.Drawing.Point(200, 464);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 105);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(102, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "*Paint only available with Randomize";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radRandom
            // 
            this.radRandom.AutoSize = true;
            this.radRandom.Location = new System.Drawing.Point(105, 27);
            this.radRandom.Name = "radRandom";
            this.radRandom.Size = new System.Drawing.Size(78, 17);
            this.radRandom.TabIndex = 3;
            this.radRandom.Text = "Randomize";
            this.radRandom.UseVisualStyleBackColor = true;
            // 
            // frmInvasion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(735, 566);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picAlien);
            this.Controls.Add(this.pnlDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInvasion";
            this.Text = "Space Invasion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInvasion_FormClosing);
            this.Load += new System.EventHandler(this.frmInvasion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAlien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.PictureBox picAlien;
        private System.Windows.Forms.Timer tmrHover;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radHorizontal;
        private System.Windows.Forms.RadioButton radVertical;
        private System.Windows.Forms.Timer tmrHoverX;
        private System.Windows.Forms.CheckBox chkPaint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radRandom;
    }
}

