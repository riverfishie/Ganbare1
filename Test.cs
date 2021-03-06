using NUnit.Framework;

namespace Ganbare1
{
    [TestFixture]
    public class TestPerson
    {

        [Test]
        public void TestFullName()
        {

            Person person = new Person();
            person.Lname = "Doe";
            person.Mname = "Roe";
            person.Fname = "John";

            string actual = person.GetFullName();
            string expected = "John Roe Doe";
            Assert.AreEqual(expected, actual,
        "The GetFullName returned a different Value");
        }
    }
}
