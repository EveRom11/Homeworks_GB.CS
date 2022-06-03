/*Программа принимает число с клавиатуры и  проверяет, 
является ли оно пaлиндромом.*/
Console.WriteLine("Введите число для проверки");
string number=Console.ReadLine();
int minus_index, plus_index, step;
int len=number.Length;
int l= len/2;
minus_index=l-1;
plus_index=l+1;
step=0;
if (len%2==0)
{
    plus_index-=1;
}
while (minus_index>=0)
{
    if (number[minus_index]==number[plus_index])
    {
        minus_index-=1;
        plus_index+=1;
        step++;
    }
    else{
        break;}
}
if (number=="")
{
    Console.WriteLine("Все пошло не так");
}
if (l>step || len==1)
{
    Console.WriteLine("Число не является палиндромом");
}
if (l==step && len!=0 && len!=1)
{
    Console.WriteLine("Число является палиндромом");
} 
// Почему-то не работает еlse