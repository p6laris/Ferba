using FerbaTesting.Data;


namespace FerbaTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        
        //Test One
        [Test]
        public void TestLazyInit()
        {
            //Init
            Lazy<List<Items>> items = new Lazy<List<Items>>(FerbaTesting.Data.Data.GetData());

            //Assume
            Assert.IsTrue(items.Value[0].Name.Any());
        }
        //Test Two
        [Test]
        public void TestSound()
        {
            //Init
            Lazy<List<Items>> items = new Lazy<List<Items>>(FerbaTesting.Data.Data.GetData());

            //Assume
            Assert.IsTrue(items.Value[0].Sound.Any());
        }
        //Test Three
        [Test]
        public void TestDescription()
        {
            //Init
            Lazy<List<Items>> items = new Lazy<List<Items>>(FerbaTesting.Data.Data.GetData());

            //Assume
            Assert.IsTrue(items.Value[0].Description.Any());
        }
        //Test Four
        [Test]
        public void TestImage() 
        {
            //Init
            Lazy<List<Items>> items = new Lazy<List<Items>>(FerbaTesting.Data.Data.GetData());

            //Assume
            Assert.IsTrue(items.Value[0].Image.Any());
        }
    }
}