/*he code below of the example using' Test Driven Testing' approach shows one single method, ValidatePassword(), 
in place of thetwo methods implemented before. 
This method has two parameters: password and expectedResult. And the application of the Arrange-Act-Assert pattern 
is based on these parameters.
In addition, you see a set of attributes decorating the method. The first attribute marks the 
ValidatePassword() method as a theory.The other InlineData attributes represent the data to pass to the method. 
Each attribute has a couple of values that are mapped to the method's parameters. 
So, basically, the first value of each InlineData attribute is a possible password,
and the second value is the boolean value expected as a result of the IsValid() method.
In other words, each InlineData attribute represents one invocation of the ValidatePassword() test.*/

using System;
using Xunit;
using ValidatorsPasswordLibrary;

namespace PasswordValidatorTests
{
    public class ValidityTest
    {
        [Theory]
        [InlineData("Th1sIsapassword!", true)]
        [InlineData("thisIsapassword123!", true)]
        [InlineData("Abc$123456", true)]
        [InlineData("Th1s!", false)]
        [InlineData("thisIsAPassword", false)]
        [InlineData("thisisapassword#", false)]
        [InlineData("THISISAPASSWORD123!", false)]
        [InlineData("", false)]

        public void ValidatePassword(string password, bool expectedResult)
        {
            //Arrange
            var passwordValidator = new PasswordValidator();

            //Act
            bool isValid = passwordValidator.IsValid(password);

            //Assert
            Assert.Equal(expectedResult, isValid);
        }
    }
}
/*
In this exmaple of Unit testing, the two cases of password validity tested by the unit tests are 
far from exhaustive.
They are just two simple examples of positive and negative cases, but, of course, 
the possible cases to test are many more. 
You cannot expect to check every possible case, but you can test a significant subset of typical cases. 
This helps in having a greater code coverage for your production code. 
In the password validation example, this means that you hould identify a representative set of valid and invalid passwords.
For each password in these sets, you should apply one of the tests implemented above.
This approach should ensure significant confidence in the correct behavior of the IsValid() method. 
But it requires to replicate the same code for each sample password to test. You know that code replication 
is not a good practice. 

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
*/