/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

void CountEvenNumbers(int size){
    int[] array= new int[size];
    int even=0;
    System.Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        array[i]= new Random().Next(100,1000);
        System.Console.Write($"{array[i]} ");
        if (array[i]%2==0){
            even++;
        }
    }
    System.Console.WriteLine("]");
    System.Console.WriteLine($"Количество четных чисел в массиве: {even}");
    
} 

CountEvenNumbers(17);