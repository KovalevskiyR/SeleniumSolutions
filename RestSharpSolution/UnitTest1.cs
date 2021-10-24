using NUnit.Framework;



namespace ApiAutotestPage130
{
    public class Tests
    {
        [SetUp]
        public void Indent()
        {
            TestContext.Progress.WriteLine("-------------------------------");
        }
        
        [Test]
        public void Test1()
        {
            var usersList = new ApiUsers();
            var response = usersList.GetUsers();

            for (var i = 0; i < response.Count; i++)
            {
                Assert.That(response[i].Email, Is.Not.Null);
                TestContext.Progress.WriteLine(response[i].Email);
            }          
        }

        [Test]
        public void Test2()
        {
            var usersList = new ApiUsers();
            var response = usersList.GetUsers();
           
                Assert.Multiple(() =>
               {
                   Assert.AreEqual("Victor Plains", response[1].Address.Street);
                   Assert.AreEqual("Suite 879", response[1].Address.Suite);
                   Assert.AreEqual("Wisokyburgh", response[1].Address.City);
                   Assert.AreEqual("90566-7771", response[1].Address.Zipcode);
                   
                   TestContext.Progress.WriteLine(response[1].Address.Street);
                   TestContext.Progress.WriteLine(response[1].Address.Suite);
                   TestContext.Progress.WriteLine(response[1].Address.City);
                   TestContext.Progress.WriteLine(response[1].Address.Zipcode);
               });
        }
    }
}
