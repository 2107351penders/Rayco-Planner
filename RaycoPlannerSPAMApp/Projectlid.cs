namespace RaycoPlannerSPAM
{
    public class Projectlid
    {
        public int id { get; private set; }
        public string naam { get; private set; }
        public string rol { get; set; }
        public int[] beschikbaarheid { get; private set; } = new int[7];
        public bool isAdmin { get; private set; } = false;
        public List<Project> projecten { get; set; } = new List<Project>{ };
        public List<Taak> toegewezenTaken { get; set; } = new List<Taak> { };

        public Projectlid(int id, string naam, string rol, int[] beschikbaarheid)
        {
            this.id = id;
            this.naam = naam;
            this.rol = rol;
            this.beschikbaarheid = beschikbaarheid;

            if (rol == "admin")
            {
                isAdmin = true;
            }
        }
    }
}
