
Console.Write("Enter speed (km/h): ");


if (double.TryParse(Console.ReadLine(), out double speed1) && speed1 >= 0)
{
    double speed2 = speed1 / 3.6;

    Console.WriteLine($"{speed1:F2} km/h ≈ {speed2:F2} m/s");
}
else
{
    Console.WriteLine("Speed must be a non negative number, please check again!");
}