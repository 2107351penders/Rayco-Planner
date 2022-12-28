namespace RaycoPlannerSPAM
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            HRConnection hrConnection = HRConnection.GetInstance();

            // Haal projectleden op uit HR systeem
            List<Projectlid>? projectleden = hrConnection.getProjectleden();

            if (projectleden == null)
            {
                Console.WriteLine("Communicatiefout met HR tool");
                return;
            }

            List<ProjectSoort> projectsoorten = new List<ProjectSoort>();

            // Maak verbinding met de database
            // TODO
            DatabaseConnection databaseConnection = new DatabaseConnection();
            if (databaseConnection.openDatabaseConnection())
            {
                Console.WriteLine("Verbonden met database");
            }
            else
            {
                Console.WriteLine("Verbindingsfout met database");
                return;
            }

            ProjectSoort softwareOntwikkelen = new ProjectSoort("Software ontwikkelen");

            // Voeg twee taken toe die alleen opeenvolgend uit te voeren zijn
            Deeltaak maakOntwerp = new Deeltaak("Maak een ontwerp van de code", 0, 2, "Software architect", null);
            Deeltaak schrijfCode = new Deeltaak("Schrijf de code", 1, 3, "Programmeur", maakOntwerp);

            // Voeg een losstaande taak toe
            Deeltaak schrijfTests = new Deeltaak("Schrijf unit tests", 2, 3, "Tester", null);

            // Voeg deze deeltaken toe aan deze projectsoort
            softwareOntwikkelen.addDeeltaak(maakOntwerp);
            softwareOntwikkelen.addDeeltaak(schrijfCode);
            softwareOntwikkelen.addDeeltaak(schrijfTests);

            projectsoorten.Add(softwareOntwikkelen);

            // Maak een project van deze projectsoort
            Project testProject = new Project("Ontwikkel Rayco Planner", "Rayco", softwareOntwikkelen);

            // Vindt projectleden uit tabel van HR
            Projectlid tim = projectleden.FirstOrDefault(lid => lid.naam == "Tim Penders");
            Projectlid emiel = projectleden.FirstOrDefault(lid => lid.naam == "Emiel Baur");

            // Voeg twee leden toe aan dit project
            testProject.projectlidToevoegen(tim);
            testProject.projectlidToevoegen(emiel);

            // Wijs taken toe aan projectleden
            testProject.taakToewijzen(0, tim);
            testProject.taakToewijzen(1, tim);

            testProject.taakToewijzen(2, emiel);

            // Maak een tweede project van deze projectsoort
            Project testProject2 = new Project("Ontwikkel andere software", "Super Software", softwareOntwikkelen);

            // Voeg twee leden toe aan dit project
            testProject2.projectlidToevoegen(tim);
            testProject2.projectlidToevoegen(emiel);

            // Wijs taken toe aan projectleden
            testProject2.taakToewijzen(0, tim);
            testProject2.taakToewijzen(1, emiel);

            testProject2.taakToewijzen(2, emiel);

            // Start de GUI
            ApplicationConfiguration.Initialize();
            Application.Run(new Inlogscherm(databaseConnection, projectleden, projectsoorten));
        }

        public static void WriteLineToTextbox(RichTextBox richTextBox, string line)
        {
            richTextBox.Text += line;
            richTextBox.Text += '\n';
        }
    }
}