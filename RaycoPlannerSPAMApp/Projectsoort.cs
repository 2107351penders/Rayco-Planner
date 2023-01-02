namespace RaycoPlannerSPAM
{
    public class ProjectSoort
    {
        public String naam { get; }
        public List<Deeltaak> deelTaken { get; private set; } = new List<Deeltaak>();

        public ProjectSoort(string naam)
        {
            this.naam = naam;
        }

        /* Voeg een deeltaak toe aan deze projectsoort
         * 
         * Geeft /true/ als de nieuwe taak valide is
         * en voegt deze nieuwe taak toe aan deze projectsoort
         * 
         * Geeft /false/ terug wanneer de id van de nieuwe taak
         * al bestaat binnen het project en voegt de taak niet
         * toe aan deze projectsoort
         */
        public bool addDeeltaak(Deeltaak nieuweDeeltaak)
        {
            foreach (Deeltaak deelTaak in deelTaken)
            {
                if (deelTaak.id == nieuweDeeltaak.id) // id van nieuwe taak is niet uniek binnen het project
                {
                    return false;
                }
            }
            deelTaken.Add(nieuweDeeltaak);
            return true;
        }

        /* Verwijder een deeltaak uit deze projectsoort
         * 
         * Geeft /true/ als deeltaak bestaat binnen deze projectsoort
         * en verwijderd deze uit deze projectsoort
         * 
         * Geeft /false/ terug wanneer deeltaak niet bestaat binnen deze
         * projectsoort
         */
        public bool removeDeeltaak(Deeltaak deeltaak)
        {
            if (deelTaken.Contains(deeltaak))
            {
                deelTaken.Remove(deeltaak);
                return true;
            }
            else return false;
        }

        /* Wijzig een deeltaak uit deze projectsoort
         * 
         * Geeft /true/ als deeltaak bestaat binnen deze projectsoort
         * en wijzigt deze op basis van de meegegeven parameters. De
         * gewijzigde taak behoudt zijn oorspronkelijke id.
         * 
         * Geeft /false/ terug wanneer deeltaak niet bestaat binnen deze
         * projectsoort
         */
        public bool wijzigDeeltaak(Deeltaak deeltaak, string beschrijving, string rol, int tijdInDagen, Deeltaak voorgaandeTaak)
        {
            if (deelTaken.Contains(deeltaak))
            {
                deelTaken.Remove(deeltaak);
                Deeltaak gewijzigdeDeeltaak = new Deeltaak(beschrijving, deeltaak.id, tijdInDagen, rol, voorgaandeTaak);
                deelTaken.Add(gewijzigdeDeeltaak);
                return true;
            }
            else return false;
        }

        /* Berekent de de duur van een (opeenvolging van) deeltaak
         * 
         * Geeft een integer getal terug. Dit getal is de som van de
         * duur van deeltaak + voorgaande taken OF de duur van deeltaak
         * als deze geen voorgaande taken heeft
         */
        private int getTakenDuur(Deeltaak deeltaak)
        {
            if (deeltaak.voorgaandeTaak == null) // deelTaak staat los. Dus TakenDuur == duur van deze taak
            {
                return deeltaak.tijdInDagen;
            }
            else // Taak heeft voorgaande taken. Dus TakenDuur == duur van deze taak + duur van voorgaande taken
            {
                return deeltaak.tijdInDagen + getTakenDuur(deeltaak.voorgaandeTaak);
            }
        }

       /* Berekent de doorlooptijd van deze projectsoort
        * 
        * De doorlooptijd is gelijk aan de totale duur
        * van de langste opeenvolging van taken OF, als een losse taak
        * langer duurt dan de langste opeenvolgende reeks van taken, de duur
        * van deze taak
        * 
        * Geeft een integer getal. Dit getal is de doorlooptijd
        * van deze projectsoort
        */
        public int berekenDoorlooptijd()
        {
            int doorlooptijd = 0;

            foreach (Deeltaak deeltaak in deelTaken)
            {
                int tijdsduur = getTakenDuur(deeltaak);
                
                if (tijdsduur > doorlooptijd) doorlooptijd = tijdsduur;
            }

            return doorlooptijd;
        }

        /* Berekent de som van de duur van alle deeltaken 
         * 
         * Geeft een integer getal terug. Dit getal is de som van de
         * duur van alle deeltaken in de lijst deelTaken
         */
        public int berekenTotaalUren()
        {
            int totaalUren = 0;

            foreach (Deeltaak deelTaak in deelTaken)
            {
                totaalUren += deelTaak.tijdInDagen;
            }

            return totaalUren;
        }
    }
}
