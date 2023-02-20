
namespace cansukutuphaneotomasyonu
{
    partial class uyelisteleme
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
            this.uyelistelemegrid = new System.Windows.Forms.DataGridView();
            this.iptal = new System.Windows.Forms.Button();
            this.aramatc = new System.Windows.Forms.TextBox();
            this.isimara = new System.Windows.Forms.Label();
            this.silmebutonu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uyelistelemegrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uyelistelemegrid
            // 
            this.uyelistelemegrid.BackgroundColor = System.Drawing.Color.LightCoral;
            this.uyelistelemegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uyelistelemegrid.Location = new System.Drawing.Point(22, 90);
            this.uyelistelemegrid.Name = "uyelistelemegrid";
            this.uyelistelemegrid.RowHeadersWidth = 51;
            this.uyelistelemegrid.RowTemplate.Height = 24;
            this.uyelistelemegrid.Size = new System.Drawing.Size(841, 498);
            this.uyelistelemegrid.TabIndex = 0;
            this.uyelistelemegrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uyelistelemegrid_CellContentClick);
            this.uyelistelemegrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uyelistelemegrid_CellContentClick);
            // 
            // iptal
            // 
            this.iptal.BackColor = System.Drawing.Color.LightSeaGreen;
            this.iptal.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptal.Location = new System.Drawing.Point(567, 32);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(177, 31);
            this.iptal.TabIndex = 31;
            this.iptal.Text = "İptal";
            this.iptal.UseVisualStyleBackColor = false;
            this.iptal.Click += new System.EventHandler(this.iptal_Click);
            // 
            // aramatc
            // 
            this.aramatc.BackColor = System.Drawing.Color.Salmon;
            this.aramatc.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramatc.Location = new System.Drawing.Point(166, 32);
            this.aramatc.Name = "aramatc";
            this.aramatc.Size = new System.Drawing.Size(163, 31);
            this.aramatc.TabIndex = 39;
            this.aramatc.TextChanged += new System.EventHandler(this.arama_TextChanged);
            // 
            // isimara
            // 
            this.isimara.AutoSize = true;
            this.isimara.BackColor = System.Drawing.Color.Transparent;
            this.isimara.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isimara.Location = new System.Drawing.Point(34, 37);
            this.isimara.Name = "isimara";
            this.isimara.Size = new System.Drawing.Size(126, 22);
            this.isimara.TabIndex = 40;
            this.isimara.Text = "Tc\'ye göre ara:";
            // 
            // silmebutonu
            // 
            this.silmebutonu.BackColor = System.Drawing.Color.Wheat;
            this.silmebutonu.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silmebutonu.Location = new System.Drawing.Point(367, 33);
            this.silmebutonu.Name = "silmebutonu";
            this.silmebutonu.Size = new System.Drawing.Size(178, 31);
            this.silmebutonu.TabIndex = 41;
            this.silmebutonu.Text = "Kaydı Sil";
            this.silmebutonu.UseVisualStyleBackColor = false;
            this.silmebutonu.Click += new System.EventHandler(this.silmebutonu_Click);
            // 
            // uyelisteleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cansukutuphaneotomasyonu.Properties.Resources.KK;
            this.ClientSize = new System.Drawing.Size(1043, 677);
            this.Controls.Add(this.silmebutonu);
            this.Controls.Add(this.isimara);
            this.Controls.Add(this.aramatc);
            this.Controls.Add(this.iptal);
            this.Controls.Add(this.uyelistelemegrid);
            this.Name = "uyelisteleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uyelisteleme";
            this.Load += new System.EventHandler(this.uyelisteleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uyelistelemegrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uyelistelemegrid;
        private System.Windows.Forms.Button iptal;
        private System.Windows.Forms.TextBox aramatc;
        private System.Windows.Forms.Label isimara;
        private System.Windows.Forms.Button silmebutonu;
    }
}