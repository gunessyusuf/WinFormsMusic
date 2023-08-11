namespace WinFormsMusic
{
    partial class SarkiEkle
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
            lMesaj = new Label();
            bTemizle = new Button();
            bEkle = new Button();
            groupBox3 = new GroupBox();
            lbTurler = new ListBox();
            groupBox2 = new GroupBox();
            ddlSarkici = new ComboBox();
            groupBox4 = new GroupBox();
            tbSure = new TextBox();
            tbAdi = new TextBox();
            label5 = new Label();
            label7 = new Label();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // lMesaj
            // 
            lMesaj.AutoSize = true;
            lMesaj.ForeColor = Color.IndianRed;
            lMesaj.Location = new Point(359, 555);
            lMesaj.Name = "lMesaj";
            lMesaj.Size = new Size(62, 25);
            lMesaj.TabIndex = 13;
            lMesaj.Text = "lMesaj";
            // 
            // bTemizle
            // 
            bTemizle.Location = new Point(475, 615);
            bTemizle.Name = "bTemizle";
            bTemizle.Size = new Size(112, 34);
            bTemizle.TabIndex = 11;
            bTemizle.Text = "Temizle";
            bTemizle.UseVisualStyleBackColor = true;
            bTemizle.Click += bTemizle_Click;
            // 
            // bEkle
            // 
            bEkle.Location = new Point(210, 615);
            bEkle.Name = "bEkle";
            bEkle.Size = new Size(112, 34);
            bEkle.TabIndex = 12;
            bEkle.Text = "Ekle";
            bEkle.UseVisualStyleBackColor = true;
            bEkle.Click += bEkle_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbTurler);
            groupBox3.Location = new Point(24, 338);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1038, 195);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tür Bilgileri";
            // 
            // lbTurler
            // 
            lbTurler.FormattingEnabled = true;
            lbTurler.ItemHeight = 25;
            lbTurler.Location = new Point(146, 24);
            lbTurler.Name = "lbTurler";
            lbTurler.SelectionMode = SelectionMode.MultiSimple;
            lbTurler.Size = new Size(404, 154);
            lbTurler.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ddlSarkici);
            groupBox2.Location = new Point(12, 190);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1038, 121);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Şarkıcı Bilgisi";
            // 
            // ddlSarkici
            // 
            ddlSarkici.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlSarkici.FormattingEnabled = true;
            ddlSarkici.Location = new Point(127, 72);
            ddlSarkici.Name = "ddlSarkici";
            ddlSarkici.Size = new Size(346, 33);
            ddlSarkici.TabIndex = 5;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tbSure);
            groupBox4.Controls.Add(tbAdi);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label7);
            groupBox4.Location = new Point(12, 41);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1038, 143);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Şarkı Bilgileri";
            // 
            // tbSure
            // 
            tbSure.Location = new Point(125, 81);
            tbSure.Name = "tbSure";
            tbSure.Size = new Size(348, 31);
            tbSure.TabIndex = 5;
            // 
            // tbAdi
            // 
            tbAdi.Location = new Point(127, 34);
            tbAdi.Name = "tbAdi";
            tbAdi.Size = new Size(348, 31);
            tbAdi.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 81);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 0;
            label5.Text = "Süre:";
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
            // SarkiEkle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 698);
            Controls.Add(lMesaj);
            Controls.Add(bTemizle);
            Controls.Add(bEkle);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Name = "SarkiEkle";
            Text = "Yeni Şarkı";
            Load += SarkiEkle_Load;
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lMesaj;
        private Button bTemizle;
        private Button bEkle;
        private GroupBox groupBox3;
        private ListBox lbTurler;
        private GroupBox groupBox2;
        private ComboBox ddlSarkici;
        private GroupBox groupBox4;
        private TextBox tbSure;
        private TextBox tbAdi;
        private Label label5;
        private Label label7;
    }
}