namespace KumbaraProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInserted = new System.Windows.Forms.Label();
            this.btnOneLira = new System.Windows.Forms.Button();
            this.btnFiveLira = new System.Windows.Forms.Button();
            this.btnTenLira = new System.Windows.Forms.Button();
            this.btnZeroFifty = new System.Windows.Forms.Button();
            this.btnHowToUse = new System.Windows.Forms.Button();
            this.btnBreak = new System.Windows.Forms.Button();
            this.btnRepair = new System.Windows.Forms.Button();
            this.lstSonuc = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInserted);
            this.groupBox1.Controls.Add(this.btnOneLira);
            this.groupBox1.Controls.Add(this.btnFiveLira);
            this.groupBox1.Controls.Add(this.btnTenLira);
            this.groupBox1.Controls.Add(this.btnZeroFifty);
            this.groupBox1.Location = new System.Drawing.Point(396, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Para At";
            // 
            // lblInserted
            // 
            this.lblInserted.AutoSize = true;
            this.lblInserted.Location = new System.Drawing.Point(6, 69);
            this.lblInserted.Name = "lblInserted";
            this.lblInserted.Size = new System.Drawing.Size(35, 13);
            this.lblInserted.TabIndex = 3;
            this.lblInserted.Text = "label1";
            // 
            // btnOneLira
            // 
            this.btnOneLira.Location = new System.Drawing.Point(87, 30);
            this.btnOneLira.Name = "btnOneLira";
            this.btnOneLira.Size = new System.Drawing.Size(75, 23);
            this.btnOneLira.TabIndex = 3;
            this.btnOneLira.Text = "1 TL";
            this.btnOneLira.UseVisualStyleBackColor = true;
            this.btnOneLira.Click += new System.EventHandler(this.btnOneLira_Click);
            // 
            // btnFiveLira
            // 
            this.btnFiveLira.Location = new System.Drawing.Point(168, 30);
            this.btnFiveLira.Name = "btnFiveLira";
            this.btnFiveLira.Size = new System.Drawing.Size(75, 23);
            this.btnFiveLira.TabIndex = 2;
            this.btnFiveLira.Text = "5 TL";
            this.btnFiveLira.UseVisualStyleBackColor = true;
            this.btnFiveLira.Click += new System.EventHandler(this.btnFiveLira_Click);
            // 
            // btnTenLira
            // 
            this.btnTenLira.Location = new System.Drawing.Point(249, 30);
            this.btnTenLira.Name = "btnTenLira";
            this.btnTenLira.Size = new System.Drawing.Size(75, 23);
            this.btnTenLira.TabIndex = 1;
            this.btnTenLira.Text = "10 TL";
            this.btnTenLira.UseVisualStyleBackColor = true;
            this.btnTenLira.Click += new System.EventHandler(this.btnTenLira_Click);
            // 
            // btnZeroFifty
            // 
            this.btnZeroFifty.Location = new System.Drawing.Point(6, 30);
            this.btnZeroFifty.Name = "btnZeroFifty";
            this.btnZeroFifty.Size = new System.Drawing.Size(75, 23);
            this.btnZeroFifty.TabIndex = 0;
            this.btnZeroFifty.Text = "50 krş";
            this.btnZeroFifty.UseVisualStyleBackColor = true;
            this.btnZeroFifty.Click += new System.EventHandler(this.btnZeroFifty_Click);
            // 
            // btnHowToUse
            // 
            this.btnHowToUse.Location = new System.Drawing.Point(12, 342);
            this.btnHowToUse.Name = "btnHowToUse";
            this.btnHowToUse.Size = new System.Drawing.Size(121, 29);
            this.btnHowToUse.TabIndex = 2;
            this.btnHowToUse.Text = "Nasıl Kullanılır?";
            this.btnHowToUse.UseVisualStyleBackColor = true;
            this.btnHowToUse.Click += new System.EventHandler(this.btnHowToUse_Click);
            // 
            // btnBreak
            // 
            this.btnBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBreak.Location = new System.Drawing.Point(396, 121);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(333, 60);
            this.btnBreak.TabIndex = 3;
            this.btnBreak.Text = "Kumbarayı Kır";
            this.btnBreak.UseVisualStyleBackColor = true;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // btnRepair
            // 
            this.btnRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRepair.Location = new System.Drawing.Point(396, 187);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(333, 60);
            this.btnRepair.TabIndex = 4;
            this.btnRepair.Text = "Kumbarayı Yapıştır";
            this.btnRepair.UseVisualStyleBackColor = true;
            this.btnRepair.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // lstSonuc
            // 
            this.lstSonuc.FormattingEnabled = true;
            this.lstSonuc.Location = new System.Drawing.Point(396, 253);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(333, 121);
            this.lstSonuc.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kumbarayı Salla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 384);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstSonuc);
            this.Controls.Add(this.btnRepair);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.btnHowToUse);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Kumbara";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOneLira;
        private System.Windows.Forms.Button btnFiveLira;
        private System.Windows.Forms.Button btnTenLira;
        private System.Windows.Forms.Button btnZeroFifty;
        private System.Windows.Forms.Button btnHowToUse;
        private System.Windows.Forms.Label lblInserted;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Button btnRepair;
        private System.Windows.Forms.ListBox lstSonuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

