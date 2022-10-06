// Напишите программу, которая на вход принимает число (N), а на выходе показывает 
//все чётные числа от 1 до N.
//5-> 2, 4
//8-> 2, 4, 6, 8

Console.WriteLine("Введите число :");
int num = int.Parse(Console.ReadLine()!);
int N = num % 2;
if (num < N)
{
    Console.Write($"Показать четные числа  {N}");
}
else
{
    Console.Write("Прибавить {2} к числу {num}");
}