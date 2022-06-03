// Задача 23: Программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int N;
double i,c,i3;
N=7;
i=1;
c=3;
System.Console.Write($"Кубические корни чисел от 1 до {N}: ");
while (i<=N)
{
    i3=Math.Pow(i,c);
    i++;
    System.Console.Write($" {i3},");
}
