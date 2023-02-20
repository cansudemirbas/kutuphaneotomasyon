
namespace cansukutuphaneotomasyonu
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
            this.kitaplik = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.uyeislemleri = new System.Windows.Forms.GroupBox();
            this.uyelist = new System.Windows.Forms.Button();
            this.uyekle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kitapiade = new System.Windows.Forms.Button();
            this.kitapal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kitapsil = new System.Windows.Forms.Button();
            this.kitapekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplik)).BeginInit();
            this.uyeislemleri.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kitaplik
            // 
            this.kitaplik.BackgroundColor = System.Drawing.Color.IndianRed;
            this.kitaplik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kitaplik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitaplik.GridColor = System.Drawing.SystemColors.Desktop;
            this.kitaplik.Location = new System.Drawing.Point(3, 449);
            this.kitaplik.Name = "kitaplik";
            this.kitaplik.RowHeadersWidth = 51;
            this.kitaplik.RowTemplate.Height = 24;
            this.kitaplik.Size = new System.Drawing.Size(1122, 227);
            this.kitaplik.TabIndex = 0;
            this.kitaplik.Tag = "Kitaplığımız";
            this.kitaplik.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(342, 742);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "2021-2022 © Cansu Demirbaş | Tüm Hakları Saklıdır";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // uyeislemleri
            // 
            this.uyeislemleri.BackColor = System.Drawing.Color.Transparent;
            this.uyeislemleri.Controls.Add(this.uyelist);
            this.uyeislemleri.Controls.Add(this.uyekle);
            this.uyeislemleri.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeislemleri.Location = new System.Drawing.Point(685, 66);
            this.uyeislemleri.Name = "uyeislemleri";
            this.uyeislemleri.Size = new System.Drawing.Size(339, 132);
            this.uyeislemleri.TabIndex = 3;
            this.uyeislemleri.TabStop = false;
            this.uyeislemleri.Text = "Üye İşlemleri";
            this.uyeislemleri.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // uyelist
            // 
            this.uyelist.BackColor = System.Drawing.Color.Salmon;
            this.uyelist.Location = new System.Drawing.Point(35, 84);
            this.uyelist.Name = "uyelist";
            this.uyelist.Size = new System.Drawing.Size(277, 36);
            this.uyelist.TabIndex = 1;
            this.uyelist.Text = "Üye Listele / Sil";
            this.uyelist.UseVisualStyleBackColor = false;
            this.uyelist.Click += new System.EventHandler(this.button2_Click);
            // 
            // uyekle
            // 
            this.uyekle.BackColor = System.Drawing.Color.Salmon;
            this.uyekle.Location = new System.Drawing.Point(35, 27);
            this.uyekle.Name = "uyekle";
            this.uyekle.Size = new System.Drawing.Size(277, 38);
            this.uyekle.TabIndex = 0;
            this.uyekle.Text = "Üye Ekle";
            this.uyekle.UseVisualStyleBackColor = false;
            this.uyekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.kitapiade);
            this.groupBox2.Controls.Add(this.kitapal);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(685, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 208);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            // 
            // kitapiade
            // 
            this.kitapiade.BackColor = System.Drawing.Color.Salmon;
            this.kitapiade.Location = new System.Drawing.Point(42, 89);
            this.kitapiade.Name = "kitapiade";
            this.kitapiade.Size = new System.Drawing.Size(270, 39);
            this.kitapiade.TabIndex = 1;
            this.kitapiade.Text = "Emanet Kitap iade";
            this.kitapiade.UseVisualStyleBackColor = false;
            this.kitapiade.Click += new System.EventHandler(this.kitapiade_Click);
            // 
            // kitapal
            // 
            this.kitapal.BackColor = System.Drawing.Color.Salmon;
            this.kitapal.Location = new System.Drawing.Point(42, 27);
            this.kitapal.Name = "kitapal";
            this.kitapal.Size = new System.Drawing.Size(270, 38);
            this.kitapal.TabIndex = 0;
            this.kitapal.Text = "Emanet Kitap al";
            this.kitapal.UseVisualStyleBackColor = false;
            this.kitapal.Click += new System.EventHandler(this.kitapal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(793, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "MEVLANA KIZ YURDU KÜTÜPHANE OTOMASYONU";
            // 
            // kitapsil
            // 
            this.kitapsil.BackColor = System.Drawing.Color.Salmon;
            this.kitapsil.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapsil.Location = new System.Drawing.Point(900, 682);
            this.kitapsil.Name = "kitapsil";
            this.kitapsil.Size = new System.Drawing.Size(193, 38);
            this.kitapsil.TabIndex = 9;
            this.kitapsil.Text = "Kitap Sil";
            this.kitapsil.UseVisualStyleBackColor = false;
            this.kitapsil.Click += new System.EventHandler(this.kitapsil_Click);
            // 
            // kitapekle
            // 
            this.kitapekle.BackColor = System.Drawing.Color.Salmon;
            this.kitapekle.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapekle.Location = new System.Drawing.Point(685, 682);
            this.kitapekle.Name = "kitapekle";
            this.kitapekle.Size = new System.Drawing.Size(187, 38);
            this.kitapekle.TabIndex = 10;
            this.kitapekle.Text = "Kitap Ekle";
            this.kitapekle.UseVisualStyleBackColor = false;
            this.kitapekle.Click += new System.EventHandler(this.button8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "KİTAPLIĞIMIZ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Location = new System.Drawing.Point(42, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Emanet kitap Listeleme";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::cansukutuphaneotomasyonu.Properties.Resources.KK;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1146, 767);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kitapekle);
            this.Controls.Add(this.kitapsil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uyeislemleri);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kitaplik);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Otomasyonuma Hoş Geldiniz..";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitaplik)).EndInit();
            this.uyeislemleri.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView kitaplik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox uyeislemleri;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button uyelist;
        private System.Windows.Forms.Button uyekle;
        private System.Windows.Forms.Button kitapiade;
        private System.Windows.Forms.Button kitapal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kitapsil;
        private System.Windows.Forms.Button kitapekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

