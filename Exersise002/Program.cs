
int numberA = ReadInt("Enter first value: ");
int numberB = ReadInt("Enter second value: ");
int sum;

if (numberA < numberB)
    sum = GetSumInRange(numberA, numberB);
else
    sum = GetSumInRange(numberB, numberA);

Console.WriteLine($"Sum of numbers in range from {numberA} to {numberB} = {sum}");

int ReadInt(string message)
{
    Console.Write(message);
    int number;

    while (!(int.TryParse(Console.ReadLine(), out number)))
        Console.Write("Enter positive number to continue: ");

    return number;
}

int GetSumInRange(int numberA, int numberB)
{
    while (numberA < numberB)
    {
    numberA += GetSumInRange(numberA + 1, numberB);
    }

    return numberA;
}

