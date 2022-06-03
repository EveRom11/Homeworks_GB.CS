//Задача 4: Программа принимает на вход три числа и выдаёт максимальное из этих чисел.

int a=2, b=3, c=7;
int max=a;
if (max<b)
{
    max=b;
    if (max<c)
    {
        max=c;
    }
}
System.Console.WriteLine($"Максимальное из трех {max}");