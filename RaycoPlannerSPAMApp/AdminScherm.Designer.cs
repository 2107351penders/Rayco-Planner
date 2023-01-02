namespace RaycoPlannerSPAM
{
    partial class AdminScherm : Form
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opslaanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectinformatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projecttakenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doorlooptijdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totaleTijdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectledenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuwProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beschikbareProjectenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toegewezenTakenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsoortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuweProjectsoortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beschikbareProjectsoortenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 70);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1038, 544);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.takenToolStripMenuItem,
            this.projectsoortToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opslaanToolStripMenuItem,
            this.afsluitenToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // opslaanToolStripMenuItem
            // 
            this.opslaanToolStripMenuItem.Name = "opslaanToolStripMenuItem";
            this.opslaanToolStripMenuItem.Size = new System.Drawing.Size(183, 34);
            this.opslaanToolStripMenuItem.Text = "Opslaan";
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(183, 34);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectinformatieToolStripMenuItem,
            this.projecttakenToolStripMenuItem,
            this.doorlooptijdToolStripMenuItem,
            this.totaleTijdToolStripMenuItem,
            this.projectledenToolStripMenuItem,
            this.nieuwProjectToolStripMenuItem,
            this.beschikbareProjectenToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // projectinformatieToolStripMenuItem
            // 
            this.projectinformatieToolStripMenuItem.Name = "projectinformatieToolStripMenuItem";
            this.projectinformatieToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.projectinformatieToolStripMenuItem.Text = "Projectinformatie";
            this.projectinformatieToolStripMenuItem.Click += new System.EventHandler(this.projectinformatieToolStripMenuItem_Click);
            // 
            // projecttakenToolStripMenuItem
            // 
            this.projecttakenToolStripMenuItem.Name = "projecttakenToolStripMenuItem";
            this.projecttakenToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.projecttakenToolStripMenuItem.Text = "Projecttaken";
            this.projecttakenToolStripMenuItem.Click += new System.EventHandler(this.projecttakenToolStripMenuItem_Click);
            // 
            // doorlooptijdToolStripMenuItem
            // 
            this.doorlooptijdToolStripMenuItem.Name = "doorlooptijdToolStripMenuItem";
            this.doorlooptijdToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.doorlooptijdToolStripMenuItem.Text = "Doorlooptijd";
            this.doorlooptijdToolStripMenuItem.Click += new System.EventHandler(this.doorlooptijdToolStripMenuItem_Click);
            // 
            // totaleTijdToolStripMenuItem
            // 
            this.totaleTijdToolStripMenuItem.Name = "totaleTijdToolStripMenuItem";
            this.totaleTijdToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.totaleTijdToolStripMenuItem.Text = "Totale tijd";
            this.totaleTijdToolStripMenuItem.Click += new System.EventHandler(this.totaleTijdToolStripMenuItem_Click);
            // 
            // projectledenToolStripMenuItem
            // 
            this.projectledenToolStripMenuItem.Name = "projectledenToolStripMenuItem";
            this.projectledenToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.projectledenToolStripMenuItem.Text = "Projectleden";
            this.projectledenToolStripMenuItem.Click += new System.EventHandler(this.projectledenToolStripMenuItem_Click);
            // 
            // nieuwProjectToolStripMenuItem
            // 
            this.nieuwProjectToolStripMenuItem.Name = "nieuwProjectToolStripMenuItem";
            this.nieuwProjectToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.nieuwProjectToolStripMenuItem.Text = "Nieuw project";
            this.nieuwProjectToolStripMenuItem.Click += new System.EventHandler(this.nieuwProjectToolStripMenuItem_Click);
            // 
            // beschikbareProjectenToolStripMenuItem
            // 
            this.beschikbareProjectenToolStripMenuItem.Name = "beschikbareProjectenToolStripMenuItem";
            this.beschikbareProjectenToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.beschikbareProjectenToolStripMenuItem.Text = "Beschikbare projecten";
            this.beschikbareProjectenToolStripMenuItem.Click += new System.EventHandler(this.beschikbareProjectenToolStripMenuItem_Click);
            // 
            // takenToolStripMenuItem
            // 
            this.takenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toegewezenTakenToolStripMenuItem});
            this.takenToolStripMenuItem.Name = "takenToolStripMenuItem";
            this.takenToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.takenToolStripMenuItem.Text = "Taken";
            // 
            // toegewezenTakenToolStripMenuItem
            // 
            this.toegewezenTakenToolStripMenuItem.Name = "toegewezenTakenToolStripMenuItem";
            this.toegewezenTakenToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.toegewezenTakenToolStripMenuItem.Text = "Toegewezen taken";
            this.toegewezenTakenToolStripMenuItem.Click += new System.EventHandler(this.toegewezenTakenToolStripMenuItem_Click);
            // 
            // projectsoortToolStripMenuItem
            // 
            this.projectsoortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nieuweProjectsoortToolStripMenuItem,
            this.beschikbareProjectsoortenToolStripMenuItem});
            this.projectsoortToolStripMenuItem.Name = "projectsoortToolStripMenuItem";
            this.projectsoortToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.projectsoortToolStripMenuItem.Text = "Projectsoort";
            // 
            // nieuweProjectsoortToolStripMenuItem
            // 
            this.nieuweProjectsoortToolStripMenuItem.Name = "nieuweProjectsoortToolStripMenuItem";
            this.nieuweProjectsoortToolStripMenuItem.Size = new System.Drawing.Size(328, 34);
            this.nieuweProjectsoortToolStripMenuItem.Text = "Nieuwe projectsoort";
            this.nieuweProjectsoortToolStripMenuItem.Click += new System.EventHandler(this.nieuweProjectsoortToolStripMenuItem_Click);
            // 
            // beschikbareProjectsoortenToolStripMenuItem
            // 
            this.beschikbareProjectsoortenToolStripMenuItem.Name = "beschikbareProjectsoortenToolStripMenuItem";
            this.beschikbareProjectsoortenToolStripMenuItem.Size = new System.Drawing.Size(328, 34);
            this.beschikbareProjectsoortenToolStripMenuItem.Text = "Beschikbare projectsoorten";
            this.beschikbareProjectsoortenToolStripMenuItem.Click += new System.EventHandler(this.beschikbareProjectsoortenToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(410, 29);
            this.listBox1.TabIndex = 2;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AdminScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 614);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminScherm";
            this.Text = "Rayco Planner (projectmanager)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem bestandToolStripMenuItem;
        private ToolStripMenuItem opslaanToolStripMenuItem;
        private ToolStripMenuItem afsluitenToolStripMenuItem;
        private ToolStripMenuItem projectToolStripMenuItem;
        private ToolStripMenuItem projectinformatieToolStripMenuItem;
        private ToolStripMenuItem projecttakenToolStripMenuItem;
        private ToolStripMenuItem doorlooptijdToolStripMenuItem;
        private ToolStripMenuItem totaleTijdToolStripMenuItem;
        private ToolStripMenuItem projectledenToolStripMenuItem;
        private ToolStripMenuItem takenToolStripMenuItem;
        private ToolStripMenuItem toegewezenTakenToolStripMenuItem;
        private ListBox listBox1;
        private ToolStripMenuItem nieuwProjectToolStripMenuItem;
        private ToolStripMenuItem projectsoortToolStripMenuItem;
        private ToolStripMenuItem nieuweProjectsoortToolStripMenuItem;
        private ToolStripMenuItem beschikbareProjectsoortenToolStripMenuItem;
        private ToolStripMenuItem beschikbareProjectenToolStripMenuItem;
    }
}