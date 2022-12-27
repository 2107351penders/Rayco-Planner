namespace RaycoPlannerSPAM
{
    public partial class Inlogscherm : Form
    {
        public DatabaseConnection databaseConnection;
        List<Projectlid> projectleden = new List<Projectlid>();
        List<ProjectSoort> projectsoorten = new List<ProjectSoort>();
        public Inlogscherm(DatabaseConnection databaseConnection, List<Projectlid> projectleden, List<ProjectSoort> projectsoorten)
        {
            InitializeComponent();
            this.databaseConnection = databaseConnection;
            this.projectleden = projectleden;
            this.projectsoorten = projectsoorten;
        }

        private void inloggenKnop_Click(object sender, EventArgs e)
        {
            databaseConnection.setConnectionString(textBox1.Text);

            if (databaseConnection.loginGebruiker(naamBox.Text, wachtwoordBox.Text))
            {
                foreach (Projectlid projectlid in projectleden)
                {
                    if (projectlid.naam == "Emiel Baur")
                    {
                        projectlid.rol = "admin";
                    }

                    if (projectlid.naam == naamBox.Text)
                    {
                        if (projectlid.rol == "admin")
                        {
                            // open admin scherm
                            AdminScherm adminScherm = new AdminScherm(projectlid, projectsoorten, projectleden);
                            adminScherm.Show();
                            return;
                        }
                        // open normaal scherm
                        ProjectlidScherm projectlidScherm = new ProjectlidScherm(projectlid);
                        projectlidScherm.Show();
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine("Onjuiste login");
            }
        }

        private void naamBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}