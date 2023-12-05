// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// метод поиска длины нового массива
int FindNewArrayLength(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3 && array[i].Length >= 0) count++;
    }
    return count;
}
// метод создания нового массива из строк, состоящих менее, чем из трех символов
string[] CreateNewArray(string[] array, int count)
{
    string[] resultArray = new string[count];
    count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3 && array[j].Length >= 0)
        {
            resultArray[count] = array[j];
            count++;
        }
    }
    return resultArray;
}
// метод для печати массива
void PrintArray(string[] array)
{
    System.Console.Write($"[\"{array[0]}\"");
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", \"{array[i]}\"");
    }
    System.Console.Write("]");

}
// метод для ввода данных из консоли
string ReadStr(string msg)
{
    System.Console.WriteLine(msg);
    string arrayElement = Console.ReadLine();
    System.Console.WriteLine();
    return arrayElement;
}
// Основная функция программы (алгоритм)
void AlgoritmToPrint(string[] array)
{
    if (FindNewArrayLength(array) == 0)
    {
        System.Console.WriteLine("Ничего не нашлось :(\n");
        PrintArray(array);
        System.Console.Write(" -> ");
        System.Console.Write("[]\n\n");
        
    }
    else
    {
        System.Console.WriteLine("Вот что получилось :)\n");
        PrintArray(array);
        System.Console.Write(" -> ");
        PrintArray(CreateNewArray(array, FindNewArrayLength(array)));
        System.Console.WriteLine();
    }
}
// выполняем программу

// задаем массив массивов для рандомного выбора массива, если пользователь не захотел вводить массив сам

string[][] arrayRandom = new string[5][];

arrayRandom[0] = new string[5] { "Дерево", "мох", "сосна", ":-*", "." };
arrayRandom[1] = new string[6] { "Соня,", "Привет!", "Как", "Твои", "Дела", "?" };
arrayRandom[2] = new string[7] { "Мороз", "и", "солнце", "-", "день", "чудесный", "!" };
arrayRandom[3] = new string[3] { "Раз", "два", "три" };
arrayRandom[4] = new string[4] { "1234", "1567", "-2", "computer science" };

//{"Дерево", "мох", "сосна", ":-)","."};

System.Console.WriteLine
("Ищем все элементы массива меньше или равные трем символам.\n\nНажмите кнопку \"Y\", если хотите ввести массив\nлибо любую другую кнопку, если хотите использовать готовый массив\n");

if (Console.ReadKey(true).Key == ConsoleKey.Y)
{
    int n = Convert.ToInt32(ReadStr("Введите количество элементов массива (больше 0): "));
    if (n >0 )
    {
        string[] array = new string[n];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = ReadStr($"Введите {i + 1} элемент массива: ");
        }
        AlgoritmToPrint(array);
    }
    else
    {
        System.Console.WriteLine("Упс:-( Кажется кто-то ввел недопустимое чило.\n Введите число больше 0!");
    }
}
else AlgoritmToPrint(arrayRandom[new Random().Next(0, 5)]);









