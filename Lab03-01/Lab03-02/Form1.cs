using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
namespace Lab03_02
{
    public partial class Form1 : Form
    {
        private void OpenNewForm1()
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.ForeColor = fontDialog1.Color;
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(FontFamily font in new InstalledFontCollection().Families)
            {
                comboboxFont.Items.Add(font.Name);
            }
            comboboxSize.Items.Add(8);
            comboboxSize.Items.Add(9);
            comboboxSize.Items.Add(10);
            comboboxSize.Items.Add(11);
            comboboxSize.Items.Add(12);
            comboboxSize.Items.Add(14);
            comboboxSize.Items.Add(16);
            comboboxSize.Items.Add(18);
            comboboxSize.Items.Add(20);
            comboboxSize.Items.Add(22);
            comboboxSize.Items.Add(24);
            comboboxSize.Items.Add(26);
            comboboxSize.Items.Add(28);
            comboboxSize.Items.Add(36);
            comboboxSize.Items.Add(48);
            comboboxSize.Items.Add(72);
            comboboxFont.SelectedIndexChanged += new EventHandler(comboboxFont_SelectedIndexChanged);
            comboboxSize.SelectedIndexChanged += new EventHandler(comboboxSize_SelectedIndexChanged);

        }

        private void comboboxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFontName = comboboxFont.SelectedItem.ToString();

            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle style = currentFont.Style;
                float size = currentFont.Size;

                Font newFont = new Font(selectedFontName, size, style);
                richTextBox1.SelectionFont = newFont;
            }
            else
            {
                Font newFont = new Font(selectedFontName, richTextBox1.Font.Size);
                richTextBox1.SelectionFont = newFont;
            }
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;

            if (currentFont == null)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
            }
            else
            {
                FontStyle newStyle = currentFont.Style ^ FontStyle.Italic;
                richTextBox1.SelectionFont = new Font(currentFont, newStyle);
            }
        }

        private void boldButton_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;

            if (currentFont == null)
            {              
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            }
            else
            {
                FontStyle newStyle = currentFont.Style ^ FontStyle.Bold;
                richTextBox1.SelectionFont = new Font(currentFont, newStyle);
            }
        }

        private void underlineButton_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;

            if (currentFont == null)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
            }
            else
            {
                FontStyle newStyle = currentFont.Style ^ FontStyle.Underline;
                richTextBox1.SelectionFont = new Font(currentFont, newStyle);
            }
        }

        private void comboboxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            float selectedSize = float.Parse(comboboxSize.SelectedItem.ToString());

            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle style = currentFont.Style;
                string fontName = currentFont.FontFamily.Name;

                Font newFont = new Font(fontName, selectedSize, style);
                richTextBox1.SelectionFont = newFont;
            }
            else
            {
                Font newFont = new Font(richTextBox1.Font.FontFamily, selectedSize);
                richTextBox1.SelectionFont = newFont;
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            richTextBox1.Text = File.ReadAllText(dlg.FileName);
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string fileName = saveFileDialog.FileName;
                        using (StreamWriter writer = new StreamWriter(fileName))
                        {
                            writer.Write(richTextBox1.Text);
                        }
                    MessageBox.Show("Text saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while saving the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }
        }

        private void newAddButton_Click(object sender, EventArgs e)
        {
            OpenNewForm1();
        }
    }
}
