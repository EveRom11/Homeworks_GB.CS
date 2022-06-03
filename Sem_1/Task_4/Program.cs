//Задача 8: Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int N=83, down=1;
while (down<=N)
{
    if (down%2==0)
    {
        System.Console.WriteLine(down);
    }
    down+=1;
}
