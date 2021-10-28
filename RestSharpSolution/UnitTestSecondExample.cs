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

            //for (var i = 0; i < response.Count; i++)
            //{
            //    Assert.That(response[i].Email, Is.Not.Null);
            //    TestContext.Progress.WriteLine(response[i].Email);
            //}

            int countNotEmptyEmails = response.Where(x => x.Email == null).Count();

            Assert.That(countNotEmptyEmails, Is.Zero);
        }

        [Test]
        public void Test2()
        {
            var usersList = new ApiUsers();
            var response = usersList.GetUsers();

            var findUserName = response.Where(u => u.Email.Equals("Shanna@melissa.tv")).FirstOrDefault();
                Assert.That(findUserName.Address.Street, Is.EqualTo("Victor Plains"));
                Assert.That(findUserName.Address.Suite, Is.EqualTo("Suite 879"));
                Assert.That(findUserName.Address.City, Is.EqualTo("Wisokyburgh"));
                Assert.That(findUserName.Address.Zipcode, Is.EqualTo("90566-7771"));

                //TestContext.Progress.WriteLine(user.Address.Street);
                //TestContext.Progress.WriteLine(user.Address.Suite);
                //TestContext.Progress.WriteLine(user.Address.City);
                //TestContext.Progress.WriteLine(user.Address.Zipcode);
        }
    }
}