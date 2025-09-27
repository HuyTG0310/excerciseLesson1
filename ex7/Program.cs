
Console.Write("Enter distance (km): ");

if (double.TryParse(Console.ReadLine(), out double distance) && distance > 0)
{
    Console.Write("Enter time to finished (hour): ");

    if (double.TryParse(Console.ReadLine(), out double time) && time > 0)
    {
        double speed = distance / time;
        Console.WriteLine($"Average speed = {speed:F2} km/h");
    }
    else
    {
        Console.WriteLine("Invalid time, please check again!");
    }
    
}
else
{
    Console.WriteLine("Invalid distance, please check again!");
}