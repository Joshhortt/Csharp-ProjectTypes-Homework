

using System;
using Xunit;
using ValidatorsPasswordLibrary;

namespace PasswordValidatorTests
{
    public class ValidityTest
    {
        [Fact]
        public void ValidPassword()
        {
            //Arrange
            var passwordValidator = new PasswordValidator();
            const string password = "Th1SiS0PaSsWorD9!";

            //Act
            bool isValid = passwordValidator.IsValid(password);

            //Assert
            Assert.True(isValid, $"The password {password} is not valid");
        }

        [Fact]
        public void NotValidPassword()
        {
            //Arrange
            var passwordValidator = new PasswordValidator();
            const string password = "ThisIsAPassword";

            //Act
            bool isValid = passwordValidator.IsValid(password);

            //Assert
            Assert.False(isValid, $"The password {password} should not be valid!");
        }
    }
}
