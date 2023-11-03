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
