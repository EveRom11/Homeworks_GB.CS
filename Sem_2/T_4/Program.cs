// Задача  4: Программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
string[] week= new string [] {"понедельник","вторник","среда","четверг","пятница","суббота","воскресение"};

Console.WriteLine("Введи день недели");
int day, index;
day=Convert.ToInt32 (Console.ReadLine());

index= day-1;
if (index==5 || index==6){
    Console.WriteLine($"День недели {week[index]}- выходной");
}
else {Console.WriteLine($"День недели {week[index]}- не выходной");}