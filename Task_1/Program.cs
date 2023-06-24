// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void Print(string text)
{
    Console.WriteLine(text);
}

int GetNumber(string description)
{

    int number;
    Print($"{description} => ");

    while (true)
    {
        string temp = Console.ReadLine();
        if (int.TryParse(temp, out number))
        {
            return number;
        }
        Print($"This number \"{temp}\" is not correct. Try again. => ");
    }
}


int GetSum(int number)
{
    int startNumber = number;
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    Print($"The sum of the numbers from the number {startNumber} will be {result}.");
    return result;
}

int number = GetNumber("Input number");
GetSum(number);
