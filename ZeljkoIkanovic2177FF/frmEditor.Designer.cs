using System.Drawing;
using System.Windows.Forms;

namespace ZeljkoIkanovic2177FF
{
    partial class frmEditor
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

         // 
     


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditor));
            this.rtbEditor = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblLinija = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblZnakova = new System.Windows.Forms.ToolStripStatusLabel();
            this.bojeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.noviStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.otvoriStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.snimiStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.izlazStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.isjeciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopirajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nalijepiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.označiSveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.bojeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sveBojeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.crnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zelenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crvenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sviFontoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.podebljanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kurzivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podvučenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sacuvajFajl = new System.Windows.Forms.SaveFileDialog();
            this.otvoriFajl = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbEditor
            // 
            this.rtbEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbEditor.Location = new System.Drawing.Point(0, 36);
            this.rtbEditor.Name = "rtbEditor";
            this.rtbEditor.Size = new System.Drawing.Size(800, 378);
            this.rtbEditor.TabIndex = 1;
            this.rtbEditor.Text = "";
            this.rtbEditor.TextChanged += new System.EventHandler(this.rtbEditor_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLinija,
            this.lblZnakova});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 32);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblLinija
            // 
            this.lblLinija.Name = "lblLinija";
            this.lblLinija.Size = new System.Drawing.Size(70, 25);
            this.lblLinija.Text = "lblLinija";
            // 
            // lblZnakova
            // 
            this.lblZnakova.Name = "lblZnakova";
            this.lblZnakova.Size = new System.Drawing.Size(179, 25);
            this.lblZnakova.Text = "toolStripStatusLabel2";
            // 
            // bojeToolStripMenuItem
            // 
            this.bojeToolStripMenuItem.Image = global::ZeljkoIkanovic2177FF.Properties.Resources.Boje;
            this.bojeToolStripMenuItem.Name = "bojeToolStripMenuItem";
            this.bojeToolStripMenuItem.Size = new System.Drawing.Size(150, 34);
            this.bojeToolStripMenuItem.Text = "Boje";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Image = global::ZeljkoIkanovic2177FF.Properties.Resources.Font;
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(150, 34);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // formatStripSplitButton
            // 
            this.formatStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.formatStripSplitButton.DropDownButtonWidth = 0;
            this.formatStripSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("formatStripSplitButton.Image")));
            this.formatStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.formatStripSplitButton.Name = "formatStripSplitButton";
            this.formatStripSplitButton.Size = new System.Drawing.Size(74, 29);
            this.formatStripSplitButton.Text = "Format";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStrip,
            this.editToolStrip,
            this.formatToolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileStrip
            // 
            this.fileStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviStripMenuItem1,
            this.otvoriStripMenuItem4,
            this.snimiStripMenuItem5,
            this.toolStripSeparator1,
            this.izlazStripMenuItem6});
            this.fileStrip.Name = "fileStrip";
            this.fileStrip.Size = new System.Drawing.Size(54, 29);
            this.fileStrip.Text = "File";
            // 
            // noviStripMenuItem1
            // 
            this.noviStripMenuItem1.Image = global::ZeljkoIkanovic2177FF.Properties.Resources.Novi;
            this.noviStripMenuItem1.Name = "noviStripMenuItem1";
            this.noviStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.noviStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.noviStripMenuItem1.Text = "Novi";
            this.noviStripMenuItem1.Click += new System.EventHandler(this.noviStripMenuItem1_Click);
            // 
            // otvoriStripMenuItem4
            // 
            this.otvoriStripMenuItem4.Image = global::ZeljkoIkanovic2177FF.Properties.Resources.Otvori;
            this.otvoriStripMenuItem4.Name = "otvoriStripMenuItem4";
            this.otvoriStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otvoriStripMenuItem4.Size = new System.Drawing.Size(270, 34);
            this.otvoriStripMenuItem4.Text = "Otvori";
            this.otvoriStripMenuItem4.Click += new System.EventHandler(this.otvoriStripMenuItem4_Click);
            // 
            // snimiStripMenuItem5
            // 
            this.snimiStripMenuItem5.Image = global::ZeljkoIkanovic2177FF.Properties.Resources.Snimi;
            this.snimiStripMenuItem5.Name = "snimiStripMenuItem5";
            this.snimiStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.snimiStripMenuItem5.Size = new System.Drawing.Size(270, 34);
            this.snimiStripMenuItem5.Text = "Snimi";
            this.snimiStripMenuItem5.Click += new System.EventHandler(this.snimiStripMenuItem5_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // izlazStripMenuItem6
            // 
            this.izlazStripMenuItem6.Image = global::ZeljkoIkanovic2177FF.Properties.Resources.Izlaz;
            this.izlazStripMenuItem6.Name = "izlazStripMenuItem6";
            this.izlazStripMenuItem6.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.izlazStripMenuItem6.Size = new System.Drawing.Size(270, 34);
            this.izlazStripMenuItem6.Text = "Izlaz";
            this.izlazStripMenuItem6.Click += new System.EventHandler(this.izlazStripMenuItem6_Click);
            // 
            // editToolStrip
            // 
            this.editToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.isjeciToolStripMenuItem,
            this.kopirajToolStripMenuItem,
            this.nalijepiToolStripMenuItem,
            this.toolStripSeparator2,
            this.označiSveToolStripMenuItem});
            this.editToolStrip.Name = "editToolStrip";
            this.editToolStrip.Size = new System.Drawing.Size(58, 29);
            this.editToolStrip.Text = "Edit";
            this.editToolStrip.Click += new System.EventHandler(this.editToolStrip_Click);
            // 
            // isjeciToolStripMenuItem
            // 
            this.isjeciToolStripMenuItem.Image = global::ZeljkoIkanovic2177FF.Properties.Resources.Isjeci;
            this.isjeciToolStripMenuItem.Name = "isjeciToolStripMenuItem";
            this.isjeciToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.isjeciToolStripMenuItem.Text = "Isjeci";
            this.isjeciToolStripMenuItem.Click += new System.EventHandler(this.isjeciToolStripMenuItem_Click);
            // 
            // kopirajToolStripMenuItem
            // 
            this.kopirajToolStripMenuItem.Image = global::ZeljkoIkanovic2177FF.Properties.Resources.Kopiraj;
            this.kopirajToolStripMenuItem.Name = "kopirajToolStripMenuItem";
            this.kopirajToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.kopirajToolStripMenuItem.Text = "Kopiraj";
            this.kopirajToolStripMenuItem.Click += new System.EventHandler(this.kopirajToolStripMenuItem_Click);
            // 
            // nalijepiToolStripMenuItem
            // 
            this.nalijepiToolStripMenuItem.Image = global::ZeljkoIkanovic2177FF.Properties.Resources.Nalijepi;
            this.nalijepiToolStripMenuItem.Name = "nalijepiToolStripMenuItem";
            this.nalijepiToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.nalijepiToolStripMenuItem.Text = "Nalijepi";
            this.nalijepiToolStripMenuItem.Click += new System.EventHandler(this.nalijepiToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(258, 6);
            // 
            // označiSveToolStripMenuItem
            // 
            this.označiSveToolStripMenuItem.Image = global::ZeljkoIkanovic2177FF.Properties.Resources.OznaciSve;
            this.označiSveToolStripMenuItem.Name = "označiSveToolStripMenuItem";
            this.označiSveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.označiSveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.označiSveToolStripMenuItem.Text = "Označi sve";
            this.označiSveToolStripMenuItem.Click += new System.EventHandler(this.označiSveToolStripMenuItem_Click);
            // 
            // formatToolStripMenu
            // 
            this.formatToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bojeToolStripMenuItem1,
            this.fontoviToolStripMenuItem});
            this.formatToolStripMenu.Name = "formatToolStripMenu";
            this.formatToolStripMenu.Size = new System.Drawing.Size(85, 29);
            this.formatToolStripMenu.Text = "Format";
            // 
            // bojeToolStripMenuItem1
            // 
            this.bojeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sveBojeToolStripMenuItem,
            this.toolStripSeparator3,
            this.crnaToolStripMenuItem,
            this.plavaToolStripMenuItem,
            this.zelenaToolStripMenuItem,
            this.crvenaToolStripMenuItem});
            this.bojeToolStripMenuItem1.Image = global::ZeljkoIkanovic2177FF.Properties.Resources.Boje;
            this.bojeToolStripMenuItem1.Name = "bojeToolStripMenuItem1";
            this.bojeToolStripMenuItem1.Size = new System.Drawing.Size(150, 34);
            this.bojeToolStripMenuItem1.Text = "Boje";
            // 
            // sveBojeToolStripMenuItem
            // 
            this.sveBojeToolStripMenuItem.Name = "sveBojeToolStripMenuItem";
            this.sveBojeToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.sveBojeToolStripMenuItem.Text = "Sve boje";
            this.sveBojeToolStripMenuItem.Click += new System.EventHandler(this.sveBojeToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(179, 6);
            // 
            // crnaToolStripMenuItem
            // 
            this.crnaToolStripMenuItem.Name = "crnaToolStripMenuItem";
            this.crnaToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.crnaToolStripMenuItem.Text = "Crna";
            this.crnaToolStripMenuItem.Click += new System.EventHandler(this.sveBojeToolStripMenuItem_Click);
            // 
            // plavaToolStripMenuItem
            // 
            this.plavaToolStripMenuItem.Name = "plavaToolStripMenuItem";
            this.plavaToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.plavaToolStripMenuItem.Text = "Plava";
            this.plavaToolStripMenuItem.Click += new System.EventHandler(this.sveBojeToolStripMenuItem_Click);
            // 
            // zelenaToolStripMenuItem
            // 
            this.zelenaToolStripMenuItem.Name = "zelenaToolStripMenuItem";
            this.zelenaToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.zelenaToolStripMenuItem.Text = "Zelena";
            this.zelenaToolStripMenuItem.Click += new System.EventHandler(this.sveBojeToolStripMenuItem_Click);
            // 
            // crvenaToolStripMenuItem
            // 
            this.crvenaToolStripMenuItem.Name = "crvenaToolStripMenuItem";
            this.crvenaToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.crvenaToolStripMenuItem.Text = "Crvena";
            this.crvenaToolStripMenuItem.Click += new System.EventHandler(this.sveBojeToolStripMenuItem_Click);
            // 
            // fontoviToolStripMenuItem
            // 
            this.fontoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sviFontoviToolStripMenuItem,
            this.toolStripSeparator4,
            this.podebljanoToolStripMenuItem,
            this.kurzivToolStripMenuItem,
            this.podvučenoToolStripMenuItem});
            this.fontoviToolStripMenuItem.Image = global::ZeljkoIkanovic2177FF.Properties.Resources.Font;
            this.fontoviToolStripMenuItem.Name = "fontoviToolStripMenuItem";
            this.fontoviToolStripMenuItem.Size = new System.Drawing.Size(150, 34);
            this.fontoviToolStripMenuItem.Text = "Font";
            // 
            // sviFontoviToolStripMenuItem
            // 
            this.sviFontoviToolStripMenuItem.Name = "sviFontoviToolStripMenuItem";
            this.sviFontoviToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.sviFontoviToolStripMenuItem.Text = "Svi fontovi";
            this.sviFontoviToolStripMenuItem.Click += new System.EventHandler(this.sviFontoviToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(262, 6);
            // 
            // podebljanoToolStripMenuItem
            // 
            this.podebljanoToolStripMenuItem.Name = "podebljanoToolStripMenuItem";
            this.podebljanoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.podebljanoToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.podebljanoToolStripMenuItem.Text = "Podebljano";
            this.podebljanoToolStripMenuItem.Click += new System.EventHandler(this.sviFontoviToolStripMenuItem_Click);
            // 
            // kurzivToolStripMenuItem
            // 
            this.kurzivToolStripMenuItem.Name = "kurzivToolStripMenuItem";
            this.kurzivToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.kurzivToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.kurzivToolStripMenuItem.Text = "Kurziv";
            this.kurzivToolStripMenuItem.Click += new System.EventHandler(this.sviFontoviToolStripMenuItem_Click);
            // 
            // podvučenoToolStripMenuItem
            // 
            this.podvučenoToolStripMenuItem.Name = "podvučenoToolStripMenuItem";
            this.podvučenoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.podvučenoToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.podvučenoToolStripMenuItem.Text = "Podvučeno";
            this.podvučenoToolStripMenuItem.Click += new System.EventHandler(this.sviFontoviToolStripMenuItem_Click);
            // 
            // otvoriFajl
            // 
            this.otvoriFajl.FileName = "openFileDialog1";
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.rtbEditor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi dokument";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.MinimumSize = new Size(400, 300);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditor_FormClosing);



        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbEditor;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblLinija;
        private System.Windows.Forms.ToolStripStatusLabel lblZnakova;
       
   

        private System.Windows.Forms.ColorDialog izaberiBoju;
        private System.Windows.Forms.FontDialog izaberiFont;
        private ToolStripMenuItem bojeToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripSplitButton formatStripSplitButton;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileStrip;
        private ToolStripMenuItem noviStripMenuItem1;
        private ToolStripMenuItem otvoriStripMenuItem4;
        private ToolStripMenuItem snimiStripMenuItem5;
        private ToolStripMenuItem izlazStripMenuItem6;
        private ToolStripMenuItem editToolStrip;
        private ToolStripMenuItem formatToolStripMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem isjeciToolStripMenuItem;
        private ToolStripMenuItem kopirajToolStripMenuItem;
        private ToolStripMenuItem nalijepiToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem označiSveToolStripMenuItem;
        private ToolStripMenuItem bojeToolStripMenuItem1;
        private ToolStripMenuItem fontoviToolStripMenuItem;
        private ToolStripMenuItem sveBojeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem crnaToolStripMenuItem;
        private ToolStripMenuItem plavaToolStripMenuItem;
        private ToolStripMenuItem zelenaToolStripMenuItem;
        private ToolStripMenuItem crvenaToolStripMenuItem;
        private ToolStripMenuItem sviFontoviToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem podebljanoToolStripMenuItem;
        private ToolStripMenuItem kurzivToolStripMenuItem;
        private ToolStripMenuItem podvučenoToolStripMenuItem;
        private SaveFileDialog sacuvajFajl;
        private OpenFileDialog otvoriFajl;
    }
}

