using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeljkoIkanovic2177FF
{
    public partial class frmEditor : Form
    {
        public int linija;
        public int znakova;
        public int brPromjena;
        List<String> lista;
        public frmEditor()
        {
            InitializeComponent();
            Clipboard.Clear();
            lista = new List<string>();
            lista.Add(rtbEditor.Text);
            linija = rtbEditor.Lines.Length;
            lblLinija.Text = "Linija: " + linija;
            znakova = rtbEditor.Text.Length;
            lblZnakova.Text = "Znakova: " + znakova;
            isjeciToolStripMenuItem.Enabled = false;
            kopirajToolStripMenuItem.Enabled = false;
            nalijepiToolStripMenuItem.Enabled = false;
          
        }

        private void sveBojeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            ToolStripMenuItem tool=(ToolStripMenuItem)sender;

            String s = tool.Text;
            switch(s)
            {
                case "Crna":
                    rtbEditor.SelectionColor = Color.Black;
                    break;
                case "Plava":
                    rtbEditor.SelectionColor = Color.Blue;
                    break;
                case "Zelena":
                    rtbEditor.SelectionColor = Color.Green;
                    break;
                case "Crvena":
                    rtbEditor.SelectionColor = Color.Red;
                    break;
                default:
                    DialogResult odgovor = colorDialog1.ShowDialog();
                    if (DialogResult.OK == odgovor)
                        rtbEditor.SelectionColor = colorDialog1.Color;
                    break;
            }

        }

        private void sviFontoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item=(ToolStripMenuItem)sender;  
            String s = item.Text;
            switch (s)
            {
                case "Podebljano":
                    rtbEditor.SelectionFont = new Font(rtbEditor.SelectionFont, FontStyle.Bold);
                    break;
                case "Kurziv":
                    rtbEditor.SelectionFont = new Font(rtbEditor.SelectionFont, FontStyle.Italic);
                    break;
                case "Podvučeno":
                    rtbEditor.SelectionFont = new Font(rtbEditor.SelectionFont, FontStyle.Underline);
                    break;
                default:
                    DialogResult odgovor=fontDialog1.ShowDialog();
                    if (DialogResult.OK == odgovor)
                        rtbEditor.SelectionFont = fontDialog1.Font;
                    break;

            }
        }

        private void rtbEditor_TextChanged(object sender, EventArgs e)
        {
            if (!this.Text.Contains("*"))
                this.Text += "*";
            bool nadjen = false;
            lista.Add(rtbEditor.Text);
            if (lista[lista.Count - 1] == lista[0])
                nadjen = true;
            if (nadjen == true && this.Text.Contains("*"))
                this.Text = this.Text.Substring(0, this.Text.Length - 1);
            linija = rtbEditor.Lines.Length;
            lblLinija.Text = "Linija: " + linija;
            znakova = rtbEditor.Text.Length;
            lblZnakova.Text = "Znakova: " + znakova;
        }

        private void noviStripMenuItem1_Click(object sender, EventArgs e)
        {
            lista = new List<string>();
            DialogResult odgovor = MessageBox.Show("Da li želite da snimite promjene?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (odgovor == DialogResult.Yes)
            {
                sacuvajFajl.FileName = "2177.rtf";
                sacuvajFajl.Filter = "Rich Text File (*.rtf)|*.rtf"; // Ispravljena definicija filtera
                DialogResult odgovor1 = sacuvajFajl.ShowDialog();
                if (odgovor1 == DialogResult.OK) // Ispravljeno na odgovor1
                {
                    rtbEditor.SaveFile(sacuvajFajl.FileName, RichTextBoxStreamType.RichText);
                    rtbEditor.Clear();
                    this.Text = "New Document";
                }
            }
            else
            {
                rtbEditor.Clear();
                lista.Add(rtbEditor.Text); // Dodavanje teksta u listu nakon čišćenja RichTextBox-a
            }
        }

        private void otvoriStripMenuItem4_Click(object sender, EventArgs e)
        {
            lista = new List<string>();

            if (this.Text.Contains("*"))
            {
                DialogResult odgovor = MessageBox.Show("Da li želite da snimite promjene?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (odgovor == DialogResult.Yes)
                {
                    sacuvajFajl.FileName = "2177.rtf";
                    sacuvajFajl.Filter = "(Rich Text File | *.rtf";
                    DialogResult odgovor1 = sacuvajFajl.ShowDialog();
                    if (odgovor1 == DialogResult.OK)
                        rtbEditor.SaveFile(sacuvajFajl.FileName, RichTextBoxStreamType.RichText);
                    rtbEditor.Clear();
                    this.Text = "New Document";
                }
            }
            otvoriFajl.Filter = "Rich Text File |*.rtf";
            DialogResult odgovor2 = otvoriFajl.ShowDialog();
            if (odgovor2 == DialogResult.OK)
            {
                rtbEditor.LoadFile(otvoriFajl.FileName, RichTextBoxStreamType.RichText);
                this.Text = otvoriFajl.FileName;
            }
            lista.Add(rtbEditor.Text);
        }

        private void snimiStripMenuItem5_Click(object sender, EventArgs e)
        {
            sacuvajFajl.Filter = "Rich Text File |*.rtf";
            sacuvajFajl.FileName = "2177.rtf";
            DialogResult odgovor = sacuvajFajl.ShowDialog();
            if (odgovor == DialogResult.OK)
            {
                rtbEditor.SaveFile(sacuvajFajl.FileName, RichTextBoxStreamType.RichText);
                this.Text = sacuvajFajl.FileName;
            }
        }

        private void izlazStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (!this.Text.Contains("*"))
                Application.Exit();
            else
            {
                DialogResult odgovor = MessageBox.Show("Da li želite da snimite fajl prije zatvaranja?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (odgovor == DialogResult.Yes)
                {
                    rtbEditor.Clear();
                    sacuvajFajl.FileName = "2177.rtf";
                    sacuvajFajl.Filter = "(Rich Text File | *.rtf";
                    DialogResult odgovor1 = sacuvajFajl.ShowDialog();
                    if (odgovor == DialogResult.OK)
                        rtbEditor.SaveFile(sacuvajFajl.FileName, RichTextBoxStreamType.RichText);
                    this.Text = "New Document";
                }
            }
        }

        private void editToolStrip_Click(object sender, EventArgs e)
        {
            nalijepiToolStripMenuItem.Enabled = (Clipboard.ContainsText()) ? true : false;
            isjeciToolStripMenuItem.Enabled = (rtbEditor.SelectedText != "") ? true : false;
            kopirajToolStripMenuItem.Enabled = (rtbEditor.SelectedText != "") ? true : false;
        }

        private void isjeciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tekst = rtbEditor.SelectedText;
            Clipboard.SetText(tekst);
            rtbEditor.SelectedText = "";
        }

        private void nalijepiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.SelectedText = Clipboard.GetText();
        }

        private void kopirajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbEditor.SelectedText);

        }

        private void označiSveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.SelectAll();
        }
        private void frmEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.Text.Contains("*"))
                Application.Exit();
            else
            {
                DialogResult odgovor = MessageBox.Show("Da li želite da snimite fajl prije zatvaranja?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (odgovor == DialogResult.Yes)
                {
                    rtbEditor.Clear();
                    sacuvajFajl.FileName = "2177.rtf";
                    sacuvajFajl.Filter = "(Rich Text File | *.rtf";
                    DialogResult odgovor1 = sacuvajFajl.ShowDialog();
                    if (odgovor == DialogResult.OK)
                        rtbEditor.SaveFile(sacuvajFajl.FileName, RichTextBoxStreamType.RichText);
                    this.Text = "New Document";
                }
            }
        }
    }
}
