//Напишите программу, которая принимает на вход число и 
//выдает количество цифр в числе.

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

int NumberOfDigit(int number)
{
    int count = 0;
    number = Math.Abs(number);
    if (number == 0)
    {
        count = 1;
    }
    else
    {
        while (number > 0)
        {
            count++;
            number /= 10;
        }
    }
    return count;
}

int N = InputNumber("Введите число: ");
int count = NumberOfDigit(N);
System.Console.WriteLine(count);

