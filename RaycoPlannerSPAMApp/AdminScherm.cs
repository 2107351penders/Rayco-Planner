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
    public partial class AdminScherm : Form
    {
        private Projectlid ingelogdeUser;
        private Project geselecteerdProject;
        private List<ProjectSoort> projectsoorten = new List<ProjectSoort>();
        private List<Project> projecten = new List<Project>();
        private List<Projectlid> projectleden = new List<Projectlid>();
        public AdminScherm(Projectlid ingelogdeUser, List<ProjectSoort> projectsoorten, List<Projectlid> projectleden)
        {
            this.ingelogdeUser = ingelogdeUser;
            this.projectsoorten = projectsoorten;
            this.projectleden = projectleden;
           
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

        private void nieuwProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NieuwProject nieuwProjectScherm = new NieuwProject(projectleden, projectsoorten);
            nieuwProjectScherm.Show();
        }

        private void beschikbareProjectsoortenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.WriteLineToTextbox(richTextBox1, $"De volgende projectsoorten zijn beschikbaar:");

            int i = 1;
            foreach (ProjectSoort projectsoort in projectsoorten)
            {
                Program.WriteLineToTextbox(richTextBox1, $"{i}: {projectsoort.naam}");
                i++;
            }
        }

        private void nieuweProjectsoortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NieuwProject nieuwProjectsoortScherm = new NieuwProject(projectleden, projectsoorten);
            nieuwProjectsoortScherm.Show();
        }

        private void beschikbareProjectenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.WriteLineToTextbox(richTextBox1, $"De volgende projecten zijn aangemaakt:");

            int i = 1;
            foreach (Project project in projecten)
            {
                Program.WriteLineToTextbox(richTextBox1, $"{i}: {project.naam}");
                i++;
            }
        }
    }
}
