namespace RaycoPlannerSPAM
{
    public class Taak
    {
        public int id { get; private set; }
        public Deeltaak deeltaak { get; private set; }
        public Projectlid? toegewezenLid { get; private set; }

        public Taak(int id, Deeltaak deeltaak)
        {
            this.id = id;
            this.deeltaak = deeltaak;
        }

        /* Wijs deze taak toe aan projectlid
         * 
         * Geeft /true/ als projectlid de juiste rol heeft
         * en wijst de taak vervolgens toe aan dit projectlid
         * 
         * Geeft /false/ terug wanneer projectlid niet de juiste rol
         * heeft en wijst de taak niet toe
         */
        public bool wijsToeAanProjectlid(Projectlid projectlid)
        {
            string taakRol = deeltaak.rol;
            string lidRol = projectlid.rol;

            if (taakRol == lidRol)
            {
                toegewezenLid = projectlid;
                return true;
            }
            else return false;
        }
    }
}
