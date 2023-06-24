// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
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


double GetDegre(int numberA, int numberB)
{
    double result = Math.Pow(numberA, numberB);

    Print($"Numbers {numberA} in a power {numberB} will be {result}");
    return result;
}

int numberA = GetNumber("Input number A");
int numberB = GetNumber("Input number B");
GetDegre(numberA, numberB);