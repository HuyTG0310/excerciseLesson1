

Console.Write("Enter amount of money: ");

if (double.TryParse(Console.ReadLine(), out double m) && m > 0)
{
    Console.Write("Enter VAT percentage (%): ");

    if (double.TryParse(Console.ReadLine(), out double VAT) && VAT >= 0 && VAT <= 100)
    {
        m += m * VAT / 100;
        Console.WriteLine($"After applied VAT: {m:C2}");
    }
    else
    {
        Console.WriteLine("Invalid VAT, please check again!");
    }
}
else
{
    Console.WriteLine("Invalid amount of money, please check again!");
}
