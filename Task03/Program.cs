/*Напишите программу, которая принимает на вход число N и выдаёт 
произведение чисел от 1 до N.
4 -> 24
5 -> 120 */

int InputNumber(string text)
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
        System.Console.Write("Введенное значение не является числом. Попробуйте ещё раз: ");
    }  
    return number;
}

int ProductNumber(int number)
{
    int prod = 1;
    if (number == 0) return prod;
    else
    {
        for (int i = 1; i <= number; i++)
        {
            prod *= i;
        }
    }
    return prod;
}

//int N = InputNumber("Введите число: ");
//int result = ProductNumber(N);



System.Console.WriteLine($"Произведение чисел = {ProductNumber(InputNumber("Введите число: "))}");