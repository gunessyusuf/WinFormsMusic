namespace WinFormsMusic
{
    partial class SarkiDetay
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
            groupBox3 = new GroupBox();
            lTurleri = new Label();
            groupBox2 = new GroupBox();
            label19 = new Label();
            lSarkiciAdiSoyadi = new Label();
            groupBox4 = new GroupBox();
            lSure = new Label();
            lAdi = new Label();
            label5 = new Label();
            label7 = new Label();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lTurleri);
            groupBox3.Location = new Point(12, 276);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1038, 121);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tür Bilgileri";
            // 
            // lTurleri
            // 
            lTurleri.AutoSize = true;
            lTurleri.Location = new Point(12, 45);
            lTurleri.Name = "lTurleri";
            lTurleri.Size = new Size(65, 25);
            lTurleri.TabIndex = 1;
            lTurleri.Text = "ITurleri";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(lSarkiciAdiSoyadi);
            groupBox2.Location = new Point(12, 139);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1038, 121);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Şarkıcı Bilgisi";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(10, 39);
            label19.Name = "label19";
            label19.Size = new Size(108, 25);
            label19.TabIndex = 0;
            label19.Text = "Adı Soyadı:";
            // 
            // lSarkiciAdiSoyadi
            // 
            lSarkiciAdiSoyadi.AutoSize = true;
            lSarkiciAdiSoyadi.Location = new Point(138, 39);
            lSarkiciAdiSoyadi.Name = "lSarkiciAdiSoyadi";
            lSarkiciAdiSoyadi.Size = new Size(147, 25);
            lSarkiciAdiSoyadi.TabIndex = 1;
            lSarkiciAdiSoyadi.Text = "lSarkiciAdiSoyadi";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lSure);
            groupBox4.Controls.Add(lAdi);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label7);
            groupBox4.Location = new Point(12, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1038, 121);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Şarkı Bilgileri";
            // 
            // lSure
            // 
            lSure.AutoSize = true;
            lSure.Location = new Point(150, 73);
            lSure.Name = "lSure";
            lSure.Size = new Size(51, 25);
            lSure.TabIndex = 2;
            lSure.Text = "lSure";
            // 
            // lAdi
            // 
            lAdi.AutoSize = true;
            lAdi.Location = new Point(149, 36);
            lAdi.Name = "lAdi";
            lAdi.Size = new Size(43, 25);
            lAdi.TabIndex = 1;
            lAdi.Text = "lAdi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 81);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 0;
            label5.Text = "Süresi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 30);
            label7.Name = "label7";
            label7.Size = new Size(46, 25);
            label7.TabIndex = 0;
            label7.Text = "Adı:";
            // 
            // SarkiDetay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 488);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Name = "SarkiDetay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sarki Detayı";
            Load += SarkiDetay_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Label lTurleri;
        private GroupBox groupBox2;
        private Label label19;
        private Label lSarkiciAdiSoyadi;
        private GroupBox groupBox4;
        private Label label5;
        private Label label7;
        private Label lSure;
        private Label lAdi;
    }
}