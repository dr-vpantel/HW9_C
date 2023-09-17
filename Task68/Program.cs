// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int num1, int num2)
{
    if (num1 == 0)
    {
        return num2 + 1;
    }
    else if (num2 == 0 && num1 > 0)
    {
        return Akkerman(num1 - 1, 1);
    }
    else
    {
        return (Akkerman(num1 - 1, Akkerman(num1, num2 - 1)));
    }
}


Console.WriteLine("Введите натуральное число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число n");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0)
{
    Console.WriteLine("Некорректный ввод");
    return;
}

Console.WriteLine($"m = {m},n = {n} -> A({m}, {n}) = {Akkerman(m, n)}");