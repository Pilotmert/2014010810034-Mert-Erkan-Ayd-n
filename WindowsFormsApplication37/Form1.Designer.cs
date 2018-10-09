namespace WindowsFormsApplication37
{
    partial class IlkCalısma
    {
        /// <summary>
        ///Gerekli designer değişkeni.
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
        ///Designer desteği için gerekli metottur; bu metodun
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griScalaİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt709AlgoritmasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lumaYöntemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açıklıkYöntemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pencere1 = new System.Windows.Forms.PictureBox();
            this.pencere2 = new System.Windows.Forms.PictureBox();
            this.kanalÇıkarımıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pencere1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pencere2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.BackColor = System.Drawing.Color.Aqua;
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resimSeçToolStripMenuItem,
            this.griScalaİşlemlerToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // resimSeçToolStripMenuItem
            // 
            this.resimSeçToolStripMenuItem.Name = "resimSeçToolStripMenuItem";
            this.resimSeçToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.resimSeçToolStripMenuItem.Text = "Resim Seç";
            this.resimSeçToolStripMenuItem.Click += new System.EventHandler(this.resimSeçToolStripMenuItem_Click);
            // 
            // griScalaİşlemlerToolStripMenuItem
            // 
            this.griScalaİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt709AlgoritmasıToolStripMenuItem,
            this.lumaYöntemiToolStripMenuItem,
            this.açıklıkYöntemiToolStripMenuItem,
            this.kanalÇıkarımıToolStripMenuItem});
            this.griScalaİşlemlerToolStripMenuItem.Name = "griScalaİşlemlerToolStripMenuItem";
            this.griScalaİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.griScalaİşlemlerToolStripMenuItem.Text = "Gri Skala İşlemler";
            // 
            // bt709AlgoritmasıToolStripMenuItem
            // 
            this.bt709AlgoritmasıToolStripMenuItem.Name = "bt709AlgoritmasıToolStripMenuItem";
            this.bt709AlgoritmasıToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.bt709AlgoritmasıToolStripMenuItem.Text = "Bt-709 Algoritması";
            this.bt709AlgoritmasıToolStripMenuItem.Click += new System.EventHandler(this.bt709AlgoritmasıToolStripMenuItem_Click);
            // 
            // lumaYöntemiToolStripMenuItem
            // 
            this.lumaYöntemiToolStripMenuItem.Name = "lumaYöntemiToolStripMenuItem";
            this.lumaYöntemiToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.lumaYöntemiToolStripMenuItem.Text = "Luma Yöntemi";
            this.lumaYöntemiToolStripMenuItem.Click += new System.EventHandler(this.lumaYöntemiToolStripMenuItem_Click);
            // 
            // açıklıkYöntemiToolStripMenuItem
            // 
            this.açıklıkYöntemiToolStripMenuItem.Name = "açıklıkYöntemiToolStripMenuItem";
            this.açıklıkYöntemiToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.açıklıkYöntemiToolStripMenuItem.Text = "Açıklık Yöntemi";
            this.açıklıkYöntemiToolStripMenuItem.Click += new System.EventHandler(this.açıklıkYöntemiToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.BackColor = System.Drawing.Color.Aqua;
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pencere1
            // 
            this.pencere1.Location = new System.Drawing.Point(43, 68);
            this.pencere1.Name = "pencere1";
            this.pencere1.Size = new System.Drawing.Size(282, 243);
            this.pencere1.TabIndex = 1;
            this.pencere1.TabStop = false;
            // 
            // pencere2
            // 
            this.pencere2.Location = new System.Drawing.Point(345, 68);
            this.pencere2.Name = "pencere2";
            this.pencere2.Size = new System.Drawing.Size(282, 243);
            this.pencere2.TabIndex = 1;
            this.pencere2.TabStop = false;
            // 
            // kanalÇıkarımıToolStripMenuItem
            // 
            this.kanalÇıkarımıToolStripMenuItem.Name = "kanalÇıkarımıToolStripMenuItem";
            this.kanalÇıkarımıToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.kanalÇıkarımıToolStripMenuItem.Text = "Kanal Çıkarımı";
            this.kanalÇıkarımıToolStripMenuItem.Click += new System.EventHandler(this.kanalÇıkarımıToolStripMenuItem_Click);
            // 
            // IlkCalısma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 332);
            this.Controls.Add(this.pencere2);
            this.Controls.Add(this.pencere1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IlkCalısma";
            this.Text = "Gri Yöntemler";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pencere1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pencere2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resimSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griScalaİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bt709AlgoritmasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lumaYöntemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açıklıkYöntemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pencere1;
        private System.Windows.Forms.PictureBox pencere2;
        private System.Windows.Forms.ToolStripMenuItem kanalÇıkarımıToolStripMenuItem;
    }
}

