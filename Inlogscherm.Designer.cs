namespace RaycoPlannerSPAM
{
    partial class Inlogscherm
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
            this.naamBox = new System.Windows.Forms.TextBox();
            this.wachtwoordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inloggenKnop = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // naamBox
            // 
            this.naamBox.Location = new System.Drawing.Point(149, 37);
            this.naamBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.naamBox.Name = "naamBox";
            this.naamBox.Size = new System.Drawing.Size(178, 27);
            this.naamBox.TabIndex = 0;
            this.naamBox.TextChanged += new System.EventHandler(this.naamBox_TextChanged);
            // 
            // wachtwoordBox
            // 
            this.wachtwoordBox.Location = new System.Drawing.Point(149, 80);
            this.wachtwoordBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.wachtwoordBox.Name = "wachtwoordBox";
            this.wachtwoordBox.Size = new System.Drawing.Size(178, 27);
            this.wachtwoordBox.TabIndex = 1;
            this.wachtwoordBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welkom bij de Rayco Planner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wachtwoord";
            // 
            // inloggenKnop
            // 
            this.inloggenKnop.Location = new System.Drawing.Point(9, 151);
            this.inloggenKnop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inloggenKnop.Name = "inloggenKnop";
            this.inloggenKnop.Size = new System.Drawing.Size(89, 27);
            this.inloggenKnop.TabIndex = 5;
            this.inloggenKnop.Text = "Inloggen";
            this.inloggenKnop.UseVisualStyleBackColor = true;
            this.inloggenKnop.Click += new System.EventHandler(this.inloggenKnop_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 27);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "database.db";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Database name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Inlogscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 181);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.inloggenKnop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wachtwoordBox);
            this.Controls.Add(this.naamBox);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Inlogscherm";
            this.Text = "Rayco Planner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox naamBox;
        private TextBox wachtwoordBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button inloggenKnop;
        private TextBox textBox1;
        private Label label4;
    }
}