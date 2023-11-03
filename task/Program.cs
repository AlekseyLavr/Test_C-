// Задача:
// Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 

string[] InputArray() // Вводим начальный массив
{
    Console.WriteLine("Введите строковые значения через пробел: ");
    return Console.ReadLine().Split(" ");
}

int CountArray(string[] array, int n) // Считаем количество символов
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
            count++;
    }
    return count;
}

string[] ReliseArray(string[] input, int n) // Массив с заданным количеством символов
{
    string[] result = new string[CountArray(input, n)];
    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            result[j] = input[i];
            j++;
        }
    }
    return result;
}

Console.Clear();
string[] input = InputArray();
string[] output = ReliseArray(input, 3);
Console.Clear();
Console.WriteLine("Начальный строковый массив:");
Console.WriteLine($"[{string.Join(", ", input)}]");
Console.WriteLine();
Console.WriteLine("Строковый массив с заданным числом символов:");
Console.WriteLine($"[{string.Join(", ", output)}]");