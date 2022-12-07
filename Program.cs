// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина корорых меньше либо ровна 3 символа.
// Первичный массив можно ввести с клавиатуры, либо задать на старте выполнение алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
        }
        count++;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] array1 = new string[5] { "1211", "52", "751", "3", "9999" };
string[] array2 = new string[array1.Length];

SecondArray(array1, array2);
PrintArray(array2);

string[] array3 = new string[5] { "hello", "2", "world", "-3", "@#$^&" };
string[] array4 = new string[array1.Length];

SecondArray(array3, array4);
PrintArray(array4);