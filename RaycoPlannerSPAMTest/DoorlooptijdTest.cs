using RaycoPlannerSPAM;

namespace RaycoPlannerSPAMTest
{
    public class DoorlooptijdTest
    {
        private ProjectSoort projectSoort;
        private string projectSoortNaam = "Test project conform PI8 opdracht 7";
        [SetUp]
        public void Setup()
        {
            projectSoort = new ProjectSoort(projectSoortNaam);
            /* Hier maken we de taken aan zoals getekent in opdracht 7. Voor de lege blokjes aan het begin en eind van
             * het project gebruiken we een taak met minimale en maximale duur van 0. Voor het nummeren zijn we uit gegaan
             * van het diagram van links naar rechts en boven naar onder.
             */
            Deeltaak taak1 = new Deeltaak("", 1, 0, 0, "Student", new List<Deeltaak>());
            Deeltaak taak2 = new Deeltaak("", 2, 2, 8, "Student", new List<Deeltaak>());
            Deeltaak taak3 = new Deeltaak("", 3, 5, 8, "Student", new List<Deeltaak>());
            Deeltaak taak4 = new Deeltaak("", 4, 8, 12, "Student", new List<Deeltaak>());
            Deeltaak taak5 = new Deeltaak("", 5, 1, 2, "Student", new List<Deeltaak>());
            Deeltaak taak6 = new Deeltaak("", 6, 5, 12, "Student", new List<Deeltaak>());
            Deeltaak taak7 = new Deeltaak("", 7, 20, 32, "Student", new List<Deeltaak>());
            Deeltaak taak8 = new Deeltaak("", 8, 10, 16, "Student", new List<Deeltaak>());
            Deeltaak taak9 = new Deeltaak("", 9, 10, 16, "Student", new List<Deeltaak>());
            Deeltaak taak10 = new Deeltaak("", 10, 12, 20, "Student", new List<Deeltaak>());
            Deeltaak taak11 = new Deeltaak("", 11, 5, 12, "Student", new List<Deeltaak>());
            Deeltaak taak12 = new Deeltaak("", 12, 3, 6, "Student", new List<Deeltaak>());
            Deeltaak taak13 = new Deeltaak("", 13, 2, 10, "Student", new List<Deeltaak>());
            Deeltaak taak14 = new Deeltaak("", 14, 0, 0, "Student", new List<Deeltaak>());

            /* Vervolgens voegen we de afhankelijkheden tussen de taken toe. Wederom werken we hier van links naar rechts
             * en van boven naar onder.
             */

            taak2.voorgaandeTaak.Add(taak1);
            
            taak3.voorgaandeTaak.Add(taak1);
            
            taak4.voorgaandeTaak.Add(taak1);
            
            taak5.voorgaandeTaak.Add(taak3);
            
            taak6.voorgaandeTaak.Add(taak2);
            taak6.voorgaandeTaak.Add(taak5);

            taak7.voorgaandeTaak.Add(taak4);

            taak8.voorgaandeTaak.Add(taak4);

            taak9.voorgaandeTaak.Add(taak7);

            taak10.voorgaandeTaak.Add(taak8);

            taak11.voorgaandeTaak.Add(taak6);

            taak12.voorgaandeTaak.Add(taak6);
            taak12.voorgaandeTaak.Add(taak9);

            taak13.voorgaandeTaak.Add(taak10);

            taak14.voorgaandeTaak.Add(taak11);
            taak14.voorgaandeTaak.Add(taak12);
            taak14.voorgaandeTaak.Add(taak13);
        }

        [Test]
        public void TestTest()
        {
            /* We hebben met de hand berekent dat het project een minimale doorlooptijd heeft van 41 dagen en een
             * maximale doorlooptijd van 66 dagen.
             */
            Assert.That(projectSoort.berekenMinimaleDoorlooptijd(), Is.EqualTo(41));
            Assert.That(projectSoort.berekenMaximaleDoorlooptijd(), Is.EqualTo(66));
        }
    }
}