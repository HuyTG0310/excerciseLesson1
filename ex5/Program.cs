Console.Write("Enter amount of money in USD: ");

if (double.TryParse(Console.ReadLine(), out double USD) && USD >= 0)
{
    Console.Write("Exchange rate from USD to VND: ");
    if (double.TryParse(Console.ReadLine(), out double rate) && rate > 0)
    {
        double VND = USD * rate;
        Console.WriteLine($"${USD:N2} ≈ {VND:N2} VND");
    }
    else
    {
        Console.WriteLine("Invalid exchange rate, please check again!");
    }
}
else
{
    Console.WriteLine("Invalid amount of money, please check again!");
}