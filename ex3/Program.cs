Console.Write("Enter minutes: ");

if (int.TryParse(Console.ReadLine(), out int m) && m >= 0)
{
    int h = m / 60;
    m %= 60;
    string hour = (h == 1) ? "hour" : "hours";
    string minute = (m == 1) ? "minute" : "minutes";
    Console.WriteLine($"{h} {hour}, {m} {minute}");
}
else
{
    Console.WriteLine("Invalid minutes, please check again!");
}
