using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaycoPlannerSPAM
{
    public partial class ProjectlidScherm : Form
    {
        private Projectlid ingelogdeUser;
        private Project geselecteerdProject;
        public ProjectlidScherm(Projectlid ingelogdeUser)
        {
            this.ingelogdeUser = ingelogdeUser;
           
            InitializeComponent();
            
            foreach (Project project in ingelogdeUser.projecten)
            {
                listBox1.Items.Add(project.naam);
            }

            geselecteerdProject = ingelogdeUser.projecten[0];
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void doorlooptijdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int doorlooptijd = geselecteerdProject.projectSoort.berekenMinimaleDoorlooptijd();
            Program.WriteLineToTextbox(richTextBox1, $"De doorlooptijd van dit project is {doorlooptijd} dagen");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Project project in ingelogdeUser.projecten)
            {
                if (project.naam == listBox1.SelectedItem.ToString())
                {
                    geselecteerdProject = project;
                }
            }
        }

        private void projectinformatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string projectNaam = geselecteerdProject.naam;
            string projectsoortNaam = geselecteerdProject.projectSoort.naam;

            Program.WriteLineToTextbox(richTextBox1, $"Project '{projectNaam}' is van projectsoort '{projectsoortNaam}'");
        }

        private void projecttakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string projectNaam = geselecteerdProject.naam;
            List<Deeltaak> projectTaken = geselecteerdProject.projectSoort.deelTaken;

            Program.WriteLineToTextbox(richTextBox1, $"Project '{projectNaam}' bevat de volgende taken:");

            int i = 1;
            foreach (Deeltaak taak in projectTaken)
            {
                Program.WriteLineToTextbox(richTextBox1, $"{i}: {taak.beschrijving}");
                i++;
            }
        }

        private void totaleTijdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int totaleTijd = geselecteerdProject.projectSoort.berekenTotaalUren();
            Program.WriteLineToTextbox(richTextBox1, $"De totale urenlast van dit project is {totaleTijd} dagen");
        }

        private void projectledenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string projectNaam = geselecteerdProject.naam;
            List<Projectlid> projectLeden = geselecteerdProject.taakuitvoering;

            Program.WriteLineToTextbox(richTextBox1, $"Het project '{projectNaam}' bevat de volgende projectleden:");

            int i = 1;
            foreach (Projectlid lid in projectLeden)
            {
                Program.WriteLineToTextbox(richTextBox1, $"{i}: {lid.naam}");
                i++;
            }
        }

        private void toegewezenTakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Taak> toegewezenTaken = ingelogdeUser.toegewezenTaken;

            Program.WriteLineToTextbox(richTextBox1, $"De volgende taken zijn aan u toegewezen:");

            int i = 1;
            foreach (Taak taak in toegewezenTaken)
            {
                Program.WriteLineToTextbox(richTextBox1, $"{i}: {taak.deeltaak.beschrijving}");
                i++;
            }
        }
    }
}
