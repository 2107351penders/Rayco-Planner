using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

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
        public bool wijzigDeeltaak(Deeltaak deeltaak, string beschrijving, string rol, int minimaleTijdInDagen, int maximaleTijdInDagen, List<Deeltaak>? voorgaandeTaak)
        {
            if (deelTaken.Contains(deeltaak))
            {
                deelTaken.Remove(deeltaak);
                Deeltaak gewijzigdeDeeltaak = new Deeltaak(beschrijving, deeltaak.id, minimaleTijdInDagen, maximaleTijdInDagen, rol, voorgaandeTaak);
                deelTaken.Add(gewijzigdeDeeltaak);
                return true;
            }
            else return false;
        }

        /* Check of er taken zijn die naar elkaar verwijzen en zo een lus
         * vormen
         * 
         * Geeft /true/ als deze ProjectSoort deze situatie bevat
         * 
         * Geeft /false/ terug wanneer dit niet zo is
         */
        public bool CheckLus()
        {
            foreach (Deeltaak taak in deelTaken)
            {
                if (taak.voorgaandeTaak.Count == 0)
                {
                    continue;
                }

                foreach (Deeltaak voorgaandeTaak in taak.voorgaandeTaak)
                {
                    foreach (Deeltaak voorVoorgaandeTaak in voorgaandeTaak.voorgaandeTaak)
                    {
                        if (voorVoorgaandeTaak.id == taak.id) return true;
                    }
                }
            }
            return false;
        }

        private int getMinimaleDoorlooptijd(Deeltaak taak)
        {
            if (taak.voorgaandeTaak.Count == 0) return taak.minimaleTijdInDagen;

            int minimaleDoorloopTijd = taak.minimaleTijdInDagen;

            foreach (Deeltaak voorgaandeTaak in taak.voorgaandeTaak)
            {
                minimaleDoorloopTijd += getMinimaleDoorlooptijd(voorgaandeTaak);
            }
            return minimaleDoorloopTijd;
        }

        private int getMaximaleDoorlooptijd(Deeltaak taak)
        {
            if (taak.voorgaandeTaak.Count == 0) return taak.maximaleTijdInDagen;

            int maximaleDoorloopTijd = 0;

            foreach (Deeltaak voorgaandeTaak in taak.voorgaandeTaak)
            {
                maximaleDoorloopTijd += getMaximaleDoorlooptijd(voorgaandeTaak);
            }
            return maximaleDoorloopTijd;
        }

        /* Berekent de minimale doorlooptijd van alle deeltaken
         * 
         * Geeft een integer getal terug. Dit is de som van de minimale
         * doorlooptijden van de langste keten deeltaken
         */
        public int berekenMinimaleDoorlooptijd()
        {
            int minimaleDoorloopTijd = 0;

            foreach (Deeltaak taak in deelTaken)
            {
                if (getMinimaleDoorlooptijd(taak) >= minimaleDoorloopTijd)
                {
                    minimaleDoorloopTijd = getMinimaleDoorlooptijd(taak);
                }
            }
            return minimaleDoorloopTijd;
        }

        /* Berekent de maximale doorlooptijd van alle deeltaken
         * 
         * Geeft een integer getal terug. Dit is de som van de maximale
         * doorlooptijden van de langste keten deeltaken
         */
        public int berekenMaximaleDoorlooptijd()
        {
            int maximaleDoorloopTijd = 0;

            foreach (Deeltaak taak in deelTaken)
            {
                if (getMaximaleDoorlooptijd(taak) > maximaleDoorloopTijd)
                {
                    maximaleDoorloopTijd = getMaximaleDoorlooptijd(taak);
                }
            }
            return maximaleDoorloopTijd;
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
                totaalUren += deelTaak.minimaleTijdInDagen;
            }

            return totaalUren;
        }
    }
}
