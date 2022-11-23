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
            this.SuspendLayout();
            // 
            // naamBox
            // 
            this.naamBox.Location = new System.Drawing.Point(130, 28);
            this.naamBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.naamBox.Name = "naamBox";
            this.naamBox.Size = new System.Drawing.Size(156, 23);
            this.naamBox.TabIndex = 0;
            this.naamBox.TextChanged += new System.EventHandler(this.naamBox_TextChanged);
            // 
            // wachtwoordBox
            // 
            this.wachtwoordBox.Location = new System.Drawing.Point(130, 60);
            this.wachtwoordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wachtwoordBox.Name = "wachtwoordBox";
            this.wachtwoordBox.Size = new System.Drawing.Size(156, 23);
            this.wachtwoordBox.TabIndex = 1;
            this.wachtwoordBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welkom bij de Rayco Planner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wachtwoord";
            // 
            // inloggenKnop
            // 
            this.inloggenKnop.Location = new System.Drawing.Point(206, 89);
            this.inloggenKnop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inloggenKnop.Name = "inloggenKnop";
            this.inloggenKnop.Size = new System.Drawing.Size(78, 20);
            this.inloggenKnop.TabIndex = 5;
            this.inloggenKnop.Text = "Inloggen";
            this.inloggenKnop.UseVisualStyleBackColor = true;
            this.inloggenKnop.Click += new System.EventHandler(this.inloggenKnop_Click);
            // 
            // Inlogscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 117);
            this.Controls.Add(this.inloggenKnop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wachtwoordBox);
            this.Controls.Add(this.naamBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}