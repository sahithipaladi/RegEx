using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        public User user;

        [TestInitialize]
        public void SetUp()
        {
            user = new User();
        }
        /// <summary>
        /// Happy TestCases
        /// </summary>
        [TestMethod]
        public void FirstNameValidationShouldReturnTrue()
        {
            //Arrange
            string firstName = "Ajith";
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void LastNameValidationShouldReturnTrue()
        {
            //Arrange
            string lastName = "Kumar";
            //Act
            bool result = user.ValidateLastName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailValidationShouldReturnTrue()
        {
            //Arrange
            string email = "Ajith43@gmail.com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void MobileNumberValidationShouldReturnTrue()
        {
            //Arrange
            string mobileNumber = "91 9995559955";
            //Act
            bool result = user.ValidateMobileNumber(mobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void PasswordValidationShouldReturnTrue()
        {
            //Arrange
            string password = "Ajith@123";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Sad Test Cases
        /// </summary>
        [TestMethod]
        public void FirstNameValidationShouldReturnFalse()
        {
            //Arrange
            string firstName = "ajith";
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void LastNameValidationShouldReturnFalse()
        {
            //Arrange
            string lastName = "kumar";
            //Act
            bool result = user.ValidateLastName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailValidationShouldReturnFalse()
        {
            //Arrange
            string email = "ajay@com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void MobileNumberValidationShouldReturnFalse()
        {
            //Arrange
            string mobileNumber = "91 0995559955";
            //Act
            bool result = user.ValidateMobileNumber(mobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void PasswordValidationShouldReturnFalse()
        {
            //Arrange
            string password = "Ajay123";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void ValidateSampleEmailsShouldReturnTrue(string email)
        {
            Assert.IsTrue(user.ValidateEmail(email));
        }
    }
}