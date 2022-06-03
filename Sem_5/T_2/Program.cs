/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.*/

void SumOddIndexes(int size){
    int[] array=new int[size];
    int sum=0; 
    System.Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        array[i]=new Random().Next(1,20);
        System.Console.Write($"{array[i]} ");
        if (i%2==1){
            sum+=array[i];
        }
    }
    System.Console.WriteLine("]");
    System.Console.WriteLine($"Сумма элементов массива под нечетными индексами: {sum}");
    
}

SumOddIndexes(9);