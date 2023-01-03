using RaycoPlannerSPAM;

namespace RaycoPlannerSPAMTest
{
    public class TaakLusTestClass
    {
        private ProjectSoort projectSoortZonderLus;
        private Deeltaak taak1;
        private Deeltaak taak2;
        private Deeltaak taak3;

        private ProjectSoort projectSoortMetLus;
        private Deeltaak taak4;
        private Deeltaak taak5;

        [SetUp]
        public void Setup()
        {
            // Dit project bestaat uit 3 taken die elkaar opvolgen. Hier zit dus geen lus in.
            projectSoortZonderLus = new ProjectSoort("Project zonder lus");
            taak1 = new Deeltaak("Taak 1", 1, 2, 4, "Projectmedewerker", null);
            taak2 = new Deeltaak("Taak 2", 2, 2, 4, "Projectmedewerker", new List<Deeltaak> { taak1 });
            taak3 = new Deeltaak("Taak 3", 3, 2, 4, "Projectmedewerker", new List<Deeltaak> { taak2 });

            // Dit project bestaat uit 2 taken die elkaar als voorgaande taak hebben. Dit is dus een lus.
            projectSoortMetLus = new ProjectSoort("Project met lus");
            taak4 = new Deeltaak("Taak 4", 4, 2, 4, "Projectmedewerker", new List<Deeltaak> { taak5 });
            taak5 = new Deeltaak("Taak 5", 5, 2, 4, "Projectmedewerker", new List<Deeltaak> { taak4 });
        }

        [Test]
        public void TestProjectZonderLus()
        {
            Assert.IsFalse(projectSoortZonderLus.CheckLus());
        }

        [Test]
        public void TestProjectMetLus()
        {
            Assert.IsTrue(projectSoortMetLus.CheckLus());
        }
    }
} 