using RaycoPlannerSPAM;

namespace RaycoPlannerSPAMTest
{
    public class DoorlooptijdTest
    {
        private ProjectSoort projectSoort;
        private string projectSoortNaam = "Test project conform PI8 opdracht 7";
        private ProjectSoort simpelProjectSoort;
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

            // Als laatste voegen we alle taken toe aan onze projectsoort
            projectSoort.addDeeltaak(taak1);
            projectSoort.addDeeltaak(taak2);
            projectSoort.addDeeltaak(taak3);
            projectSoort.addDeeltaak(taak4);
            projectSoort.addDeeltaak(taak5);
            projectSoort.addDeeltaak(taak6);
            projectSoort.addDeeltaak(taak7);
            projectSoort.addDeeltaak(taak8);
            projectSoort.addDeeltaak(taak9);
            projectSoort.addDeeltaak(taak10);
            projectSoort.addDeeltaak(taak11);
            projectSoort.addDeeltaak(taak12);
            projectSoort.addDeeltaak(taak13);
            projectSoort.addDeeltaak(taak14);


            // We maken ook een simpel project voor een eenvoudigere test
            simpelProjectSoort = new ProjectSoort("Eenvoudig project");
            
            Deeltaak simpelTaak1 = new Deeltaak("", 1, 2, 3, "Student", new List<Deeltaak>());
            Deeltaak simpelTaak2 = new Deeltaak("", 2, 1, 2, "Student", new List<Deeltaak>());
            Deeltaak simpelTaak3 = new Deeltaak("", 3, 1, 2, "Student", new List<Deeltaak>());
            Deeltaak simpelTaak4 = new Deeltaak("", 4, 5, 8, "Student", new List<Deeltaak>());
            Deeltaak simpelTaak5 = new Deeltaak("", 5, 3, 4, "Student", new List<Deeltaak>());

            simpelTaak5.voorgaandeTaak.Add(simpelTaak3);
            simpelTaak5.voorgaandeTaak.Add(simpelTaak4);

            simpelTaak3.voorgaandeTaak.Add(simpelTaak1);
            simpelTaak3.voorgaandeTaak.Add(simpelTaak2);

            simpelProjectSoort.addDeeltaak(simpelTaak1);
            simpelProjectSoort.addDeeltaak(simpelTaak2);
            simpelProjectSoort.addDeeltaak(simpelTaak3);
            simpelProjectSoort.addDeeltaak(simpelTaak4);
            simpelProjectSoort.addDeeltaak(simpelTaak5);
        }

        // Het simpele project heeft een minimale doorlooptijd van 3 en een maximale doorlooptijd van 5
        [Test]
        public void simpelBerekenMinimaleDoorlooptijdTest()
        {
            Assert.That(simpelProjectSoort.berekenMinimaleDoorlooptijd(), Is.EqualTo(8));
        }

        [Test]
        public void simpelBerekenMaximaleDoorlooptijdTest()
        {
            Assert.That(simpelProjectSoort.berekenMaximaleDoorlooptijd(), Is.EqualTo(12));
        }

        /* We hebben met de hand berekent dat het project een minimale doorlooptijd heeft van 41 dagen en een
         * maximale doorlooptijd van 66 dagen.
         */
        [Test]
        public void BerekenMinimaleDoorlooptijdTest()
        {
            Assert.That(projectSoort.berekenMinimaleDoorlooptijd(), Is.EqualTo(41));   
        }

        [Test]
        public void berekenMaximaleDoorlooptijdTest()
        {
            Assert.That(projectSoort.berekenMaximaleDoorlooptijd(), Is.EqualTo(66));
        }
    }
}