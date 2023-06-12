int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Ackermann(m - 1, 1);
    else if (m > 0 && n > 0)
        return Ackermann(m - 1, Ackermann(m, n - 1));
    return n + 1;
}




try
{
    Console.Write("Insert m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Insert n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m >= 0 && n >= 0)
        Console.WriteLine($"A({m},{n}) = {Ackermann(m, n)}");
    else Console.WriteLine("You sould insert non-negative numbers");
}
catch
{
    Console.WriteLine("You may insert only numbers");
}