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
- zawiera przynajmniej jedną wielką literę ("Password must contain at least one digit")
*/

public class PasswordValidator
{
    public PasswordValidationResult Validate(string password)
    {
        throw new NotImplementedException();
    }
}

public record PasswordValidationResult(bool IsValid, string? ErrorMessage);
