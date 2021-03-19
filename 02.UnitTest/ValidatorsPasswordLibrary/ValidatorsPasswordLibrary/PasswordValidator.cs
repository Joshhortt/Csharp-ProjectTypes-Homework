// HOMEWORK - 02 -  Unit Tests
//Build a simple unite test project using a standard library (.NET Core).
// Just get the flow down: (Arrange, Act and Assert).

//The PasswordValidator project is a very simple library to validate passwords with the following constraints:
//The password length must be at least eight characters and a maximum of sixteen characters
//The password must contain one or more uppercase characters
//The password must contain one or more lowercase characters
//The password must contain one or more numeric values
//The password must contain one or more special characters in the list @#!$%

using System.Text.RegularExpressions;

namespace ValidatorsPasswordLibrary
{
    public class PasswordValidator
    {
        public bool IsValid(string password)
        {
            Regex passwordPolicyExpression = new Regex(@"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#!$%]).{8,16})");
            return passwordPolicyExpression.IsMatch(password);
        }
    }
}
