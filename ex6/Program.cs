Console.Write("Enter your balance: ");


if (double.TryParse(Console.ReadLine(), out double balance))
{
    Console.Write("Enter amount of money you want to draw $: ");
    if (double.TryParse(Console.ReadLine(), out double draw) && draw >= 0)
    {
        balance -= draw;
        Console.WriteLine($"Your balance after draw money: {balance:N2}$");
    }
    else
    {
        Console.WriteLine("Invalid draw money, please check again!");
    }
}
else
{
    Console.WriteLine("Invalid balance, please enter a number!");
}