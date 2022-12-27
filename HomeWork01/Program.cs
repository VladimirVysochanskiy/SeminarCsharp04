/*
Задача 25:   
Напишите цикл, который принимает на вход два числа (A и B) и возводит 
число A в натуральную степень B.
* 3, 5 -> 243 (3⁵)
* 2, 4 -> 16 */

Console.Clear();
System.Console.WriteLine("Возведение числа A в степень B.");
int A = InputNumberControl("Введите число A: ");
int B = InputNumberControl("Введите число B: ");
System.Console.WriteLine($"Число {A} в степени {B} = {NumToPower(A, B)}");


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

//Метод возведения числа в указанную степень циклом.
int NumToPower(int num, int pow)
{
    int result = 1;
    for (int i = 0; i < pow; i++)
    {
        result *= num;
    }
    return result;
}
