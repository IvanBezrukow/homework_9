int LineOfNumbers(int a, int b)
{
    int sum = a;
    if (a < b)
    {
        a++;
        return sum += LineOfNumbers(a, b);
    }
    return sum;
}




try
{
    Console.WriteLine("Insert any two numbers:");
    Console.Write("Insert the first number = ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Insert the second number = ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 < num2)
        Console.WriteLine($"The sum of numbers between {num1} and {num2} is {LineOfNumbers(num1, num2)}");
    else if (num1 == num2)
        Console.WriteLine("Insert diffrent numbers");
    else if (num1 > num2)
        Console.WriteLine("The first number should be less in value than the second one");
}
catch
{
    Console.WriteLine("You may insert inly numbers");
}