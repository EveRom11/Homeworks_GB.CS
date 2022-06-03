/*Напишите программу, которая найдёт точку пересечения двух прямых, 
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.*/

void CrossedLines(){
    double b1,b2,k1,k2;
    System.Console.Write("Введите значение b1: ");
    b1=Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Введите значение k1: ");
    k1=Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Введите значение b2: ");
    b2=Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Введите значение k2: ");
    k2=Convert.ToDouble(Console.ReadLine());
    double x=(b2-b1)/(k1-k2);
    double y1=k1*x+b1;
    double y2=k2*x+b2;
    if(y1==y2){
        System.Console.WriteLine($"x= {x}, y= {y1}");
    }
    else {System.Console.WriteLine("Ошибка");}
}

CrossedLines();
