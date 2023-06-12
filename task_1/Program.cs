string LineOfNumbers(int num)
{
    if (num == 1) return $"{1}";
    return $"{num}, " + $"{LineOfNumbers(num - 1)}";
}




try
{
    Console.Write("Insert any number (N) = ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 1)
    {
        Console.Write("The generated line of numbers from N to 1 ===> ");
        Console.WriteLine(LineOfNumbers(num));
    }
    else
    {
        Console.WriteLine("Insert a number which is at least greater than 1");
    }
}
catch
{
    Console.WriteLine("You may inser only numbers");
}