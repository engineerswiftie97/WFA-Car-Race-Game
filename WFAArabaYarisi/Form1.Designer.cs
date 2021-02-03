namespace WFAArabaYarisi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbFord = new System.Windows.Forms.PictureBox();
            this.pbTaksi = new System.Windows.Forms.PictureBox();
            this.pbFerrari = new System.Windows.Forms.PictureBox();
            this.cmbSecim = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.btnPara = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFinish = new System.Windows.Forms.Label();
            this.lblSpiker = new System.Windows.Forms.Label();
            this.lblKazanılan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFerrari)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(2, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1042, 22);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Magenta;
            this.label2.Location = new System.Drawing.Point(2, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1042, 23);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Magenta;
            this.label3.Location = new System.Drawing.Point(2, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1042, 23);
            this.label3.TabIndex = 2;
            // 
            // pbFord
            // 
            this.pbFord.Image = ((System.Drawing.Image)(resources.GetObject("pbFord.Image")));
            this.pbFord.Location = new System.Drawing.Point(10, 189);
            this.pbFord.Name = "pbFord";
            this.pbFord.Size = new System.Drawing.Size(148, 126);
            this.pbFord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFord.TabIndex = 3;
            this.pbFord.TabStop = false;
            // 
            // pbTaksi
            // 
            this.pbTaksi.Image = ((System.Drawing.Image)(resources.GetObject("pbTaksi.Image")));
            this.pbTaksi.Location = new System.Drawing.Point(5, 356);
            this.pbTaksi.Name = "pbTaksi";
            this.pbTaksi.Size = new System.Drawing.Size(150, 134);
            this.pbTaksi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTaksi.TabIndex = 4;
            this.pbTaksi.TabStop = false;
            // 
            // pbFerrari
            // 
            this.pbFerrari.Image = ((System.Drawing.Image)(resources.GetObject("pbFerrari.Image")));
            this.pbFerrari.Location = new System.Drawing.Point(10, 12);
            this.pbFerrari.Name = "pbFerrari";
            this.pbFerrari.Size = new System.Drawing.Size(148, 130);
            this.pbFerrari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFerrari.TabIndex = 5;
            this.pbFerrari.TabStop = false;
            // 
            // cmbSecim
            // 
            this.cmbSecim.FormattingEnabled = true;
            this.cmbSecim.Location = new System.Drawing.Point(1059, 145);
            this.cmbSecim.Name = "cmbSecim";
            this.cmbSecim.Size = new System.Drawing.Size(121, 24);
            this.cmbSecim.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.Location = new System.Drawing.Point(12, 554);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 89);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Pink;
            this.label5.Location = new System.Drawing.Point(1056, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 67);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kazanacağını düşündüğünüz arabayı seçiniz";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Pink;
            this.label6.Location = new System.Drawing.Point(1056, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 75);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bu arabaya yatıracağınız para miktarını girin";
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(1059, 345);
            this.txtPara.Multiline = true;
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(139, 87);
            this.txtPara.TabIndex = 12;
            this.txtPara.TextChanged += new System.EventHandler(this.txtPara_TextChanged);
            // 
            // btnPara
            // 
            this.btnPara.BackColor = System.Drawing.Color.Green;
            this.btnPara.Location = new System.Drawing.Point(499, 564);
            this.btnPara.Name = "btnPara";
            this.btnPara.Size = new System.Drawing.Size(82, 68);
            this.btnPara.TabIndex = 14;
            this.btnPara.Text = "Kazanılan Toplam Para";
            this.btnPara.UseVisualStyleBackColor = false;
            this.btnPara.Click += new System.EventHandler(this.btnPara_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.Gold;
            this.lblFinish.Location = new System.Drawing.Point(985, 102);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(59, 445);
            this.lblFinish.TabIndex = 15;
            this.lblFinish.Text = "FINISH";
            // 
            // lblSpiker
            // 
            this.lblSpiker.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSpiker.Location = new System.Drawing.Point(694, 584);
            this.lblSpiker.Name = "lblSpiker";
            this.lblSpiker.Size = new System.Drawing.Size(427, 48);
            this.lblSpiker.TabIndex = 16;
            // 
            // lblKazanılan
            // 
            this.lblKazanılan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKazanılan.Location = new System.Drawing.Point(255, 564);
            this.lblKazanılan.Name = "lblKazanılan";
            this.lblKazanılan.Size = new System.Drawing.Size(216, 68);
            this.lblKazanılan.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 655);
            this.Controls.Add(this.lblKazanılan);
            this.Controls.Add(this.lblSpiker);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.btnPara);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbSecim);
            this.Controls.Add(this.pbFerrari);
            this.Controls.Add(this.pbTaksi);
            this.Controls.Add(this.pbFord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFerrari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbFord;
        private System.Windows.Forms.PictureBox pbTaksi;
        private System.Windows.Forms.PictureBox pbFerrari;
        private System.Windows.Forms.ComboBox cmbSecim;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Button btnPara;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label lblSpiker;
        private System.Windows.Forms.Label lblKazanılan;
    }
}

