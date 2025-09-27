//Ex1: tinh so ngay trong tuan va so ngay le

Console.Write("Enter number of day: ");
if (int.TryParse(Console.ReadLine(), out int d) && d > 0)
{
    int weeks = d / 7;
    int daysLeft = d % 7;

    string weekStr = (weeks == 1) ? "week" : "weeks";
    string dayStr = (daysLeft == 1) ? "day" : "days";

    Console.WriteLine($"{weeks} {weekStr}, {daysLeft} {dayStr}");
}
else
{
    Console.WriteLine("Invalid input, please check again!");
}