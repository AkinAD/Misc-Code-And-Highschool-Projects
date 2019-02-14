namespace PizzaDelivery
{
    partial class frmPizzaDelivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPizzaDelivery));
            this.grpCar = new System.Windows.Forms.GroupBox();
            this.btnLoadCar = new System.Windows.Forms.Button();
            this.lblInCar = new System.Windows.Forms.Label();
            this.grpPizzas = new System.Windows.Forms.GroupBox();
            this.lblPizzasReady = new System.Windows.Forms.Label();
            this.btnBakePizza = new System.Windows.Forms.Button();
            this.btnAddPizza = new System.Windows.Forms.Button();
            this.picPizza8 = new System.Windows.Forms.PictureBox();
            this.picPizza4 = new System.Windows.Forms.PictureBox();
            this.picPizza7 = new System.Windows.Forms.PictureBox();
            this.picPizza3 = new System.Windows.Forms.PictureBox();
            this.btnExitStop = new System.Windows.Forms.Button();
            this.btnStartPause = new System.Windows.Forms.Button();
            this.picVCar = new System.Windows.Forms.PictureBox();
            this.picHCar = new System.Windows.Forms.PictureBox();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.tmrPhone = new System.Windows.Forms.Timer(this.components);
            this.tmrCar = new System.Windows.Forms.Timer(this.components);
            this.picPizza6 = new System.Windows.Forms.PictureBox();
            this.picPizza5 = new System.Windows.Forms.PictureBox();
            this.picPizza2 = new System.Windows.Forms.PictureBox();
            this.tmrOven = new System.Windows.Forms.Timer(this.components);
            this.grpOven = new System.Windows.Forms.GroupBox();
            this.picPizza1 = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.picOrders = new System.Windows.Forms.PictureBox();
            this.lblSales = new System.Windows.Forms.Label();
            this.grpSales = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.grpTime = new System.Windows.Forms.GroupBox();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.grpCar.SuspendLayout();
            this.grpPizzas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza2)).BeginInit();
            this.grpOven.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrders)).BeginInit();
            this.grpSales.SuspendLayout();
            this.grpTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCar
            // 
            this.grpCar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpCar.Controls.Add(this.btnLoadCar);
            this.grpCar.Controls.Add(this.lblInCar);
            this.grpCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCar.ForeColor = System.Drawing.Color.Yellow;
            this.grpCar.Location = new System.Drawing.Point(603, 415);
            this.grpCar.Name = "grpCar";
            this.grpCar.Size = new System.Drawing.Size(138, 50);
            this.grpCar.TabIndex = 17;
            this.grpCar.TabStop = false;
            this.grpCar.Text = "Pizzas In Car";
            // 
            // btnLoadCar
            // 
            this.btnLoadCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadCar.ForeColor = System.Drawing.Color.Black;
            this.btnLoadCar.Location = new System.Drawing.Point(80, 20);
            this.btnLoadCar.Name = "btnLoadCar";
            this.btnLoadCar.Size = new System.Drawing.Size(50, 25);
            this.btnLoadCar.TabIndex = 10;
            this.btnLoadCar.Text = "Load";
            this.btnLoadCar.UseVisualStyleBackColor = true;
            this.btnLoadCar.Click += new System.EventHandler(this.btnLoadCar_Click);
            // 
            // lblInCar
            // 
            this.lblInCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInCar.ForeColor = System.Drawing.Color.White;
            this.lblInCar.Location = new System.Drawing.Point(10, 18);
            this.lblInCar.Name = "lblInCar";
            this.lblInCar.Size = new System.Drawing.Size(68, 23);
            this.lblInCar.TabIndex = 0;
            this.lblInCar.Text = "0";
            this.lblInCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpPizzas
            // 
            this.grpPizzas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpPizzas.Controls.Add(this.lblPizzasReady);
            this.grpPizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPizzas.ForeColor = System.Drawing.Color.Yellow;
            this.grpPizzas.Location = new System.Drawing.Point(518, 415);
            this.grpPizzas.Name = "grpPizzas";
            this.grpPizzas.Size = new System.Drawing.Size(79, 50);
            this.grpPizzas.TabIndex = 22;
            this.grpPizzas.TabStop = false;
            this.grpPizzas.Text = "Baked";
            // 
            // lblPizzasReady
            // 
            this.lblPizzasReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzasReady.ForeColor = System.Drawing.Color.White;
            this.lblPizzasReady.Location = new System.Drawing.Point(9, 18);
            this.lblPizzasReady.Name = "lblPizzasReady";
            this.lblPizzasReady.Size = new System.Drawing.Size(64, 23);
            this.lblPizzasReady.TabIndex = 0;
            this.lblPizzasReady.Text = "0";
            this.lblPizzasReady.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBakePizza
            // 
            this.btnBakePizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBakePizza.ForeColor = System.Drawing.Color.Black;
            this.btnBakePizza.Location = new System.Drawing.Point(118, 131);
            this.btnBakePizza.Name = "btnBakePizza";
            this.btnBakePizza.Size = new System.Drawing.Size(101, 25);
            this.btnBakePizza.TabIndex = 9;
            this.btnBakePizza.Text = "Bake Pizza";
            this.btnBakePizza.UseVisualStyleBackColor = true;
            this.btnBakePizza.Click += new System.EventHandler(this.btnBakePizza_Click);
            // 
            // btnAddPizza
            // 
            this.btnAddPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPizza.ForeColor = System.Drawing.Color.Black;
            this.btnAddPizza.Location = new System.Drawing.Point(4, 131);
            this.btnAddPizza.Name = "btnAddPizza";
            this.btnAddPizza.Size = new System.Drawing.Size(101, 25);
            this.btnAddPizza.TabIndex = 8;
            this.btnAddPizza.Text = "Add Pizza";
            this.btnAddPizza.UseVisualStyleBackColor = true;
            this.btnAddPizza.Click += new System.EventHandler(this.btnAddPizza_Click);
            // 
            // picPizza8
            // 
            this.picPizza8.Image = ((System.Drawing.Image)(resources.GetObject("picPizza8.Image")));
            this.picPizza8.Location = new System.Drawing.Point(165, 75);
            this.picPizza8.Name = "picPizza8";
            this.picPizza8.Size = new System.Drawing.Size(50, 50);
            this.picPizza8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPizza8.TabIndex = 7;
            this.picPizza8.TabStop = false;
            this.picPizza8.Visible = false;
            // 
            // picPizza4
            // 
            this.picPizza4.Image = ((System.Drawing.Image)(resources.GetObject("picPizza4.Image")));
            this.picPizza4.Location = new System.Drawing.Point(165, 19);
            this.picPizza4.Name = "picPizza4";
            this.picPizza4.Size = new System.Drawing.Size(50, 50);
            this.picPizza4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPizza4.TabIndex = 6;
            this.picPizza4.TabStop = false;
            this.picPizza4.Visible = false;
            // 
            // picPizza7
            // 
            this.picPizza7.Image = ((System.Drawing.Image)(resources.GetObject("picPizza7.Image")));
            this.picPizza7.Location = new System.Drawing.Point(113, 75);
            this.picPizza7.Name = "picPizza7";
            this.picPizza7.Size = new System.Drawing.Size(50, 50);
            this.picPizza7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPizza7.TabIndex = 5;
            this.picPizza7.TabStop = false;
            this.picPizza7.Visible = false;
            // 
            // picPizza3
            // 
            this.picPizza3.Image = ((System.Drawing.Image)(resources.GetObject("picPizza3.Image")));
            this.picPizza3.Location = new System.Drawing.Point(113, 19);
            this.picPizza3.Name = "picPizza3";
            this.picPizza3.Size = new System.Drawing.Size(50, 50);
            this.picPizza3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPizza3.TabIndex = 4;
            this.picPizza3.TabStop = false;
            this.picPizza3.Visible = false;
            // 
            // btnExitStop
            // 
            this.btnExitStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitStop.Location = new System.Drawing.Point(631, 471);
            this.btnExitStop.Name = "btnExitStop";
            this.btnExitStop.Size = new System.Drawing.Size(110, 29);
            this.btnExitStop.TabIndex = 24;
            this.btnExitStop.Text = "Exit";
            this.btnExitStop.UseVisualStyleBackColor = true;
            this.btnExitStop.Click += new System.EventHandler(this.btnExitStop_Click);
            // 
            // btnStartPause
            // 
            this.btnStartPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartPause.Location = new System.Drawing.Point(518, 471);
            this.btnStartPause.Name = "btnStartPause";
            this.btnStartPause.Size = new System.Drawing.Size(110, 29);
            this.btnStartPause.TabIndex = 23;
            this.btnStartPause.Text = "Start Game";
            this.btnStartPause.UseVisualStyleBackColor = true;
            this.btnStartPause.Click += new System.EventHandler(this.btnStartPause_Click);
            // 
            // picVCar
            // 
            this.picVCar.Image = ((System.Drawing.Image)(resources.GetObject("picVCar.Image")));
            this.picVCar.Location = new System.Drawing.Point(578, 506);
            this.picVCar.Name = "picVCar";
            this.picVCar.Size = new System.Drawing.Size(34, 30);
            this.picVCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVCar.TabIndex = 26;
            this.picVCar.TabStop = false;
            this.picVCar.Visible = false;
            // 
            // picHCar
            // 
            this.picHCar.Image = ((System.Drawing.Image)(resources.GetObject("picHCar.Image")));
            this.picHCar.Location = new System.Drawing.Point(532, 507);
            this.picHCar.Name = "picHCar";
            this.picHCar.Size = new System.Drawing.Size(34, 30);
            this.picHCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHCar.TabIndex = 25;
            this.picHCar.TabStop = false;
            this.picHCar.Visible = false;
            // 
            // tmrClock
            // 
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // tmrPhone
            // 
            this.tmrPhone.Tick += new System.EventHandler(this.tmrPhone_Tick);
            // 
            // tmrCar
            // 
            this.tmrCar.Tick += new System.EventHandler(this.tmrCar_Tick);
            // 
            // picPizza6
            // 
            this.picPizza6.Image = ((System.Drawing.Image)(resources.GetObject("picPizza6.Image")));
            this.picPizza6.Location = new System.Drawing.Point(60, 75);
            this.picPizza6.Name = "picPizza6";
            this.picPizza6.Size = new System.Drawing.Size(50, 50);
            this.picPizza6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPizza6.TabIndex = 3;
            this.picPizza6.TabStop = false;
            this.picPizza6.Visible = false;
            // 
            // picPizza5
            // 
            this.picPizza5.Image = ((System.Drawing.Image)(resources.GetObject("picPizza5.Image")));
            this.picPizza5.Location = new System.Drawing.Point(6, 75);
            this.picPizza5.Name = "picPizza5";
            this.picPizza5.Size = new System.Drawing.Size(50, 50);
            this.picPizza5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPizza5.TabIndex = 2;
            this.picPizza5.TabStop = false;
            this.picPizza5.Visible = false;
            // 
            // picPizza2
            // 
            this.picPizza2.Image = ((System.Drawing.Image)(resources.GetObject("picPizza2.Image")));
            this.picPizza2.Location = new System.Drawing.Point(60, 19);
            this.picPizza2.Name = "picPizza2";
            this.picPizza2.Size = new System.Drawing.Size(50, 50);
            this.picPizza2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPizza2.TabIndex = 1;
            this.picPizza2.TabStop = false;
            this.picPizza2.Visible = false;
            // 
            // tmrOven
            // 
            this.tmrOven.Tick += new System.EventHandler(this.tmrOven_Tick);
            // 
            // grpOven
            // 
            this.grpOven.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpOven.Controls.Add(this.btnBakePizza);
            this.grpOven.Controls.Add(this.btnAddPizza);
            this.grpOven.Controls.Add(this.picPizza8);
            this.grpOven.Controls.Add(this.picPizza4);
            this.grpOven.Controls.Add(this.picPizza7);
            this.grpOven.Controls.Add(this.picPizza3);
            this.grpOven.Controls.Add(this.picPizza6);
            this.grpOven.Controls.Add(this.picPizza5);
            this.grpOven.Controls.Add(this.picPizza2);
            this.grpOven.Controls.Add(this.picPizza1);
            this.grpOven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOven.ForeColor = System.Drawing.Color.Yellow;
            this.grpOven.Location = new System.Drawing.Point(518, 247);
            this.grpOven.Name = "grpOven";
            this.grpOven.Size = new System.Drawing.Size(223, 162);
            this.grpOven.TabIndex = 21;
            this.grpOven.TabStop = false;
            this.grpOven.Text = "Oven Off";
            // 
            // picPizza1
            // 
            this.picPizza1.Image = ((System.Drawing.Image)(resources.GetObject("picPizza1.Image")));
            this.picPizza1.Location = new System.Drawing.Point(6, 19);
            this.picPizza1.Name = "picPizza1";
            this.picPizza1.Size = new System.Drawing.Size(50, 50);
            this.picPizza1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPizza1.TabIndex = 0;
            this.picPizza1.TabStop = false;
            this.picPizza1.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(536, 153);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(189, 50);
            this.lblMessage.TabIndex = 20;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstOrders
            // 
            this.lstOrders.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 17;
            this.lstOrders.Location = new System.Drawing.Point(536, 81);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(189, 72);
            this.lstOrders.TabIndex = 19;
            // 
            // picOrders
            // 
            this.picOrders.Image = ((System.Drawing.Image)(resources.GetObject("picOrders.Image")));
            this.picOrders.Location = new System.Drawing.Point(518, 68);
            this.picOrders.Name = "picOrders";
            this.picOrders.Size = new System.Drawing.Size(223, 173);
            this.picOrders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOrders.TabIndex = 18;
            this.picOrders.TabStop = false;
            // 
            // lblSales
            // 
            this.lblSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.ForeColor = System.Drawing.Color.White;
            this.lblSales.Location = new System.Drawing.Point(6, 18);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(93, 23);
            this.lblSales.TabIndex = 0;
            this.lblSales.Text = "$0.00";
            this.lblSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpSales
            // 
            this.grpSales.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpSales.Controls.Add(this.lblSales);
            this.grpSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSales.ForeColor = System.Drawing.Color.Yellow;
            this.grpSales.Location = new System.Drawing.Point(636, 12);
            this.grpSales.Name = "grpSales";
            this.grpSales.Size = new System.Drawing.Size(105, 50);
            this.grpSales.TabIndex = 16;
            this.grpSales.TabStop = false;
            this.grpSales.Text = "Sales";
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(19, 17);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(73, 25);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "6: 00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpTime
            // 
            this.grpTime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpTime.Controls.Add(this.lblTime);
            this.grpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTime.ForeColor = System.Drawing.Color.Yellow;
            this.grpTime.Location = new System.Drawing.Point(518, 12);
            this.grpTime.Name = "grpTime";
            this.grpTime.Size = new System.Drawing.Size(105, 50);
            this.grpTime.TabIndex = 15;
            this.grpTime.TabStop = false;
            this.grpTime.Text = "Time";
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.LightGray;
            this.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGrid.Location = new System.Drawing.Point(10, 29);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(500, 500);
            this.pnlGrid.TabIndex = 14;
            // 
            // frmPizzaDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(755, 549);
            this.Controls.Add(this.grpCar);
            this.Controls.Add(this.grpPizzas);
            this.Controls.Add(this.btnExitStop);
            this.Controls.Add(this.btnStartPause);
            this.Controls.Add(this.picVCar);
            this.Controls.Add(this.picHCar);
            this.Controls.Add(this.grpOven);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lstOrders);
            this.Controls.Add(this.picOrders);
            this.Controls.Add(this.grpSales);
            this.Controls.Add(this.grpTime);
            this.Controls.Add(this.pnlGrid);
            this.Name = "frmPizzaDelivery";
            this.Text = "Pizza Delivery";
            this.Load += new System.EventHandler(this.frmPizzaDelivery_Load);
            this.grpCar.ResumeLayout(false);
            this.grpPizzas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPizza8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza2)).EndInit();
            this.grpOven.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPizza1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrders)).EndInit();
            this.grpSales.ResumeLayout(false);
            this.grpTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCar;
        private System.Windows.Forms.Button btnLoadCar;
        private System.Windows.Forms.Label lblInCar;
        private System.Windows.Forms.GroupBox grpPizzas;
        private System.Windows.Forms.Label lblPizzasReady;
        private System.Windows.Forms.Button btnBakePizza;
        private System.Windows.Forms.Button btnAddPizza;
        private System.Windows.Forms.PictureBox picPizza8;
        private System.Windows.Forms.PictureBox picPizza4;
        private System.Windows.Forms.PictureBox picPizza7;
        private System.Windows.Forms.PictureBox picPizza3;
        private System.Windows.Forms.Button btnExitStop;
        private System.Windows.Forms.Button btnStartPause;
        private System.Windows.Forms.PictureBox picVCar;
        private System.Windows.Forms.PictureBox picHCar;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Timer tmrPhone;
        private System.Windows.Forms.Timer tmrCar;
        private System.Windows.Forms.PictureBox picPizza6;
        private System.Windows.Forms.PictureBox picPizza5;
        private System.Windows.Forms.PictureBox picPizza2;
        private System.Windows.Forms.Timer tmrOven;
        private System.Windows.Forms.GroupBox grpOven;
        private System.Windows.Forms.PictureBox picPizza1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.PictureBox picOrders;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.GroupBox grpSales;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox grpTime;
        private System.Windows.Forms.Panel pnlGrid;
    }
}

