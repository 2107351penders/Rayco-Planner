namespace RaycoPlannerSPAM
{
    public class Project
    {
        public string naam { get; private set; }
        public string opdrachtgever { get; private set; }
        public ProjectSoort projectSoort { get; private set; }
        public List<Taak> projectTaken { get; private set; } = new List<Taak> { };
        public List<Projectlid> taakuitvoering { get; private set; } = new List<Projectlid> { };

        public Project(string naam, string opdrachtgever, ProjectSoort projectSoort)
        {
            this.naam = naam;
            this.opdrachtgever = opdrachtgever;
            this.projectSoort = projectSoort;

            // Maak van elke deeltaak in projectSoort een taak in het project
            int i = 0;

            foreach (Deeltaak deelTaak in projectSoort.deelTaken)
            {
                projectTaken.Add(new Taak(i, deelTaak));
                i++;
            }
        }

        /* Wijs deze taak toe aan projectlid
        * 
        * Geeft /true/ en wijs de taak toe als projectlid de juiste 
        * rol heeft, lid is van dit project, en de opgegeven taak bestaat.
        * 
        * Geeft /false/ terug wanneer dit niet zo is
        */
        public bool taakToewijzen(int taakId, Projectlid toegewezenProjectlid)
        {
            foreach (Taak taak in projectTaken)
            {
                if (taak.id == taakId) // De taak bestaat dus verder naar toewijzen
                {
                    if (taakuitvoering.Contains(toegewezenProjectlid))
                    {
                        // Projectlid is lid van dit project. Dus taak kan toegewezen worden
                        if (taak.wijsToeAanProjectlid(toegewezenProjectlid))
                        {
                            toegewezenProjectlid.toegewezenTaken.Add(taak);
                            return true; // Ook de juiste rol dus alles OK
                        }
                        else return false; // Niet de juiste rol
                       
                    }
                    else return false; // Projectlid is GEEN lid van dit project. Dus taak kan NIET toegewezen worden
                }
            }
            return false; // De taak bestaat niet dus kan niet toewijzen
        }

        /* Voeg projectlid toe aan project
        * 
        * Geeft /true/ en voeg het projectlid toe als deze nog
        * niet in het project zit
        * 
        * Geeft /false/ terug wanneer dit niet zo is
        */
        public bool projectlidToevoegen(Projectlid projectlid)
        {
            if (taakuitvoering.Contains(projectlid)) return false; // Projectlid is al toegevoegd
            else
            {
                taakuitvoering.Add(projectlid);
                projectlid.projecten.Add(this);
                return true;
            }
        }
    }
}