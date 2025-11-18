namespace Notepad
{
    public partial class Form1 : Form
    {
        private string currentFilePath = string.Empty;

        public Form1()
        {
            InitializeComponent();

        }

        private void farklýKaydetSaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Metin Dosyalarý (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            saveFileDialog1.Title = "Notu Kaydet";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    this.Text = System.IO.Path.GetFileName(saveFileDialog1.FileName) + " - NotDefterim";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya kaydedilirken bir hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void yapýþtýrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void çýkýþExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void açOpenToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Metin Dosyalarý (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            openFileDialog1.Title = "Notu Aç";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);

                    currentFilePath = openFileDialog1.FileName;

                    this.Text = Path.GetFileName(openFileDialog1.FileName) + " - NotePad";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya açýlýrken bir hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void kaydetSaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Metin Dosyalarý (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            saveFileDialog1.Title = "Notu Kaydet";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    this.Text = System.IO.Path.GetFileName(saveFileDialog1.FileName) + " - NotDefterim";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya kaydedilirken bir hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void yazýTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FontDialog fontDialog1 = new FontDialog();

            fontDialog1.Font = richTextBox1.Font;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void arkaPlanRenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ColorDialog colorDialog1 = new ColorDialog();

            colorDialog1.Color = richTextBox1.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void tarihSaatEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
        }

        private void metinRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();

            colorDialog1.Color = richTextBox1.SelectionColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

       
    }
}
