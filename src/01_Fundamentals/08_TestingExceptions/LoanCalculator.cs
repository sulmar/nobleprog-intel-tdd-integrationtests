namespace TestingExceptions;

/*
 Założenia: Kalkulator oblicza miesięczną ratę kredytu.
 Oczekuje:
 - dodatniego kapitału (principal > 0),
 - oprocentowania w zakresie 0–100%,
 - liczby rat większej niż 0.
 - jeśli warunki są spełnione to rata powinna być większa od zera.

   TODO: Jeśli te warunki nie są spełnione niech rzuca ArgumentOutOfRangeException z odpowiednim komunikatem:
   // Principal must be greater than zero
   // Interest rate must be between 0 and 100
   // Number of months must be greater than zero
 */

public class LoanCalculator
{
    /// <summary>
    /// Funkcja oblicza miesięczną ratę kredytu.
    /// </summary>
    /// <param name="principal">Kapitał</param>
    /// <param name="annualInterestRatePercent">Oprogramowanie w skali roku</param>
    /// <param name="numberOfMonths">ilość miesięcy (ilość rat)</param>
    /// <returns></returns>
    public decimal CalculateMonthlyPayment(decimal principal, double annualInterestRatePercent, int numberOfMonths)
    {
        double monthlyRate = (annualInterestRatePercent / 100) / 12;
        double denominator = Math.Pow(1 + monthlyRate, numberOfMonths) - 1;

        if (denominator == 0)
            return principal / numberOfMonths; // zero interest

        double monthlyPayment = (double)principal * monthlyRate * Math.Pow(1 + monthlyRate, numberOfMonths) / denominator;
        return (decimal)Math.Round(monthlyPayment, 2);
    }
}