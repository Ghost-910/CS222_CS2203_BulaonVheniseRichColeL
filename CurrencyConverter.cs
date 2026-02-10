using System;

class CurrencyConverter
{
    static void Main()
    {
        Console.Write("Enter amount in USD: ");
        double usd = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter exchange rate from USD to EUR: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        double eur = usd * rate;

        Console.WriteLine($"Amount in EUR: {eur:F2}");
    }
}
