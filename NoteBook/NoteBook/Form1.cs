using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook
{
    public partial class Form1 : Form
    {
        private bool WrapFlag = false;
        private bool IsSaved = true;
        string FilePath;
        private bool FileExist = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            path.Text = "untitled.txt";
        }

        //new File--------------------------
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

            if (IsSaved == true)
            {
                tex.Clear();
                path.Text = "*.txt";
               
                //Form1 obj = new Form1();
                //obj.Show();

            }
            else
            {
                DialogResult res = MessageBox.Show("Do you want to save", "NoteBook", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        tex.Clear();
                        path.Text = "*txt";
                       
                    }
                }
                else
                {
                    tex.Clear();
                    path.Text = "*txt";
                    
                }
            }
        }

        //Open File --------------------------------
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsSaved == false)
            {
                DialogResult res = MessageBox.Show("Do you want to save", "NoteBook", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    if (FileExist == true)
                    {
                        //MessageBox.Show(FilePath);
                        tex.SaveFile(FilePath, RichTextBoxStreamType.PlainText);
                        IsSaved = true;
                        FileExist = true;
                        FilePath = saveFileDialog1.FileName;
                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            IsSaved = true;
                            FileExist = true;
                            FilePath = saveFileDialog1.FileName;
                        }
                    }
                    else
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            FilePath = saveFileDialog1.FileName;
                            FileExist = true;
                            IsSaved = true;
                        }
                    }  
                    //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    //{
                    //    IsSaved = true;
                    //    FileExist = true;
                    //    FilePath = saveFileDialog1.FileName;
                    //}
                }
                else
                {
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        IsSaved = true;
                        FileExist = true;
                        FilePath = saveFileDialog1.FileName;
                    }
                }
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    IsSaved = true;
                    FileExist = true;
                    FilePath = openFileDialog1.FileName;
                }
            }
        }

        //Save File ------------------------
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileExist == true)
            {
                tex.SaveFile(FilePath, RichTextBoxStreamType.PlainText);
                FileExist = true;
                IsSaved = true;
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FilePath = saveFileDialog1.FileName;
                    FileExist = true;
                    IsSaved = true;
                }
            }          
        }

        //Save As --------------------------
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePath = saveFileDialog1.FileName;
                FileExist = true;
                IsSaved = true;
            }
        }

        //Save file dialog -------------------
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            tex.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.PlainText);
            //MessageBox.Show("File Is Save", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FilePath = saveFileDialog1.FileName;
            MessageBox.Show(FilePath);
            path.Text = FilePath.Substring(25);
        }

        //Open file dialog----------------
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            tex.LoadFile(openFileDialog1.FileName,RichTextBoxStreamType.PlainText);
            string str = openFileDialog1.FileName;
            path.Text = str.Substring(25);
        }

        
        //Rich Text Box ---------------------------
        private void tex_TextChanged(object sender, EventArgs e)
        {
            IsSaved = false;
            if (tex.Text == "")
            {
                IsSaved = true;
                //undobtn.Enabled = true;
            }
        }

        //Exit -----------------------
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to save", "NoteBook", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                if (IsSaved == true)
                {
                    this.Close();
                }
                else
                {
                    if (FileExist == true)
                    {
                        tex.SaveFile(FilePath, RichTextBoxStreamType.PlainText);
                        FileExist = true;
                        IsSaved = true;
                        this.Close();
                    }
                    else
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            FilePath = saveFileDialog1.FileName;
                            FileExist = true;
                            IsSaved = true;
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                this.Close();
            }
        }

        
        //Color --------------
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (tex.SelectedText != "" && tex.SelectedText != null)
                {
                    tex.SelectionColor = colorDialog1.Color;
                }
                else
                {
                    tex.ForeColor = colorDialog1.Color;
                }
            }

        }

        //Wraper --------------------
        private void wrapedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WrapFlag == true)
            {
                tex.WordWrap = false;
                WrapFlag = false;
                wrapedToolStripMenuItem.Image = System.Drawing.Image.FromFile(@"D:\C#\NoteBook\Icons\uncheck.png");
            }
            else
            {
                tex.WordWrap = true;
                WrapFlag = true;
                wrapedToolStripMenuItem.Image = System.Drawing.Image.FromFile(@"D:\C#\NoteBook\Icons\checked.png");
            }
        }

        //Font style -------------------
        private void styleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                if (tex.SelectedText != "" && tex.SelectedText != null)
                {
                    tex.SelectionFont = fontDialog1.Font;
                }
                else
                {
                    tex.Font = fontDialog1.Font;
                }
            }
        }

       //Undo -----------------------
        private void undobtn_Click_1(object sender, EventArgs e)
        {
            tex.Undo();
            //undobtn.Enabled = false;
            redobtn.Enabled = true;
        }

        //Redo ----------------------
        private void redobtn_Click_1(object sender, EventArgs e)
        {
            tex.Redo();

            //redobtn.Enabled = false;
            //undobtn.Enabled = true;
        }

        //Select All -----------------
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tex.SelectAll();
        }

        //Selected font metod
        private void SelectedFont(FontStyle style)
        {
            tex.SelectionFont = new Font(tex.SelectionFont, style);
        }
        //All Font metod
        private void AllFont(FontStyle style)
        {
            tex.Font = new Font(tex.Font, style);
        }

        //Bold ------------
        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tex.SelectedText != "" && tex.SelectedText != null)
            {
                SelectedFont(FontStyle.Bold);
                //tex.SelectionFont = new Font(tex.SelectionFont, FontStyle.Bold);
            }
            else
            {
                AllFont(FontStyle.Bold);
              //  tex.Font = new Font(tex.Font, FontStyle.Bold);
            }
        }

        //Italic ---------------
        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tex.SelectedText != "" && tex.SelectedText != null)
            {
                SelectedFont(FontStyle.Italic);
            }
            else
            {
                AllFont(FontStyle.Italic);
            }
        }

        //Underline -----------------------
        private void underLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tex.SelectedText != "" && tex.SelectedText != null)
            {
                SelectedFont(FontStyle.Underline);
            }
            else
            {
                AllFont(FontStyle.Underline);
            }
        }

        //Stikeout --------------------
        private void strikeoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tex.SelectedText != "" && tex.SelectedText != null)
            {
                SelectedFont(FontStyle.Strikeout);
            }
            else
            {
                AllFont(FontStyle.Strikeout);
            }
        }

      //Reset --------------------------
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tex.SelectedText != "" && tex.SelectedText != null)
            {
                SelectedFont(FontStyle.Regular);
            }
            else
            {
                AllFont(FontStyle.Regular);
            }
        }

        //Font Size
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(toolStripComboBox1.SelectedItem.ToString());
            if (tex.SelectedText != "" && tex.SelectedText != null)
            {
                tex.SelectionFont = new Font(tex.SelectionFont.FontFamily, Int32.Parse(toolStripComboBox1.SelectedItem.ToString()));
            }
            else
            {
                tex.Font = new Font(tex.Font.FontFamily, Int32.Parse(toolStripComboBox1.SelectedItem.ToString()));
            }
        }

        //Cut -------------
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tex.Cut();
        }
        //Copy --------------------
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tex.Copy();
        }
        //Paste -----------------
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tex.Paste();
        }
        //Delete ----------------------
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tex.Clear();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed By Om Daudia", "NoteBook",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


       
    }
}

