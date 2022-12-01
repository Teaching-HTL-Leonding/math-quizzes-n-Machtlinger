Console.Clear();

Console.Write("Please enter the first positive number: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("Please enter the second positive number: ");
int o = int.Parse(Console.ReadLine()!);

int tries1 = 0;

while (n > 1)
{

    if (n % 2 == 0)
    {
        n = n / 2;
    }
    else
    {
        n = n * 3 + 1;
    }

    tries1++;

}

int tries2 = 0;
while (o > 1)
{

    if (o % 2 == 0)
    {
        o = o / 2;
    }
    else
    {
        o = o * 3 + 1;
    }

    tries2++;

}

if (tries1 > tries2)
{
    Console.Write("The first number is longer.");
}
else if (tries2 > tries1)
{
    Console.Write("The second number is longer.");
}