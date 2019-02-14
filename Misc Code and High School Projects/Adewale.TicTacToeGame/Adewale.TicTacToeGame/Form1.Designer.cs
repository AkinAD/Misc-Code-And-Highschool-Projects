namespace Adewale.TicTacToeGame
{
    partial class frmXandO
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
            this.btnExit = new System.Windows.Forms.Button();
            this.radSmartPC = new System.Windows.Forms.RadioButton();
            this.radDumbPc = new System.Windows.Forms.RadioButton();
            this.grpCompMode = new System.Windows.Forms.GroupBox();
            this.radCompFirstTurn = new System.Windows.Forms.RadioButton();
            this.radPlayerFirstTurn = new System.Windows.Forms.RadioButton();
            this.grpTurns = new System.Windows.Forms.GroupBox();
            this.radOnePlayer = new System.Windows.Forms.RadioButton();
            this.radTwoPlayer = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.grpPlayer = new System.Windows.Forms.GroupBox();
            this.pnlForFun = new System.Windows.Forms.Panel();
            this.lblBox9 = new System.Windows.Forms.Label();
            this.lblBox5 = new System.Windows.Forms.Label();
            this.lblBox6 = new System.Windows.Forms.Label();
            this.lblBox1 = new System.Windows.Forms.Label();
            this.lblBox3 = new System.Windows.Forms.Label();
            this.lblBox2 = new System.Windows.Forms.Label();
            this.lblBox8 = new System.Windows.Forms.Label();
            this.lblBox4 = new System.Windows.Forms.Label();
            this.lblBox7 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tmrBackcolor = new System.Windows.Forms.Timer(this.components);
            this.btnHint = new System.Windows.Forms.Button();
            this.grpWins = new System.Windows.Forms.GroupBox();
            this.lblHintsUsed = new System.Windows.Forms.Label();
            this.lblO = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblForO = new System.Windows.Forms.Label();
            this.lblForX = new System.Windows.Forms.Label();
            this.tmrReset = new System.Windows.Forms.Timer(this.components);
            this.grpCompMode.SuspendLayout();
            this.grpTurns.SuspendLayout();
            this.grpPlayer.SuspendLayout();
            this.pnlForFun.SuspendLayout();
            this.grpWins.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(587, 480);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 48);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Quit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // radSmartPC
            // 
            this.radSmartPC.AutoSize = true;
            this.radSmartPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSmartPC.Location = new System.Drawing.Point(10, 57);
            this.radSmartPC.Name = "radSmartPC";
            this.radSmartPC.Size = new System.Drawing.Size(122, 20);
            this.radSmartPC.TabIndex = 0;
            this.radSmartPC.TabStop = true;
            this.radSmartPC.Text = "Smart Computer";
            this.radSmartPC.UseVisualStyleBackColor = true;
            // 
            // radDumbPc
            // 
            this.radDumbPc.AutoSize = true;
            this.radDumbPc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDumbPc.Location = new System.Drawing.Point(10, 19);
            this.radDumbPc.Name = "radDumbPc";
            this.radDumbPc.Size = new System.Drawing.Size(139, 20);
            this.radDumbPc.TabIndex = 0;
            this.radDumbPc.TabStop = true;
            this.radDumbPc.Text = "Random Computer";
            this.radDumbPc.UseVisualStyleBackColor = true;
            // 
            // grpCompMode
            // 
            this.grpCompMode.Controls.Add(this.radSmartPC);
            this.grpCompMode.Controls.Add(this.radDumbPc);
            this.grpCompMode.Location = new System.Drawing.Point(568, 230);
            this.grpCompMode.Name = "grpCompMode";
            this.grpCompMode.Size = new System.Drawing.Size(200, 100);
            this.grpCompMode.TabIndex = 6;
            this.grpCompMode.TabStop = false;
            // 
            // radCompFirstTurn
            // 
            this.radCompFirstTurn.AutoSize = true;
            this.radCompFirstTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCompFirstTurn.Location = new System.Drawing.Point(19, 64);
            this.radCompFirstTurn.Name = "radCompFirstTurn";
            this.radCompFirstTurn.Size = new System.Drawing.Size(148, 20);
            this.radCompFirstTurn.TabIndex = 0;
            this.radCompFirstTurn.TabStop = true;
            this.radCompFirstTurn.Text = "Computer Goes First";
            this.radCompFirstTurn.UseVisualStyleBackColor = true;
            // 
            // radPlayerFirstTurn
            // 
            this.radPlayerFirstTurn.AutoSize = true;
            this.radPlayerFirstTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPlayerFirstTurn.Location = new System.Drawing.Point(19, 19);
            this.radPlayerFirstTurn.Name = "radPlayerFirstTurn";
            this.radPlayerFirstTurn.Size = new System.Drawing.Size(99, 20);
            this.radPlayerFirstTurn.TabIndex = 0;
            this.radPlayerFirstTurn.TabStop = true;
            this.radPlayerFirstTurn.Text = "You Go First";
            this.radPlayerFirstTurn.UseVisualStyleBackColor = true;
            // 
            // grpTurns
            // 
            this.grpTurns.Controls.Add(this.radCompFirstTurn);
            this.grpTurns.Controls.Add(this.radPlayerFirstTurn);
            this.grpTurns.Location = new System.Drawing.Point(568, 124);
            this.grpTurns.Name = "grpTurns";
            this.grpTurns.Size = new System.Drawing.Size(200, 100);
            this.grpTurns.TabIndex = 7;
            this.grpTurns.TabStop = false;
            // 
            // radOnePlayer
            // 
            this.radOnePlayer.AutoSize = true;
            this.radOnePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOnePlayer.Location = new System.Drawing.Point(19, 62);
            this.radOnePlayer.Name = "radOnePlayer";
            this.radOnePlayer.Size = new System.Drawing.Size(144, 20);
            this.radOnePlayer.TabIndex = 0;
            this.radOnePlayer.TabStop = true;
            this.radOnePlayer.Text = "Single Player Mode";
            this.radOnePlayer.UseVisualStyleBackColor = true;
            this.radOnePlayer.CheckedChanged += new System.EventHandler(this.radOnePlayer_CheckedChanged);
            // 
            // radTwoPlayer
            // 
            this.radTwoPlayer.AutoSize = true;
            this.radTwoPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTwoPlayer.Location = new System.Drawing.Point(19, 19);
            this.radTwoPlayer.Name = "radTwoPlayer";
            this.radTwoPlayer.Size = new System.Drawing.Size(132, 20);
            this.radTwoPlayer.TabIndex = 0;
            this.radTwoPlayer.TabStop = true;
            this.radTwoPlayer.Text = "Two Player Mode";
            this.radTwoPlayer.UseVisualStyleBackColor = true;
            this.radTwoPlayer.CheckedChanged += new System.EventHandler(this.radTwoPlayer_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(587, 426);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(147, 48);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpPlayer
            // 
            this.grpPlayer.Controls.Add(this.radOnePlayer);
            this.grpPlayer.Controls.Add(this.radTwoPlayer);
            this.grpPlayer.Location = new System.Drawing.Point(568, 18);
            this.grpPlayer.Name = "grpPlayer";
            this.grpPlayer.Size = new System.Drawing.Size(200, 100);
            this.grpPlayer.TabIndex = 8;
            this.grpPlayer.TabStop = false;
            // 
            // pnlForFun
            // 
            this.pnlForFun.Controls.Add(this.lblBox9);
            this.pnlForFun.Controls.Add(this.lblBox5);
            this.pnlForFun.Controls.Add(this.lblBox6);
            this.pnlForFun.Controls.Add(this.lblBox1);
            this.pnlForFun.Controls.Add(this.lblBox3);
            this.pnlForFun.Controls.Add(this.lblBox2);
            this.pnlForFun.Controls.Add(this.lblBox8);
            this.pnlForFun.Controls.Add(this.lblBox4);
            this.pnlForFun.Controls.Add(this.lblBox7);
            this.pnlForFun.Location = new System.Drawing.Point(16, 89);
            this.pnlForFun.Name = "pnlForFun";
            this.pnlForFun.Size = new System.Drawing.Size(524, 501);
            this.pnlForFun.TabIndex = 5;
            // 
            // lblBox9
            // 
            this.lblBox9.BackColor = System.Drawing.SystemColors.Control;
            this.lblBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBox9.ForeColor = System.Drawing.Color.White;
            this.lblBox9.Location = new System.Drawing.Point(329, 352);
            this.lblBox9.Name = "lblBox9";
            this.lblBox9.Size = new System.Drawing.Size(130, 130);
            this.lblBox9.TabIndex = 0;
            this.lblBox9.Click += new System.EventHandler(this.lblBox_Click);
            // 
            // lblBox5
            // 
            this.lblBox5.BackColor = System.Drawing.SystemColors.Control;
            this.lblBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBox5.ForeColor = System.Drawing.Color.White;
            this.lblBox5.Location = new System.Drawing.Point(180, 189);
            this.lblBox5.Name = "lblBox5";
            this.lblBox5.Size = new System.Drawing.Size(130, 130);
            this.lblBox5.TabIndex = 0;
            this.lblBox5.Click += new System.EventHandler(this.lblBox_Click);
            // 
            // lblBox6
            // 
            this.lblBox6.BackColor = System.Drawing.SystemColors.Control;
            this.lblBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBox6.ForeColor = System.Drawing.Color.White;
            this.lblBox6.Location = new System.Drawing.Point(329, 189);
            this.lblBox6.Name = "lblBox6";
            this.lblBox6.Size = new System.Drawing.Size(130, 130);
            this.lblBox6.TabIndex = 0;
            this.lblBox6.Click += new System.EventHandler(this.lblBox_Click);
            // 
            // lblBox1
            // 
            this.lblBox1.BackColor = System.Drawing.SystemColors.Control;
            this.lblBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBox1.ForeColor = System.Drawing.Color.White;
            this.lblBox1.Location = new System.Drawing.Point(30, 30);
            this.lblBox1.Name = "lblBox1";
            this.lblBox1.Size = new System.Drawing.Size(130, 130);
            this.lblBox1.TabIndex = 0;
            this.lblBox1.Click += new System.EventHandler(this.lblBox_Click);
            // 
            // lblBox3
            // 
            this.lblBox3.BackColor = System.Drawing.SystemColors.Control;
            this.lblBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBox3.ForeColor = System.Drawing.Color.White;
            this.lblBox3.Location = new System.Drawing.Point(329, 30);
            this.lblBox3.Name = "lblBox3";
            this.lblBox3.Size = new System.Drawing.Size(130, 130);
            this.lblBox3.TabIndex = 0;
            this.lblBox3.Click += new System.EventHandler(this.lblBox_Click);
            // 
            // lblBox2
            // 
            this.lblBox2.BackColor = System.Drawing.SystemColors.Control;
            this.lblBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBox2.ForeColor = System.Drawing.Color.White;
            this.lblBox2.Location = new System.Drawing.Point(180, 30);
            this.lblBox2.Name = "lblBox2";
            this.lblBox2.Size = new System.Drawing.Size(130, 130);
            this.lblBox2.TabIndex = 0;
            this.lblBox2.Click += new System.EventHandler(this.lblBox_Click);
            // 
            // lblBox8
            // 
            this.lblBox8.BackColor = System.Drawing.SystemColors.Control;
            this.lblBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBox8.ForeColor = System.Drawing.Color.White;
            this.lblBox8.Location = new System.Drawing.Point(180, 352);
            this.lblBox8.Name = "lblBox8";
            this.lblBox8.Size = new System.Drawing.Size(130, 130);
            this.lblBox8.TabIndex = 0;
            this.lblBox8.Click += new System.EventHandler(this.lblBox_Click);
            // 
            // lblBox4
            // 
            this.lblBox4.BackColor = System.Drawing.SystemColors.Control;
            this.lblBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBox4.ForeColor = System.Drawing.Color.White;
            this.lblBox4.Location = new System.Drawing.Point(30, 189);
            this.lblBox4.Name = "lblBox4";
            this.lblBox4.Size = new System.Drawing.Size(130, 130);
            this.lblBox4.TabIndex = 0;
            this.lblBox4.Click += new System.EventHandler(this.lblBox_Click);
            // 
            // lblBox7
            // 
            this.lblBox7.BackColor = System.Drawing.SystemColors.Control;
            this.lblBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBox7.ForeColor = System.Drawing.Color.White;
            this.lblBox7.Location = new System.Drawing.Point(31, 352);
            this.lblBox7.Name = "lblBox7";
            this.lblBox7.Size = new System.Drawing.Size(130, 130);
            this.lblBox7.TabIndex = 0;
            this.lblBox7.Click += new System.EventHandler(this.lblBox_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMessage.Location = new System.Drawing.Point(46, 18);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(426, 63);
            this.lblMessage.TabIndex = 4;
            // 
            // tmrBackcolor
            // 
            this.tmrBackcolor.Interval = 40;
            this.tmrBackcolor.Tick += new System.EventHandler(this.tmrBackcolor_Tick);
            // 
            // btnHint
            // 
            this.btnHint.Location = new System.Drawing.Point(587, 534);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(147, 48);
            this.btnHint.TabIndex = 10;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // grpWins
            // 
            this.grpWins.Controls.Add(this.lblHintsUsed);
            this.grpWins.Controls.Add(this.lblO);
            this.grpWins.Controls.Add(this.lblX);
            this.grpWins.Controls.Add(this.lblHint);
            this.grpWins.Controls.Add(this.lblForO);
            this.grpWins.Controls.Add(this.lblForX);
            this.grpWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpWins.Location = new System.Drawing.Point(568, 337);
            this.grpWins.Name = "grpWins";
            this.grpWins.Size = new System.Drawing.Size(200, 83);
            this.grpWins.TabIndex = 11;
            this.grpWins.TabStop = false;
            this.grpWins.Text = "Wins";
            // 
            // lblHintsUsed
            // 
            this.lblHintsUsed.AutoSize = true;
            this.lblHintsUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHintsUsed.Location = new System.Drawing.Point(90, 55);
            this.lblHintsUsed.Name = "lblHintsUsed";
            this.lblHintsUsed.Size = new System.Drawing.Size(15, 16);
            this.lblHintsUsed.TabIndex = 3;
            this.lblHintsUsed.Text = "2";
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblO.Location = new System.Drawing.Point(41, 39);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(15, 16);
            this.lblO.TabIndex = 3;
            this.lblO.Text = "0";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(41, 18);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(15, 16);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "0";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.Location = new System.Drawing.Point(10, 55);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(62, 16);
            this.lblHint.TabIndex = 1;
            this.lblHint.Text = "Hints Left";
            // 
            // lblForO
            // 
            this.lblForO.AutoSize = true;
            this.lblForO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForO.Location = new System.Drawing.Point(10, 39);
            this.lblForO.Name = "lblForO";
            this.lblForO.Size = new System.Drawing.Size(27, 16);
            this.lblForO.TabIndex = 1;
            this.lblForO.Text = "O : ";
            // 
            // lblForX
            // 
            this.lblForX.AutoSize = true;
            this.lblForX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForX.Location = new System.Drawing.Point(10, 20);
            this.lblForX.Name = "lblForX";
            this.lblForX.Size = new System.Drawing.Size(25, 16);
            this.lblForX.TabIndex = 0;
            this.lblForX.Text = "X : ";
            // 
            // tmrReset
            // 
            this.tmrReset.Tick += new System.EventHandler(this.tmrReset_Tick);
            // 
            // frmXandO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(785, 608);
            this.Controls.Add(this.grpWins);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpCompMode);
            this.Controls.Add(this.grpTurns);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpPlayer);
            this.Controls.Add(this.pnlForFun);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmXandO";
            this.Text = "Tic Tac Toe ";
            this.Load += new System.EventHandler(this.frmXandO_Load);
            this.grpCompMode.ResumeLayout(false);
            this.grpCompMode.PerformLayout();
            this.grpTurns.ResumeLayout(false);
            this.grpTurns.PerformLayout();
            this.grpPlayer.ResumeLayout(false);
            this.grpPlayer.PerformLayout();
            this.pnlForFun.ResumeLayout(false);
            this.grpWins.ResumeLayout(false);
            this.grpWins.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.RadioButton radSmartPC;
        internal System.Windows.Forms.RadioButton radDumbPc;
        internal System.Windows.Forms.GroupBox grpCompMode;
        internal System.Windows.Forms.RadioButton radCompFirstTurn;
        internal System.Windows.Forms.RadioButton radPlayerFirstTurn;
        internal System.Windows.Forms.GroupBox grpTurns;
        internal System.Windows.Forms.RadioButton radOnePlayer;
        internal System.Windows.Forms.RadioButton radTwoPlayer;
        internal System.Windows.Forms.Button btnStart;
        internal System.Windows.Forms.GroupBox grpPlayer;
        internal System.Windows.Forms.Panel pnlForFun;
        internal System.Windows.Forms.Label lblBox9;
        internal System.Windows.Forms.Label lblBox5;
        internal System.Windows.Forms.Label lblBox6;
        internal System.Windows.Forms.Label lblBox1;
        internal System.Windows.Forms.Label lblBox3;
        internal System.Windows.Forms.Label lblBox2;
        internal System.Windows.Forms.Label lblBox8;
        internal System.Windows.Forms.Label lblBox4;
        internal System.Windows.Forms.Label lblBox7;
        internal System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer tmrBackcolor;
        internal System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.GroupBox grpWins;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblForO;
        private System.Windows.Forms.Label lblForX;
        private System.Windows.Forms.Timer tmrReset;
        private System.Windows.Forms.Label lblHintsUsed;
        private System.Windows.Forms.Label lblHint;
    }
}

