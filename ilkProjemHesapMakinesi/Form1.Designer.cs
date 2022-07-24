
namespace ilkProjemHesapMakinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.inte = new System.Windows.Forms.GroupBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblS2 = new System.Windows.Forms.Label();
            this.lblS1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTopla = new System.Windows.Forms.Button();
            this.inte.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // inte
            // 
            this.inte.Controls.Add(this.txt2);
            this.inte.Controls.Add(this.txt1);
            this.inte.Controls.Add(this.lblSonuc);
            this.inte.Controls.Add(this.label1);
            this.inte.Controls.Add(this.lblS2);
            this.inte.Controls.Add(this.lblS1);
            this.inte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inte.ForeColor = System.Drawing.Color.ForestGreen;
            this.inte.Location = new System.Drawing.Point(22, 30);
            this.inte.Name = "inte";
            this.inte.Size = new System.Drawing.Size(301, 135);
            this.inte.TabIndex = 0;
            this.inte.TabStop = false;
            this.inte.Text = "Hesap Makinesi";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(147, 61);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 29);
            this.txt2.TabIndex = 5;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(147, 25);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 29);
            this.txt1.TabIndex = 4;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(143, 95);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 24);
            this.lblSonuc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sonuç = ";
            // 
            // lblS2
            // 
            this.lblS2.AutoSize = true;
            this.lblS2.Location = new System.Drawing.Point(20, 61);
            this.lblS2.Name = "lblS2";
            this.lblS2.Size = new System.Drawing.Size(117, 24);
            this.lblS2.TabIndex = 1;
            this.lblS2.Text = "Sayı 2 Giriniz";
            // 
            // lblS1
            // 
            this.lblS1.AutoSize = true;
            this.lblS1.Location = new System.Drawing.Point(20, 28);
            this.lblS1.Name = "lblS1";
            this.lblS1.Size = new System.Drawing.Size(117, 24);
            this.lblS1.TabIndex = 0;
            this.lblS1.Text = "Sayı 1 Giriniz";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnTopla);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(22, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 182);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlem Seçiniz";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.Location = new System.Drawing.Point(18, 140);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(256, 29);
            this.button8.TabIndex = 8;
            this.button8.Text = "Temizle";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Location = new System.Drawing.Point(125, 107);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(149, 28);
            this.button7.TabIndex = 7;
            this.button7.Text = "Renk Değiştir";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Location = new System.Drawing.Point(125, 78);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(149, 28);
            this.button6.TabIndex = 6;
            this.button6.Text = "Rastgele Sayı Üret";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(125, 49);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 28);
            this.button5.TabIndex = 5;
            this.button5.Text = "Üs Sayı Bulma";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(125, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 28);
            this.button4.TabIndex = 4;
            this.button4.Text = "Faktöriyel Alma";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(18, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "Bölme";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(18, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Çarpma";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(18, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Çıkarma";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTopla
            // 
            this.btnTopla.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTopla.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTopla.Location = new System.Drawing.Point(18, 20);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(101, 28);
            this.btnTopla.TabIndex = 0;
            this.btnTopla.Text = "Toplama";
            this.btnTopla.UseVisualStyleBackColor = false;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 367);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.inte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.inte.ResumeLayout(false);
            this.inte.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inte;
        private System.Windows.Forms.Label lblS2;
        private System.Windows.Forms.Label lblS1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTopla;
    }
}

