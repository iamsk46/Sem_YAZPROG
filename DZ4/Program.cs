// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a > b || a > c )
{
    int max = a;
    Console.WriteLine("Максимальное число = " + a);
}
else if (b > a || b > c);
{
    int max = b;
    Console.WriteLine("Максимальное число = " + b);
}
else
{
    int max = c;
    Console.WriteLine("Максимальное число = " + c);
}