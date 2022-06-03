/*Задача 29: Напишите программу, которая задаёт массив из некоторого количества 
 элементов и выводит их на экран с помощью функций. 
 (можно спрашивать количество вводимых элементов и вводить все значения с клавиатуры)*/

 void FillMass()
 {
     Console.WriteLine("Введите размер массива: ");
     int size=Convert.ToInt32(Console.ReadLine());
     int[] mass= new int[size];
     System.Console.Write("[");
     for(int i=0; i<size; i++)
     {
         mass[i]=new Random().Next(1,10);
         System.Console.Write($"{mass[i]} " );
     }
     System.Console.WriteLine("]");
 }

 FillMass();