namespace WinFormsMusic
{
    partial class SarkilarListesi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvSarkilar = new DataGridView();
            lSarkiSayisi = new Label();
            menuStrip1 = new MenuStrip();
            şarkıİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            listeleToolStripMenuItem = new ToolStripMenuItem();
            ekleToolStripMenuItem = new ToolStripMenuItem();
            bDetay = new Button();
            bDuzenle = new Button();
            bSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSarkilar).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSarkilar
            // 
            dgvSarkilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSarkilar.Location = new Point(12, 101);
            dgvSarkilar.Name = "dgvSarkilar";
            dgvSarkilar.RowHeadersWidth = 62;
            dgvSarkilar.RowTemplate.Height = 33;
            dgvSarkilar.Size = new Size(1161, 396);
            dgvSarkilar.TabIndex = 0;
            // 
            // lSarkiSayisi
            // 
            lSarkiSayisi.AutoSize = true;
            lSarkiSayisi.Location = new Point(12, 63);
            lSarkiSayisi.Name = "lSarkiSayisi";
            lSarkiSayisi.Size = new Size(99, 25);
            lSarkiSayisi.TabIndex = 1;
            lSarkiSayisi.Text = "Şarkı Sayısı";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { şarkıİşlemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1194, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // şarkıİşlemleriToolStripMenuItem
            // 
            şarkıİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeleToolStripMenuItem, ekleToolStripMenuItem });
            şarkıİşlemleriToolStripMenuItem.Name = "şarkıİşlemleriToolStripMenuItem";
            şarkıİşlemleriToolStripMenuItem.Size = new Size(136, 29);
            şarkıİşlemleriToolStripMenuItem.Text = "Şarkı İşlemleri";
            // 
            // listeleToolStripMenuItem
            // 
            listeleToolStripMenuItem.Name = "listeleToolStripMenuItem";
            listeleToolStripMenuItem.Size = new Size(162, 34);
            listeleToolStripMenuItem.Text = "Listele";
            listeleToolStripMenuItem.Click += listeleToolStripMenuItem_Click;
            // 
            // ekleToolStripMenuItem
            // 
            ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            ekleToolStripMenuItem.Size = new Size(162, 34);
            ekleToolStripMenuItem.Text = "Ekle";
            ekleToolStripMenuItem.Click += ekleToolStripMenuItem_Click;
            // 
            // bDetay
            // 
            bDetay.BackColor = Color.DarkOrange;
            bDetay.Location = new Point(12, 525);
            bDetay.Name = "bDetay";
            bDetay.Size = new Size(112, 34);
            bDetay.TabIndex = 3;
            bDetay.Text = "Detay";
            bDetay.UseVisualStyleBackColor = false;
            bDetay.Click += bDetay_Click;
            // 
            // bDuzenle
            // 
            bDuzenle.BackColor = Color.RosyBrown;
            bDuzenle.Location = new Point(130, 525);
            bDuzenle.Name = "bDuzenle";
            bDuzenle.Size = new Size(112, 34);
            bDuzenle.TabIndex = 3;
            bDuzenle.Text = "Duzenle";
            bDuzenle.UseVisualStyleBackColor = false;
            bDuzenle.Click += bDuzenle_Click;
            // 
            // bSil
            // 
            bSil.BackColor = SystemColors.ActiveBorder;
            bSil.Location = new Point(248, 525);
            bSil.Name = "bSil";
            bSil.Size = new Size(112, 34);
            bSil.TabIndex = 3;
            bSil.Text = "Sil";
            bSil.UseVisualStyleBackColor = false;
            bSil.Click += bSil_Click;
            // 
            // SarkilarListesi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 703);
            Controls.Add(bSil);
            Controls.Add(bDuzenle);
            Controls.Add(bDetay);
            Controls.Add(lSarkiSayisi);
            Controls.Add(dgvSarkilar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "SarkilarListesi";
            Text = "Şarkı Listesi";
            Load += SarkilarListesi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSarkilar).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSarkilar;
        private Label lSarkiSayisi;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem şarkıİşlemleriToolStripMenuItem;
        private ToolStripMenuItem listeleToolStripMenuItem;
        private ToolStripMenuItem ekleToolStripMenuItem;
        private Button bDetay;
        private Button bDuzenle;
        private Button bSil;
    }
}