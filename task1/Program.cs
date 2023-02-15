

int[] numbers = GetArray("Введите числа через запятую без пробела:");
PrintArray(numbers);
Console.WriteLine();

int answer = CountNumbers(numbers);
Console.WriteLine($"Количество элементов больше 0: {answer}");


int[] GetArray(string message)
{
    Console.WriteLine(message);
    string str = Console.ReadLine();

    string[] input = str.Split(",");
    int[] array = new int[input.Length];
    for (int i = 0; i < input.Length; i++)
    {
        int.TryParse(input[i], out array[i]);

    }
    return 
    array.Where(e => e != 0).ToArray();
}



void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
}



int CountNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            count++;
        }
    }
    return count;
}

