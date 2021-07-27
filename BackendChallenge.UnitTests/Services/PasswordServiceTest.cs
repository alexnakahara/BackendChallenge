using BackendChallenge.API.Services;
using Xunit;

namespace BackendChallenge.UnitTests
{
    public class PasswordServiceTest
    {

        // AAA
        // GiveWhenThen
        [Theory]
        [InlineData("")] // false  
        [InlineData("aa")]// false  
        [InlineData("ab")] // false  
        [InlineData("AAAbbbCc")] // false  
        [InlineData("AbTp9!foo")] // false  
        [InlineData("AbTp9!foA")] // false
        [InlineData("AbTp9 fok")] // false
        [InlineData("AbTp9!fok")] // true
        public void IsValidPassword_GeneralValidation_ReturnTrue(string password)
        {
            // Arrange
            PasswordService authorizeService = new PasswordService();
            // Act
            bool result = authorizeService.IsValidPassword(password);

            // Assert
            Assert.True(result, $"Password: {password} is invalid!");
        }

        [Theory]
        [InlineData("123456789")]
        public void HasMinLength_AtLeastLength9_ReturnTrue(string password)
        {
            PasswordService authorizeService = new PasswordService();
            bool result = authorizeService.HasMinLength(password);

            Assert.True(result, $"Password: {password} doesn't have a minimum length");
        }

        [Theory]
        [InlineData("AlexanderNakahara")]
        public void HasWhiteSpace_StringWithoutWhiteSpace_ReturnFalse(string password)
        {
            PasswordService authorizeService = new PasswordService();
            bool result = authorizeService.HasWhiteSpace(password);

            Assert.False(result, $"Password: {password} can't have whitespace");
        }

        [Theory]
        [InlineData("alexanderNakahara")]
        public void HasUpperCase_StringHasSomeCharUpperCase_ReturnTrue(string password)
        {
            PasswordService authorizeService = new PasswordService();
            bool result = authorizeService.HasUpperCase(password);

            Assert.True(result, $"Password: {password} must have some letter in upper case");
        }

        [Theory]
        [InlineData("ALEXANDERcAAAAA")]
        public void HasLowerCase_StringHasSomeCharLowerCase_ReturnTrue(string password)
        {
            PasswordService authorizeService = new PasswordService();
            bool result = authorizeService.HasLowerCase(password);

            Assert.True(result, $"Password: {password} must have some letter in lower case");
        }

        [Theory]
        [InlineData("alex1naka")]
        public void HasNumberCase_StringHasSomeNumber_ReturnTrue(string password)
        {
            PasswordService authorizeService = new PasswordService();
            bool result = authorizeService.HasNumber(password);

            Assert.True(result, $"Password: {password} must have some number");
        }

        [Theory]
        [InlineData("@lex^&")]
        public void HasSpecialChar_StringHasSomeSpecialChar_ReturnTrue(string password)
        {
            PasswordService authorizeService = new PasswordService();
            bool result = authorizeService.HasSpecialChar(password);

            Assert.True(result, $"Password: {password} must have some special character: '!@#$%^&*()-+' ");
        }

        [Theory]
        [InlineData("alex")]
        public void HasDuplicatedChar_WhenHasDuplicatedChar_ReturnFalse(string password)
        {
            PasswordService authorizeService = new PasswordService();
            bool result = authorizeService.HasDuplicatedChar(password);

            Assert.False(result, $"Password: {password} can't duplicate characters");
        }

    }
}
