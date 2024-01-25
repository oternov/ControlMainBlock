string[] array = new string[5];
string[] arr = new string[array.Length];
int k = 0;

void CreateArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine()!;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void SelectItems()
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arr[k] = array[i];
            k++;
        }
    }
}

Console.WriteLine("Введите любые строки через пробел:");
CreateArray();
Console.Write("Исходный массив строк: ");
PrintArray(array);
SelectItems();
if (k != 0)
{
    Console.Write("Полученный массив: ");
    PrintArray(arr);
}
else Console.WriteLine("В заданном массиве нет строк с количеством символов меньше или равно 3");
