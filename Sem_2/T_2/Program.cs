//Задача 2: Программa выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int a,b,c,s;
a= new Random().Next(100,1000);
b=a%10;
c=a/100;
s=b+c*10;
System.Console.WriteLine(a);
System.Console.WriteLine(s);