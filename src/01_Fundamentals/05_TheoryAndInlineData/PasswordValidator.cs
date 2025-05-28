using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheoryAndInlineData;

/*
  
🔍 Wymagania:
Hasło jest ważne, jeśli:
- nie może być puste ("Password cannot be empty")
- zawiera co najmniej 8 znaków ("Password must be at least 8 characters long")
- zawiera przynajmniej jedną cyfrę ("Password must contain at least one digit")
- zawiera przynajmniej jedną wielką literę ("Password must contain at least one big letter")
*/

public class PasswordValidator
{
    public PasswordValidationResult Validate(string password)
    {
        if (string.IsNullOrEmpty(password))
            return new PasswordValidationResult(false, "Password cannot be empty");
        
        if (password.Length < 8)
            return new PasswordValidationResult(false, "Password must be at least 8 characters long");
        
        return new PasswordValidationResult(true, string.Empty);
    }
}

public record PasswordValidationResult(bool IsValid, string? ErrorMessage);

public class PasswordValidatorTests
{
    [Theory]
    [InlineData("", false, "Password cannot be empty")]
    [InlineData("abc", false, "Password must be at least 8 characters long")]
    [InlineData("012345678", false, "Password must contain at least one digit")]
    [InlineData("abcdefgh9", false, "Password must contain at least one big letter")]
    [InlineData("Abcdefgh9", true, "")]
    public void Validate_PassPassword_ReturnsExpectedResult(string password, bool expectedIsValid,
        string expectedErrorMessage)
    {
        // Arrange
        var validator = new PasswordValidator();
        
        // Act
        var result = validator.Validate(password);
        
        // Assert
        Assert.Equal(expectedIsValid, result.IsValid);
        Assert.Equal(expectedErrorMessage, result.ErrorMessage);
    }
}
