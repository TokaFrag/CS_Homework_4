// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

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


int[] arr = new int[8];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    for (int i = 0; index < length; i++)
    {
        collection[index] = GetNumber($"Input number {index + 1} "); ;
        index++;
    }
    Console.WriteLine($"[{string.Join(", ", collection)}]");
}

FillArray(arr);