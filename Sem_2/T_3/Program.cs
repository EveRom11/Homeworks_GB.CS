//Задача 3: Программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int a;
a=687;
if (a/100==0) {
    System.Console.WriteLine("Третьей цифры нет");
}
else {System.Console.WriteLine(a%10);
}