
int number = ReadInt("Enter positive number: ");
PrintNumber(number);

int ReadInt(string message)
{
    Console.Write(message);
    uint number;

    while (!(uint.TryParse(Console.ReadLine(), out number)))
        Console.Write("Enter positive number to continue: ");

    return (int)number;
}

void PrintNumber(int number)
{
    if (number < 1)
    {
        return;
    }
        Console.Write(number + " ");
        PrintNumber(number - 1);
}




