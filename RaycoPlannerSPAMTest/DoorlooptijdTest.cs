using RaycoPlannerSPAM;

namespace RaycoPlannerSPAMTest
{
    public class DoorlooptijdTest
    {
        private ProjectSoort projectSoort;
        private string projectSoortNaam = "Test project";
        [SetUp]
        public void Setup()
        {
            projectSoort = new ProjectSoort(projectSoortNaam);
        }

        [Test]
        public void TestTest()
        {
            // Test of ons test project naar behoren werkt en objecten kan maken uit het app project
            Assert.AreEqual(projectSoort.naam, projectSoortNaam);
        }
    }
}