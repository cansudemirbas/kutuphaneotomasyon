
namespace cansukutuphaneotomasyonu
{
    partial class kitapsilmeformu
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
            this.silmebutonu = new System.Windows.Forms.Button();
            this.barkodara = new System.Windows.Forms.Label();
            this.barkodaratxt = new System.Windows.Forms.TextBox();
            this.iptal = new System.Windows.Forms.Button();
            this.kitaplistelemegrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplistelemegrid)).BeginInit();
            this.SuspendLayout();
            // 
            // silmebutonu
            // 
            this.silmebutonu.BackColor = System.Drawing.Color.Wheat;
            this.silmebutonu.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silmebutonu.Location = new System.Drawing.Point(382, 60);
            this.silmebutonu.Name = "silmebutonu";
            this.silmebutonu.Size = new System.Drawing.Size(178, 31);
            this.silmebutonu.TabIndex = 45;
            this.silmebutonu.Text = "Kitabı Sil";
            this.silmebutonu.UseVisualStyleBackColor = false;
            this.silmebutonu.Click += new System.EventHandler(this.silmebutonu_Click);
            // 
            // barkodara
            // 
            this.barkodara.AutoSize = true;
            this.barkodara.BackColor = System.Drawing.Color.Transparent;
            this.barkodara.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkodara.Location = new System.Drawing.Point(101, 65);
            this.barkodara.Name = "barkodara";
            this.barkodara.Size = new System.Drawing.Size(89, 22);
            this.barkodara.TabIndex = 44;
            this.barkodara.Text = "Barkod no:";
            this.barkodara.Click += new System.EventHandler(this.barkodara_Click);
            // 
            // barkodaratxt
            // 
            this.barkodaratxt.BackColor = System.Drawing.Color.Salmon;
            this.barkodaratxt.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkodaratxt.Location = new System.Drawing.Point(196, 60);
            this.barkodaratxt.Name = "barkodaratxt";
            this.barkodaratxt.Size = new System.Drawing.Size(163, 31);
            this.barkodaratxt.TabIndex = 43;
            this.barkodaratxt.TextChanged += new System.EventHandler(this.arakitap_TextChanged);
            // 
            // iptal
            // 
            this.iptal.BackColor = System.Drawing.Color.LightSeaGreen;
            this.iptal.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptal.Location = new System.Drawing.Point(580, 56);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(177, 31);
            this.iptal.TabIndex = 42;
            this.iptal.Text = "İptal";
            this.iptal.UseVisualStyleBackColor = false;
            this.iptal.Click += new System.EventHandler(this.iptal_Click);
            // 
            // kitaplistelemegrid
            // 
            this.kitaplistelemegrid.BackgroundColor = System.Drawing.Color.LightCoral;
            this.kitaplistelemegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitaplistelemegrid.Location = new System.Drawing.Point(29, 120);
            this.kitaplistelemegrid.Name = "kitaplistelemegrid";
            this.kitaplistelemegrid.RowHeadersWidth = 51;
            this.kitaplistelemegrid.RowTemplate.Height = 24;
            this.kitaplistelemegrid.Size = new System.Drawing.Size(807, 498);
            this.kitaplistelemegrid.TabIndex = 46;
            this.kitaplistelemegrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kitaplistelemegrid_CellContentClick);
            // 
            // kitapsilmeformu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cansukutuphaneotomasyonu.Properties.Resources.KK;
            this.ClientSize = new System.Drawing.Size(862, 670);
            this.Controls.Add(this.kitaplistelemegrid);
            this.Controls.Add(this.silmebutonu);
            this.Controls.Add(this.barkodara);
            this.Controls.Add(this.barkodaratxt);
            this.Controls.Add(this.iptal);
            this.Name = "kitapsilmeformu";
            this.Text = "kitapsilmeformu";
            this.Load += new System.EventHandler(this.kitapsilmeformu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitaplistelemegrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button silmebutonu;
        private System.Windows.Forms.Label barkodara;
        private System.Windows.Forms.TextBox barkodaratxt;
        private System.Windows.Forms.Button iptal;
        private System.Windows.Forms.DataGridView kitaplistelemegrid;
    }
}