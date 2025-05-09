using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear(); 
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Metin Dosyaları|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void renkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
        }

        private void fotografEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                try
                {
                    pictureBox1.Image = Image.FromFile(imagePath);

                    Image image = pictureBox1.Image;
                    Clipboard.SetImage(image);

                    richTextBox1.Paste();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fotoğraf eklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }
                private void fotoğrafEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                try
                {
                    pictureBox1.Image = Image.FromFile(imagePath);

                    Image image = pictureBox1.Image;
                    Clipboard.SetImage(image);

                    richTextBox1.Paste();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fotoğraf eklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void kesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void yapışturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void açToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void kopyalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string metin = richTextBox1.Text;

            e.Graphics.DrawString(metin, new Font("Arial", 12), Brushes.Black, new PointF(100, 100));

        }

        private void label1_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
          
                dataGridView1.Columns.Add("Column1", "Sütun1");
                dataGridView1.Columns.Add("Column2", "Sütun2");
                dataGridView1.Columns.Add("Column3", "Sütun3");
                dataGridView1.Columns.Add("Column4", "Sütun4");
                dataGridView1.Columns.Add("Column5", "Sütun5");
                dataGridView1.Columns.Add("Column6", "Sütun6");
                dataGridView1.Columns.Add("Column7", "Sütun7");
                dataGridView1.Columns.Add("Column8", "Sütun8");
                dataGridView1.Columns.Add("Column9", "Sütun9");
                dataGridView1.Columns.Add("Column10", "Sütun10");
                dataGridView1.Columns.Add("Column11", "Sütun11");
                dataGridView1.Columns.Add("Column12", "Sütun12");
                dataGridView1.Columns.Add("Column13", "Sütun13");


                dataGridView1.Rows.Add("Veri1", "Veri2", "Veri3", "Veri4");
                dataGridView1.Rows.Add("Veri4", "Veri5", "Veri6", "Veri7");

                dataGridView1.Visible = !dataGridView1.Visible;
            }

        private void tabloEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dataGridView1.Columns.Add("Column1", "");
            dataGridView1.Columns.Add("Column2", "");
            dataGridView1.Columns.Add("Column3", "");
            dataGridView1.Columns.Add("Column4", "");
            dataGridView1.Columns.Add("Column5", "");
            dataGridView1.Columns.Add("Column6", "");
            dataGridView1.Columns.Add("Column7", "");
            dataGridView1.Columns.Add("Column8", "");
            dataGridView1.Columns.Add("Column9", "");
            dataGridView1.Columns.Add("Column10", "");
            dataGridView1.Columns.Add("Column11", "");
            dataGridView1.Columns.Add("Column12", "");
            dataGridView1.Columns.Add("Column13", "");


            dataGridView1.Rows.Add("", "", "", "");
            dataGridView1.Rows.Add("", "", "", "");

            dataGridView1.Visible = !dataGridView1.Visible;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Metin Dosyaları|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText); 
            }
        } 
        private void label2_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut(); 
        }

        private void label3_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();

        }

        private void yeniToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();

        }

        private void label6_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                try
                {
                    pictureBox1.Image = Image.FromFile(imagePath);

                    Image image = pictureBox1.Image;
                    Clipboard.SetImage(image);

                    richTextBox1.Paste();
                }
                catch (Exception ex)
            {
                    MessageBox.Show("Fotoğraf eklenirken bir hata oluştu: " + ex.Message);
          }
        }
      }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color; 
        }
      }

        private void label8_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle;

                if (currentFont.Bold)
                {
                    newFontStyle = currentFont.Style & ~FontStyle.Bold;
                }
                else
                {
                    newFontStyle = currentFont.Style | FontStyle.Bold;
                }

                richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
        }
      }

        private void label10_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle;

                if (currentFont.Underline)
                {
                    newFontStyle = currentFont.Style & ~FontStyle.Underline;
                }
                else
                {
                    newFontStyle = currentFont.Style | FontStyle.Underline;
                }

                richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                comboBoxFont.Items.Add(font.Name);
            }

            if (comboBoxFont.Items.Count > 0)
            {
                comboBoxFont.SelectedIndex = 0;
            }

            for (int i = 8; i <= 72; i += 2)
            {
                comboBoxFontSize.Items.Add(i);
            }

            comboBoxFontSize.SelectedIndex = comboBoxFontSize.Items.IndexOf(12);
            foreach (FontFamily font in FontFamily.Families)
            {
                comboBoxFont.Items.Add(font.Name);
            }

            if (comboBoxFont.Items.Count > 0)
            {
                comboBoxFont.SelectedIndex = 0;
            }
        }

        private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null && comboBoxFont.SelectedItem != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                string selectedFontName = comboBoxFont.SelectedItem.ToString();
                float currentFontSize = currentFont.Size;
                FontStyle currentFontStyle = currentFont.Style;

                richTextBox1.SelectionFont = new Font(selectedFontName, currentFontSize, currentFontStyle);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null && comboBoxFontSize.SelectedItem != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                string currentFontName = currentFont.Name;
                FontStyle currentFontStyle = currentFont.Style;

                float newFontSize = Convert.ToSingle(comboBoxFontSize.SelectedItem);

                richTextBox1.SelectionFont = new Font(currentFontName, newFontSize, currentFontStyle);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblItelik_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle;

                if (currentFont.Italic)
                {
                    newFontStyle = currentFont.Style & ~FontStyle.Italic;
                }
                else
                {
                    newFontStyle = currentFont.Style | FontStyle.Italic;
                }

                richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void sağaHizalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

        }

        private void solaHizalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;

        }

        private void ortalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void label15_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
  }   