// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int x = num % 2;
if ( x % 2 == 0)
{
    Console.WriteLine("Число четное!");
    Console.WriteLine("Да!");

}
else 
{
    Console.WriteLine($"Число  {num} делится на 2?");
    Console.WriteLine("Нет!");
    Console.WriteLine("Вывести остаток {result}");
}
