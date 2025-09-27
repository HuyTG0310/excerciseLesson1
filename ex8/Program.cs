
Console.Write("Enter a number: ");

if (double.TryParse(Console.ReadLine(), out double n) && n >= 0)
{
    Console.Write("Enter total value: ");
    if (double.TryParse(Console.ReadLine(), out double tt) && tt > n)
    {
        double percentage = n / tt * 100;
        Console.WriteLine($"Percentage: {percentage:F2}%");

    }
    else
    {
        Console.WriteLine("Invalid total value (must be a positive number and greater than first number)");
    }
}
else
{
    Console.WriteLine("Invalid number, please check again!");
}