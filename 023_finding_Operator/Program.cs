Console.Clear();

Console.WriteLine("Please enter your first number: ");
double num1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Please enter your second number: ");
double num2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Please enter your result :");
double result = double.Parse(Console.ReadLine()!);

if (Math.Round(num1 + num2, 2) == result || Math.Round(num2 + num1, 2) == result)

{
    Console.WriteLine("The Operator is +");
}
else if (Math.Round(num1 - num2, 2) == result || Math.Round(num2 - num1, 2) == result)
{
    Console.WriteLine("The Operator is -");
}
else if (Math.Round(num1 * num2, 2) == result || Math.Round(num2 * num1, 2) == result)

{
    Console.WriteLine("The Operator is *");
}
else if (Math.Round(num1 / num2, 2) == result || Math.Round(num2 / num1, 2) == result)
{
    Console.WriteLine("The Operator is /");
}
else if (Math.Round(num1 % num2, 2) == result || Math.Round(num2 % num1, 2) == result)
{
    Console.WriteLine("The Operator is %");
}
else if (Math.Pow(num1 , num2 ) == result || Math.Pow(num2 , num1 ) == result)
{
    Console.WriteLine("The Operator is ^ ");
}
