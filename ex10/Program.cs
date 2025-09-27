
//giả sử lượng calories tiêu thụ trên 1 phút của các môn thể thao
const int gymCalories = 7;
const int runningCalories = 9;
const int cyclingCalories = 8;
const int swimmingCalories = 10;

Console.Write("Enter number of minutes you worked out: ");

if (double.TryParse(Console.ReadLine(), out double minutes) && minutes >= 0)
{
    Console.WriteLine("Kinds of workout:");
    Console.WriteLine("1. Gym");
    Console.WriteLine("2. Running");
    Console.WriteLine("3. Cycling");
    Console.WriteLine("4. Swimming");
    Console.Write("Choose your kind of workout by number: ");
    
    if (int.TryParse(Console.ReadLine(), out int c) && c >= 1 && c <= 4)
    {
        double calories;
        if (c == 1)
            calories = minutes * gymCalories;
        else if (c == 2)
            calories = minutes * runningCalories;
        else if (c == 3)
            calories = minutes * cyclingCalories;
        else
            calories = minutes * swimmingCalories;

        Console.WriteLine($"You burned {calories:N} calories");
    }
    else
    {
        Console.WriteLine("Your choice must be a number from 1 to 4, please try again !");
    }

}
else
{
    Console.WriteLine("Minutes must be a non negative number, please check again!");
}

