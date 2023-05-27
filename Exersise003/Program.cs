
int m = ReadInt("Enter first value: ");
int n = ReadInt("Enter second value: ");
Console.WriteLine($"Counting Akkerman function result = {AkkFunc(m, n)}");

int ReadInt(string message)
{
    Console.Write(message);
    int number;

    while ((int.TryParse(Console.ReadLine(), out number)) == false || number < 0)
        Console.Write("Enter positive number to continue: ");

    return number;
}

int AkkFunc(int m, int n)
{
    if (m == 0)
        return n + 1;
    
    else if (n == 0)
        return AkkFunc(m - 1, 1);
    else
        return AkkFunc(m - 1, AkkFunc(m, n - 1));
}