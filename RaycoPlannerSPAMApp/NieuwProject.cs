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
    public partial class NieuwProject : Form
    {
        private List<Projectlid> projectleden = new List<Projectlid>();
        private List<ProjectSoort> projectsoort = new List<ProjectSoort>();
        public NieuwProject(List<Projectlid> projectleden, List<ProjectSoort> projectsoort)
        {
            InitializeComponent();
            this.projectleden = projectleden;
            this.projectsoort = projectsoort;
        }

        private void NieuwProject_Load(object sender, EventArgs e)
        {
            foreach (Projectlid projectlid in projectleden)
            {
                checkedListBox1.Items.Add(projectlid.naam);
            }

            foreach (ProjectSoort projectsoort in projectsoort)
            {
                listBox1.Items.Add(projectsoort.naam);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjectSoort gekozenProjectsoort = null;

            foreach (ProjectSoort projectSoort in projectsoort)
            {
                if (projectSoort.naam == listBox1.Text)
                {
                    gekozenProjectsoort = projectSoort;
                }
            }
            
            Project nieuwProject = new Project(textBox1.Text, textBox2.Text, gekozenProjectsoort);
            this.Close();
        }
    }
}
