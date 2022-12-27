/*
Задача 27:  
Напишите программу, которая принимает на вход число и выдаёт сумму 
цифр в числе.
* 452 -> 11
* 82 -> 10
* 9012 -> 12 */

Console.Clear();
System.Console.WriteLine($"Сумма цифр = {SumOfDigit(InputNumberControl("Введите число: "))}");

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

//Метод подсчёта суммы цифр в числе.
int SumOfDigit(int number)
{
    int count = 0;
    number = Math.Abs(number);
    while (number > 0)
    {
        count += number % 10;
        number /= 10;
    }
    return count;
}


