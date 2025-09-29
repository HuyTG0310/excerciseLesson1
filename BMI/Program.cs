//Calculating BMI

Console.Write("Enter your weight (kg): ");

if (double.TryParse(Console.ReadLine(), out double w) && w > 0)
{
    Console.Write("Enter your height (m): ");
    if (double.TryParse(Console.ReadLine(), out double h) && h > 0)
    {
        double BMI = w / (h * h);
        Console.WriteLine($"Your BMI: {BMI:F2}");
    }
    else
    {
        Console.WriteLine("Invalid height, please check again!");
    }
}
else
{
    Console.WriteLine("Invalid weight, please check again!");
}
