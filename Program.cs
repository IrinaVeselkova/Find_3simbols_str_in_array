// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography;

string[] CheckThreeSimbolElements(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    // if (count == 0) System.Console.WriteLine($"[]");
    // else
    // {
    string[] resultArray = new string[count];
    count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        {
            if (array[j].Length <= 3)
            {
                resultArray[count] = array[j];
                count++;
            }
        }
    }
    //}
    return resultArray;
}

void PrintArray(string[] array)
{
    System.Console.Write($"[\"{array[0]}\"");
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", \"{array[i]}\"");
    }
    System.Console.Write("]");
    System.Console.WriteLine("\n");
}

string ReadIn(string msg)
{
    System.Console.WriteLine(msg);
    string arrayElement = Console.ReadLine();
    return arrayElement;
}

// string[] array = { "Дерево", "мох", "сосна", ":-)" };
string[] array = new string[5];
for (int i = 0; i < array.Length; i++)
{
  array[i] = ReadIn($"Введите {i+1} элемент массива: ");  
}
PrintArray(array);

PrintArray(CheckThreeSimbolElements(array));
