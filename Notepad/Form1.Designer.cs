namespace Notepad
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            yeniNewToolStripMenuItem = new ToolStripMenuItem();
            açOpenToolStripMenuItem1 = new ToolStripMenuItem();
            kaydetSaveToolStripMenuItem1 = new ToolStripMenuItem();
            farklıKaydetSaveAsToolStripMenuItem = new ToolStripMenuItem();
            çıkışExitToolStripMenuItem1 = new ToolStripMenuItem();
            yeniNewToolStripMenuItem1 = new ToolStripMenuItem();
            açOpenToolStripMenuItem = new ToolStripMenuItem();
            kesToolStripMenuItem = new ToolStripMenuItem();
            kopyalaToolStripMenuItem = new ToolStripMenuItem();
            yapıştırToolStripMenuItem = new ToolStripMenuItem();
            tümünüSeçToolStripMenuItem = new ToolStripMenuItem();
            tarihSaatEkleToolStripMenuItem = new ToolStripMenuItem();
            görünümToolStripMenuItem = new ToolStripMenuItem();
            yazıTipiToolStripMenuItem = new ToolStripMenuItem();
            arkaPlanRenToolStripMenuItem = new ToolStripMenuItem();
            metinRengiToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 28);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1067, 642);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { yeniNewToolStripMenuItem, açOpenToolStripMenuItem, görünümToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1067, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // yeniNewToolStripMenuItem
            // 
            yeniNewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { açOpenToolStripMenuItem1, kaydetSaveToolStripMenuItem1, farklıKaydetSaveAsToolStripMenuItem, çıkışExitToolStripMenuItem1, yeniNewToolStripMenuItem1 });
            yeniNewToolStripMenuItem.Name = "yeniNewToolStripMenuItem";
            yeniNewToolStripMenuItem.Size = new Size(64, 24);
            yeniNewToolStripMenuItem.Text = "Dosya";
            // 
            // açOpenToolStripMenuItem1
            // 
            açOpenToolStripMenuItem1.Name = "açOpenToolStripMenuItem1";
            açOpenToolStripMenuItem1.Size = new Size(241, 26);
            açOpenToolStripMenuItem1.Text = "Aç (Open)";
            açOpenToolStripMenuItem1.Click += açOpenToolStripMenuItem1_Click;
            // 
            // kaydetSaveToolStripMenuItem1
            // 
            kaydetSaveToolStripMenuItem1.Name = "kaydetSaveToolStripMenuItem1";
            kaydetSaveToolStripMenuItem1.Size = new Size(241, 26);
            kaydetSaveToolStripMenuItem1.Text = "Kaydet (Save)";
            kaydetSaveToolStripMenuItem1.Click += kaydetSaveToolStripMenuItem1_Click;
            // 
            // farklıKaydetSaveAsToolStripMenuItem
            // 
            farklıKaydetSaveAsToolStripMenuItem.Name = "farklıKaydetSaveAsToolStripMenuItem";
            farklıKaydetSaveAsToolStripMenuItem.Size = new Size(241, 26);
            farklıKaydetSaveAsToolStripMenuItem.Text = "Farklı Kaydet (Save As)";
            farklıKaydetSaveAsToolStripMenuItem.Click += farklıKaydetSaveAsToolStripMenuItem_Click;
            // 
            // çıkışExitToolStripMenuItem1
            // 
            çıkışExitToolStripMenuItem1.Name = "çıkışExitToolStripMenuItem1";
            çıkışExitToolStripMenuItem1.Size = new Size(241, 26);
            çıkışExitToolStripMenuItem1.Text = "Çıkış (Exit)";
            çıkışExitToolStripMenuItem1.Click += çıkışExitToolStripMenuItem1_Click;
            // 
            // yeniNewToolStripMenuItem1
            // 
            yeniNewToolStripMenuItem1.Name = "yeniNewToolStripMenuItem1";
            yeniNewToolStripMenuItem1.Size = new Size(241, 26);
            yeniNewToolStripMenuItem1.Text = "Yeni(New)";
            // 
            // açOpenToolStripMenuItem
            // 
            açOpenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kesToolStripMenuItem, kopyalaToolStripMenuItem, yapıştırToolStripMenuItem, tümünüSeçToolStripMenuItem, tarihSaatEkleToolStripMenuItem });
            açOpenToolStripMenuItem.Name = "açOpenToolStripMenuItem";
            açOpenToolStripMenuItem.Size = new Size(77, 24);
            açOpenToolStripMenuItem.Text = "Düzenle";
            // 
            // kesToolStripMenuItem
            // 
            kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            kesToolStripMenuItem.Size = new Size(189, 26);
            kesToolStripMenuItem.Text = "Kes";
            kesToolStripMenuItem.Click += kesToolStripMenuItem_Click;
            // 
            // kopyalaToolStripMenuItem
            // 
            kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            kopyalaToolStripMenuItem.Size = new Size(189, 26);
            kopyalaToolStripMenuItem.Text = "Kopyala";
            kopyalaToolStripMenuItem.Click += kopyalaToolStripMenuItem_Click;
            // 
            // yapıştırToolStripMenuItem
            // 
            yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            yapıştırToolStripMenuItem.Size = new Size(189, 26);
            yapıştırToolStripMenuItem.Text = "Yapıştır";
            yapıştırToolStripMenuItem.Click += yapıştırToolStripMenuItem_Click;
            // 
            // tümünüSeçToolStripMenuItem
            // 
            tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            tümünüSeçToolStripMenuItem.Size = new Size(189, 26);
            tümünüSeçToolStripMenuItem.Text = "Tümünü Seç";
            tümünüSeçToolStripMenuItem.Click += tümünüSeçToolStripMenuItem_Click;
            // 
            // tarihSaatEkleToolStripMenuItem
            // 
            tarihSaatEkleToolStripMenuItem.Name = "tarihSaatEkleToolStripMenuItem";
            tarihSaatEkleToolStripMenuItem.Size = new Size(189, 26);
            tarihSaatEkleToolStripMenuItem.Text = "Tarih/Saat Ekle";
            tarihSaatEkleToolStripMenuItem.Click += tarihSaatEkleToolStripMenuItem_Click;
            // 
            // görünümToolStripMenuItem
            // 
            görünümToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yazıTipiToolStripMenuItem, arkaPlanRenToolStripMenuItem, metinRengiToolStripMenuItem });
            görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            görünümToolStripMenuItem.Size = new Size(84, 24);
            görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // yazıTipiToolStripMenuItem
            // 
            yazıTipiToolStripMenuItem.Name = "yazıTipiToolStripMenuItem";
            yazıTipiToolStripMenuItem.Size = new Size(224, 26);
            yazıTipiToolStripMenuItem.Text = "Yazı Tipi";
            yazıTipiToolStripMenuItem.Click += yazıTipiToolStripMenuItem_Click;
            // 
            // arkaPlanRenToolStripMenuItem
            // 
            arkaPlanRenToolStripMenuItem.Name = "arkaPlanRenToolStripMenuItem";
            arkaPlanRenToolStripMenuItem.Size = new Size(224, 26);
            arkaPlanRenToolStripMenuItem.Text = "Arka Plan Rengi";
            arkaPlanRenToolStripMenuItem.Click += arkaPlanRenToolStripMenuItem_Click;
            // 
            // metinRengiToolStripMenuItem
            // 
            metinRengiToolStripMenuItem.Name = "metinRengiToolStripMenuItem";
            metinRengiToolStripMenuItem.Size = new Size(224, 26);
            metinRengiToolStripMenuItem.Text = "Metin Rengi";
            metinRengiToolStripMenuItem.Click += metinRengiToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 670);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "NotePad";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem yeniNewToolStripMenuItem;
        private ToolStripMenuItem açOpenToolStripMenuItem;
        private ToolStripMenuItem açOpenToolStripMenuItem1;
        private ToolStripMenuItem kaydetSaveToolStripMenuItem1;
        private ToolStripMenuItem farklıKaydetSaveAsToolStripMenuItem;
        private ToolStripMenuItem çıkışExitToolStripMenuItem1;
        private ToolStripMenuItem kesToolStripMenuItem;
        private ToolStripMenuItem kopyalaToolStripMenuItem;
        private ToolStripMenuItem yapıştırToolStripMenuItem;
        private ToolStripMenuItem yeniNewToolStripMenuItem1;
        private ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private ToolStripMenuItem görünümToolStripMenuItem;
        private ToolStripMenuItem yazıTipiToolStripMenuItem;
        private ToolStripMenuItem arkaPlanRenToolStripMenuItem;
        private ToolStripMenuItem tarihSaatEkleToolStripMenuItem;
        private ToolStripMenuItem metinRengiToolStripMenuItem;
    }
}
