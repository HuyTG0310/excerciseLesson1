//nhập vào giá tiền, và % giảm giá, tính giá được giảm, và số tiền còn lại phải trả

Console.Write("Enter price: ");


if (double.TryParse(Console.ReadLine(), out double p) && p > 0)
{
    Console.Write("Enter discount percentage (%): ");
    if (double.TryParse(Console.ReadLine(), out double d) && d >= 0 && d <= 100)
    {
        double discountValue = p * d / 100;
        p -= discountValue;
        Console.WriteLine($"Discount value: {discountValue:C2}");
        Console.WriteLine($"Price after discount: {p:C2}");
    }
    else
    {
        Console.WriteLine("Invalid discount, please enter again!");
    }
}
else
{
    Console.WriteLine("Invalid price, please enter again!");
}