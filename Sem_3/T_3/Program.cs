/*Задача 21: Программа принимает на вход координаты двух точек и 
находит расстояние между ними в 3D прострастве.*/
double xa, ya, za, xb, yb, zb;
xa= 7;
ya=-5;
za=0;
xb=1;
yb=-1;
zb=9;
double S= (xa-xb)*(xa-xb)+(ya-yb)*(ya-yb)+(za-zb)*(za-zb);
S=Math.Sqrt(S);
System.Console.WriteLine("{0:f2}",S);