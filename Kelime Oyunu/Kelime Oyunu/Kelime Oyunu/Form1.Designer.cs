using System;

namespace Kelime_Oyunu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHarfLength = new System.Windows.Forms.Label();
            this.lblSoru = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTopPuan = new System.Windows.Forms.Label();
            this.lblKazanPuan = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblKalanSure = new System.Windows.Forms.Label();
            this.lblKelime = new System.Windows.Forms.Label();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHarfAl = new System.Windows.Forms.Button();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.tmrKalanSure = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHarfLength);
            this.groupBox1.Controls.Add(this.lblSoru);
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(541, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kelime Bilgileri";
            // 
            // lblHarfLength
            // 
            this.lblHarfLength.AutoSize = true;
            this.lblHarfLength.Location = new System.Drawing.Point(7, 48);
            this.lblHarfLength.Name = "lblHarfLength";
            this.lblHarfLength.Size = new System.Drawing.Size(148, 16);
            this.lblHarfLength.TabIndex = 1;
            this.lblHarfLength.Text = "Kelime Harf Uzunluğu : -";
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Location = new System.Drawing.Point(7, 21);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(108, 16);
            this.lblSoru.TabIndex = 0;
            this.lblSoru.Text = "Kelime Sorusu : -";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTopPuan);
            this.groupBox2.Controls.Add(this.lblKazanPuan);
            this.groupBox2.Location = new System.Drawing.Point(2, 202);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(541, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Puanlar";
            // 
            // lblTopPuan
            // 
            this.lblTopPuan.AutoSize = true;
            this.lblTopPuan.Location = new System.Drawing.Point(7, 42);
            this.lblTopPuan.Name = "lblTopPuan";
            this.lblTopPuan.Size = new System.Drawing.Size(103, 16);
            this.lblTopPuan.TabIndex = 1;
            this.lblTopPuan.Text = "Toplam Puan : 0";
            // 
            // lblKazanPuan
            // 
            this.lblKazanPuan.AutoSize = true;
            this.lblKazanPuan.Location = new System.Drawing.Point(7, 20);
            this.lblKazanPuan.Name = "lblKazanPuan";
            this.lblKazanPuan.Size = new System.Drawing.Size(124, 16);
            this.lblKazanPuan.TabIndex = 0;
            this.lblKazanPuan.Text = "Kazanılacak Puan : -";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblKalanSure);
            this.groupBox3.Controls.Add(this.lblKelime);
            this.groupBox3.Controls.Add(this.btnTahmin);
            this.groupBox3.Controls.Add(this.txtTahmin);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnHarfAl);
            this.groupBox3.Controls.Add(this.btnYeniOyun);
            this.groupBox3.Location = new System.Drawing.Point(2, 80);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(541, 114);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Oyun";
            // 
            // lblKalanSure
            // 
            this.lblKalanSure.AutoSize = true;
            this.lblKalanSure.Location = new System.Drawing.Point(332, 20);
            this.lblKalanSure.Name = "lblKalanSure";
            this.lblKalanSure.Size = new System.Drawing.Size(88, 16);
            this.lblKalanSure.TabIndex = 3;
            this.lblKalanSure.Text = "Kalan Süre : -";
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelime.Location = new System.Drawing.Point(6, 20);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(37, 48);
            this.lblKelime.TabIndex = 8;
            this.lblKelime.Text = "-";
            // 
            // btnTahmin
            // 
            this.btnTahmin.Enabled = false;
            this.btnTahmin.Location = new System.Drawing.Point(451, 84);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(84, 26);
            this.btnTahmin.TabIndex = 7;
            this.btnTahmin.Text = "Tahmin Et";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // txtTahmin
            // 
            this.txtTahmin.Enabled = false;
            this.txtTahmin.Location = new System.Drawing.Point(335, 86);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(110, 23);
            this.txtTahmin.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tahmin :";
            // 
            // btnHarfAl
            // 
            this.btnHarfAl.Enabled = false;
            this.btnHarfAl.Location = new System.Drawing.Point(145, 83);
            this.btnHarfAl.Name = "btnHarfAl";
            this.btnHarfAl.Size = new System.Drawing.Size(118, 26);
            this.btnHarfAl.TabIndex = 4;
            this.btnHarfAl.Text = "Harf Al";
            this.btnHarfAl.UseVisualStyleBackColor = true;
            this.btnHarfAl.Click += new System.EventHandler(this.btnHarfAl_Click);
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.Location = new System.Drawing.Point(6, 83);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(136, 26);
            this.btnYeniOyun.TabIndex = 3;
            this.btnYeniOyun.Text = "Yeni Oyun Başlat";
            this.btnYeniOyun.UseVisualStyleBackColor = true;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // tmrKalanSure
            // 
            this.tmrKalanSure.Interval = 1000;
            this.tmrKalanSure.Tick += new System.EventHandler(this.tmrKalanSure_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTahmin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 271);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kelime Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Form1_Load(EventArgs e, object sender)
        {
            throw new NotImplementedException();
        }

        private void tmrKalanSure_Tick(EventArgs e, object sender)
        {
            throw new NotImplementedException();
        }

        private void btnYeniOyun_Click(EventArgs e, object sender)
        {
            throw new NotImplementedException();
        }

        private void btnHarfAl_Click(EventArgs e, object sender)
        {
            throw new NotImplementedException();
        }

        private void btnTahmin_Click(EventArgs e, object sender)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHarfLength;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTopPuan;
        private System.Windows.Forms.Label lblKazanPuan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHarfAl;
        private System.Windows.Forms.Button btnYeniOyun;
        private System.Windows.Forms.Timer tmrKalanSure;
        private System.Windows.Forms.Label lblKalanSure;
    }
}

