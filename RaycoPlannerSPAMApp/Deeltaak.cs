namespace RaycoPlannerSPAM {
    public class Deeltaak
    {
        public String beschrijving { get; private set; }
        public int id { get; private set; }
        public int tijdInDagen { get; private set; }
        public string rol { get; private set; }
        public Deeltaak? voorgaandeTaak { get; private set; } = null;

        public Deeltaak(string beschrijving, int id, int tijdInDagen, string rol, Deeltaak? voorgaandeTaak)
        {
            this.beschrijving = beschrijving;
            this.id = id;
            this.tijdInDagen = tijdInDagen;
            this.rol = rol;
            this.voorgaandeTaak = voorgaandeTaak;
        }
    }
}
