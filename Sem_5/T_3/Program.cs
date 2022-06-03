//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] ArrayMaker(int size){
    double[] array=new double[size];
    System.Console.Write("[");
    for (int i = 0; i < size; i++)
    {        
        array[i]=new Random().Next(1,20);
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
    return array;
}

void DiffIndexes(double[] array){
    double min,max;
    min=array[0];
    max=array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]>max){
            max=array[i];}
        if(array[i]<min){
            min=array[i];}
    }
    System.Console.WriteLine(max);
    System.Console.WriteLine(min);
    System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {max-min}");
}

DiffIndexes(ArrayMaker(5));