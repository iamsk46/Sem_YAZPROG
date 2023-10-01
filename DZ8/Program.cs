// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int A = 2;
if (N > 1)
{
    while (N >= A)
    {
        Console.Write(A + " ");
        A = A + 2;
    }
}
else
{
    Console.WriteLine("Введите число больше 1 ");
}