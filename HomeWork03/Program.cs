/*
Задача 29:  
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
* 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
* 6, 1, 33 -> [6, 1, 33]  */

Console.Clear();
int len = InputNumberControl("Введите размер массива: ");
System.Console.WriteLine("Массив будет заполнен случайными числами из диапазона от и до...");
int from = InputNumberControl("Введите первое число диапазона: ");
int to = InputNumberControl("Введите последнее число диапазона: ");

//добавил смену местами минимального и максимального значения диапазона, на случай ошибки.
if (from > to)
{
    int temp = from;
    from = to;
    to = temp;
}

int[] arr = RandArray(len, from, to);
System.Console.WriteLine("[ " + string.Join(" | ", arr) + " ]");
 
 //метод создание и рандомное наполнение int массива (заданной длины, числами от, и до)
int[] RandArray(int length, int fromNum, int toNum)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(fromNum, toNum + 1);
    }
    return array;
}

//Метод контроля ввода числа.
int InputNumberControl(string text)
{
    System.Console.Write(text);
    int number;
    while (true)    
    {
        string? txt = (Console.ReadLine());
        if (int.TryParse(txt, out number))
        {
             break;
        }
        System.Console.Write("Введенное значение не является натуральным числом. Попробуйте ещё раз: ");
    }  
    return number;
}
