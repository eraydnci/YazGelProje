namespace Kelime_Oyunu
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.oyuncuAd = new System.Windows.Forms.TextBox();
            this.baslaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oyuncuAd
            // 
            this.oyuncuAd.Location = new System.Drawing.Point(120, 132);
            this.oyuncuAd.Name = "oyuncuAd";
            this.oyuncuAd.Size = new System.Drawing.Size(145, 20);
            this.oyuncuAd.TabIndex = 0;
            // 
            // baslaBtn
            // 
            this.baslaBtn.Location = new System.Drawing.Point(151, 158);
            this.baslaBtn.Name = "baslaBtn";
            this.baslaBtn.Size = new System.Drawing.Size(75, 23);
            this.baslaBtn.TabIndex = 1;
            this.baslaBtn.Text = "Oyuna Başla";
            this.baslaBtn.UseVisualStyleBackColor = true;
            this.baslaBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Oyuncu Adı Giriniz : ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(589, 246);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baslaBtn);
            this.Controls.Add(this.oyuncuAd);
            this.Name = "Form2";
            this.Text = "Kelime Oyunu Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oyuncuAd;
        private System.Windows.Forms.Button baslaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}