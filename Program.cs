//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 5, 6, 7, 8"


//Проверка натуральности

 bool Control (int num)
 {
    if (num <= 0 || num % 1 > 0) 
    {
        Console.WriteLine("Некорректный ввод");  
        return false;               
    }
    return true;       
 }


//печать
void PrintNaturalNumbers(int first, int second, int delta)
{
    if (first == second) 
    {
        Console.Write($"{first} ");
        return;
    }
    Console.Write($"{first}, ");
    PrintNaturalNumbers(first + delta, second, delta);   
}


int[] numbers = new int [2];

for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Введите натуральное {i+1}-е число: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    if (!Control(numbers[i]))
    {
        break;
    }
}

if (numbers[0] > 0 && numbers[1] > 0)
{
    int step = 1;
    if (numbers[0] > numbers[1] )
    {
        step = -1;
    }
    PrintNaturalNumbers(numbers[0], numbers[1], step); 
}