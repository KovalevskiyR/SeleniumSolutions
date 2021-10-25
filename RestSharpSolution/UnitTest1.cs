using NUnit.Framework;
using System.Linq;



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
           
            var findUserName = response.Where(u => u.Email.Contains("Shanna@melissa.tv"));

            var street = findUserName.Where(s => s.Address.Street.Contains("Victor Plains"));
            var suite = findUserName.Where(s => s.Address.Suite.Contains("Suite 879"));
            var city = findUserName.Where(c => c.Address.City.Contains("Wisokyburgh"));
            var zip = findUserName.Where(z => z.Address.Zipcode.Contains("90566-7771"));

            foreach (var user in findUserName)
            {
                Assert.That(user.Address.Street, Is.EqualTo("Victor Plains"));
                Assert.That(user.Address.Suite, Is.EqualTo("Suite 879"));
                Assert.That(user.Address.City, Is.EqualTo("Wisokyburgh"));
                Assert.That(user.Address.Zipcode, Is.EqualTo("90566-7771"));

                TestContext.Progress.WriteLine(user.Address.Street);
                TestContext.Progress.WriteLine(user.Address.Suite);
                TestContext.Progress.WriteLine(user.Address.City);
                TestContext.Progress.WriteLine(user.Address.Zipcode);
            }            
        }
    }
}
