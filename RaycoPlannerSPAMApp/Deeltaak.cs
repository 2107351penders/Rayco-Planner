namespace RaycoPlannerSPAM {
    public class Deeltaak
    {
        public String beschrijving { get; private set; }
        public int id { get; private set; }
        public int minimaleTijdInDagen { get; private set; }
        public int maximaleTijdInDagen { get; private set; }
        public string rol { get; private set; }
        public Deeltaak? voorgaandeTaak { get; private set; } = null;

        public Deeltaak(string beschrijving, int id, int minimaletijdInDagen, int maximaleTijdInDagen, string rol, Deeltaak? voorgaandeTaak)
        {
            this.beschrijving = beschrijving;
            this.id = id;
            this.minimaleTijdInDagen = minimaletijdInDagen;
            this.maximaleTijdInDagen = maximaleTijdInDagen;
            this.rol = rol;
            this.voorgaandeTaak = voorgaandeTaak;
        }
    }
}
