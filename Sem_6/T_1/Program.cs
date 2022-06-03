//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void CountPositiveNumbers(int size){
    int[] array=new int[size];
    int count=0;
    for (int i = 0; i < size; i++)
    {
        System.Console.Write("Введите целое число: ");
        array[i]=Convert.ToInt32(System.Console.ReadLine());
        if(array[i]>0){
            count++;
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Чисел больше 0 введено: {count}");
}
CountPositiveNumbers(5);