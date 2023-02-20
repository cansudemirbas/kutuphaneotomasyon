
namespace cansukutuphaneotomasyonu
{
    partial class kitapiade
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ekle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTcara = new System.Windows.Forms.TextBox();
            this.txtbarkodara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 64);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(885, 349);
            this.dataGridView2.TabIndex = 1;
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ekle.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle.Location = new System.Drawing.Point(650, 442);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(209, 38);
            this.ekle.TabIndex = 44;
            this.ekle.Text = "Teslim Al";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(650, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 38);
            this.button1.TabIndex = 45;
            this.button1.Text = "İPTAL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTcara
            // 
            this.txtTcara.Location = new System.Drawing.Point(459, 27);
            this.txtTcara.Name = "txtTcara";
            this.txtTcara.Size = new System.Drawing.Size(153, 22);
            this.txtTcara.TabIndex = 46;
            this.txtTcara.TextChanged += new System.EventHandler(this.txtTcara_TextChanged);
            // 
            // txtbarkodara
            // 
            this.txtbarkodara.Location = new System.Drawing.Point(728, 24);
            this.txtbarkodara.Name = "txtbarkodara";
            this.txtbarkodara.Size = new System.Drawing.Size(166, 22);
            this.txtbarkodara.TabIndex = 47;
            this.txtbarkodara.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(403, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(641, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "BARKOD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // kitapiade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cansukutuphaneotomasyonu.Properties.Resources.KK;
            this.ClientSize = new System.Drawing.Size(937, 674);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbarkodara);
            this.Controls.Add(this.txtTcara);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.dataGridView2);
            this.Name = "kitapiade";
            this.Text = "kitapiade";
            this.Load += new System.EventHandler(this.kitapiade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTcara;
        private System.Windows.Forms.TextBox txtbarkodara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}