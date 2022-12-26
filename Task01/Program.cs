/*Напишите программу, которая принимает на вход число А 
и выдаёт сумму чисел о 1 до А*/

//Стандартное решение
System.Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
int sumN = 0;

for (int i = 1; i <= a; i++)
{
    sumN += i;
}

System.Console.WriteLine($"Сумма чисел от 1 до {a} = {sumN}");

//Можно запрос и ввод строки   и  цикл записать в виде двух методов, 
//которые можно использовать в дальнейшем:

int N = InputNumber("Введите число: ");
int result = SumN(N);
System.Console.WriteLine($"Сумма чисел от 1 до {N} = {result}");




int InputNumber(string text)     //Метод ввода строки
{
    System.Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumN(int number)    //Метод подсчёта суммы чисел от 1 до number
{
    int result = 0;
    for (int i = 1; i <= number; i++)
    {
        result += i;
    }
    return result;
}

