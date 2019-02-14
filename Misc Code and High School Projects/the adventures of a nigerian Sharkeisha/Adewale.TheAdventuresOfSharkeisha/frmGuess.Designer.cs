namespace Adewale.TheAdventuresOfSharkeisha
{
    partial class frmDrinks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrinks));
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblRightorWrong = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblNumberOfGuesses = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGuess = new System.Windows.Forms.Label();
            this.picWife = new System.Windows.Forms.PictureBox();
            this.picPictures = new System.Windows.Forms.PictureBox();
            this.tmrBackColor = new System.Windows.Forms.Timer(this.components);
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPictures)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(34, 234);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 13);
            this.lblNumber.TabIndex = 17;
            // 
            // lblRightorWrong
            // 
            this.lblRightorWrong.BackColor = System.Drawing.Color.SeaShell;
            this.lblRightorWrong.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightorWrong.Location = new System.Drawing.Point(0, 177);
            this.lblRightorWrong.Name = "lblRightorWrong";
            this.lblRightorWrong.Size = new System.Drawing.Size(267, 48);
            this.lblRightorWrong.TabIndex = 15;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(313, 29);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 14;
            this.txtInput.Visible = false;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblNumberOfGuesses
            // 
            this.lblNumberOfGuesses.AutoSize = true;
            this.lblNumberOfGuesses.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfGuesses.Location = new System.Drawing.Point(8, 234);
            this.lblNumberOfGuesses.Name = "lblNumberOfGuesses";
            this.lblNumberOfGuesses.Size = new System.Drawing.Size(150, 19);
            this.lblNumberOfGuesses.TabIndex = 13;
            this.lblNumberOfGuesses.Text = "Number of Guesses : ";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SandyBrown;
            this.btnExit.Location = new System.Drawing.Point(466, 313);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 31);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCheck.Location = new System.Drawing.Point(466, 198);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(88, 31);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Check Guess";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SandyBrown;
            this.btnStart.Location = new System.Drawing.Point(466, 104);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 31);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Adewale.TheAdventuresOfSharkeisha.Properties.Resources._4ibzgn5ig;
            this.pictureBox1.Location = new System.Drawing.Point(73, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lblGuess
            // 
            this.lblGuess.BackColor = System.Drawing.Color.White;
            this.lblGuess.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess.Image = global::Adewale.TheAdventuresOfSharkeisha.Properties.Resources.Speech_bubble_svg;
            this.lblGuess.Location = new System.Drawing.Point(91, 13);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(170, 77);
            this.lblGuess.TabIndex = 12;
            this.lblGuess.Text = "Guess The number of Drinks i\'ve had between 1 -10";
            this.lblGuess.Click += new System.EventHandler(this.lblGuess_Click);
            // 
            // picWife
            // 
            this.picWife.Image = global::Adewale.TheAdventuresOfSharkeisha.Properties.Resources.c0f9cb066c563e938dbd0eac768cbdc0;
            this.picWife.Location = new System.Drawing.Point(12, 89);
            this.picWife.Name = "picWife";
            this.picWife.Size = new System.Drawing.Size(69, 56);
            this.picWife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWife.TabIndex = 18;
            this.picWife.TabStop = false;
            // 
            // picPictures
            // 
            this.picPictures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPictures.Location = new System.Drawing.Point(271, 179);
            this.picPictures.Name = "picPictures";
            this.picPictures.Size = new System.Drawing.Size(189, 162);
            this.picPictures.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPictures.TabIndex = 16;
            this.picPictures.TabStop = false;
            // 
            // tmrBackColor
            // 
            this.tmrBackColor.Tick += new System.EventHandler(this.tmrBackColor_Tick);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(158, 234);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(99, 19);
            this.lblCount.TabIndex = 20;
            this.lblCount.Text = "               ";
            // 
            // frmDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(559, 360);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblNumberOfGuesses);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picWife);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.picPictures);
            this.Controls.Add(this.lblRightorWrong);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDrinks";
            this.Text = "How Many Drinks has she had???";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDrinks_FormClosing);
            this.Load += new System.EventHandler(this.frmDrinks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPictures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.PictureBox picPictures;
        private System.Windows.Forms.Label lblRightorWrong;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblNumberOfGuesses;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picWife;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmrBackColor;
        private System.Windows.Forms.Label lblCount;
    }
}