// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int num1, int num2)
{
    if (num1 < num2)
    {
        if (num2 == num1) return num1;
        return num1 + SumNumbers(num1 + 1, num2);
    }
    else
    {
        if (num1 == num2) return num2;
        return num2 + SumNumbers(num1, num2 + 1);
    }
}

Console.WriteLine("Введите натуральное число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 1 || n < 1)
{
    Console.WriteLine("Некорректный ввод");
    return;
}

Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} -> {SumNumbers(m, n)}");