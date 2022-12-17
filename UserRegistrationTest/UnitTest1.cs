using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexWithLambdaAndMSTest;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("FirstName")]
        [DataRow("Anil", true)]
        [DataRow("anil", false)]
        [DataRow("xy", false)]
        public void TestFirstName(string fName, bool result)
        {
            ///AAA -> Arrange Act Assert
            Patterns p = new Patterns();
            //Act
            bool actual = p.FirstName(fName);
            //Assert
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        [TestCategory("LastName")]
        [DataRow("Bamne", true)]
        [DataRow("anil", false)]
        [DataRow("xyz", false)]
        public void TestLastName(string fName, bool result)
        {
            ///AAA -> Arrange Act Assert
            Patterns p = new Patterns();
            //Act
            bool actual = p.LastName(fName);
            //Assert
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        [TestCategory("Email")]
        [DataRow("abc.xyz@bl.co.in", true)]
        [DataRow("anil.12@gmail.com", false)]
        [DataRow("abc.xyz@bl.com", false)]
        public void TestEmail(string email, bool result)
        {
            ///AAA -> Arrange Act Assert
            Patterns p = new Patterns();
            //Act
            bool actual = p.Email(email);
            //Assert
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        [TestCategory("MobileNum")]
        [DataRow("91 8152817066", true)]
        [DataRow("99999999", false)]
        [DataRow("9181528170", false)]
        public void MobileNum(string mobile, bool result)
        {
            ///AAA -> Arrange Act Assert
            Patterns p = new Patterns();
            //Act
            bool actual = p.MobileNum(mobile);
            //Assert
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        [TestCategory("Password")]    //Minimum 8 charecters,1 upper case,1 number and 1Special charecter
        [DataRow("AnilBamn@1234", true)]
        [DataRow("abxu1", false)]
        [DataRow("aaaAaaaa#22aaa", true)]
        public void Password(string password, bool result)
        {
            ///AAA -> Arrange Act Assert
            Patterns p = new Patterns();
            //Act
            bool actual = p.Password(password);
            //Assert
            Assert.AreEqual(result, actual);
        }

        /// <summary>
        /// Test Methods for Entries with Parameter Happy or Sad message.
        /// </summary>
        /// <param name="message"></param>


        [TestMethod]
        [TestCategory("Entry check UC 10")]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessfulForFirstName(string message)
        {
            Patterns pattern = new Patterns(message);
            string expected = pattern.CheckForFirstName();
            Assert.AreEqual(expected, "Entry is successful");
        }

        [TestMethod]
        [TestCategory("Entry check UC 10")]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessfulForFirstName(string message)
        {
            Patterns pattern = new Patterns(message);
            string expected = pattern.CheckForFirstName();
            Assert.AreEqual(expected, "Entry is not successful");
        }
        [TestMethod]
        [TestCategory("Entry check UC 10")]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessfulForLastName(string message)
        {
            Patterns pattern = new Patterns(message);
            string expected = pattern.CheckForLastName();
            Assert.AreEqual(expected, "Entry is successful");
        }
        [TestMethod]
        [TestCategory("Entry check UC 10")]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessfulForLastName(string message)
        {
            Patterns pattern = new Patterns(message);
            string expected = pattern.CheckForLastName();
            Assert.AreEqual(expected, "Entry is not successful");
        }
        [TestMethod]
        [TestCategory("Entry check UC 10")]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessfulForEmail(string message)
        {
            Patterns pattern = new Patterns(message);
            string expected = pattern.CheckForEmail();
            Assert.AreEqual(expected, "Entry is successful");
        }
        [TestMethod]
        [TestCategory("Entry check UC 10")]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessfulForEmail(string message)
        {
            Patterns pattern = new Patterns(message);
            string expected = pattern.CheckForEmail();
            Assert.AreEqual(expected, "Entry is not successful");
        }
        [TestMethod]
        [TestCategory("Entry check UC 10")]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessfulForMobile(string message)
        {
            Patterns pattern = new Patterns(message);
            string expected = pattern.CheckForMobile();
            Assert.AreEqual(expected, "Entry is successful");
        }
        [TestMethod]
        [TestCategory("Entry check UC 10")]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessfulForMobile(string message)
        {
            Patterns pattern = new Patterns(message);
            string expected = pattern.CheckForMobile();
            Assert.AreEqual(expected, "Entry is not successful");
        }
        [TestMethod]
        [TestCategory("Entry check UC 10")]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessfulForPassword(string message)
        {
            Patterns pattern = new Patterns(message);
            string expected = pattern.CheckForPassword();
            Assert.AreEqual(expected, "Entry is successful");
        }
        [TestMethod]
        [TestCategory("Entry check UC 10")]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessfulForPassword(string message)
        {
            Patterns pattern = new Patterns(message);
            string expected = pattern.CheckForPassword();
            Assert.AreEqual(expected, "Entry is not successful");
        }


        [TestMethod]
        [TestCategory("Entry check for multiple Email samples UC 11")]
        public void GivenParameterizedTest_ToValidateMultipleEntries_ReturnEntryIsSucessful()
        {
            Patterns pattern = new Patterns();
            var result = pattern.checkMultipleEntriesOfEmail("abc@yahoo.com", "abc-100@yahoo.com", "abc@gmail.com.com", "abc+100@gmail.com");
            Assert.AreEqual(result, "Entry is successful");
        }
    }
}
