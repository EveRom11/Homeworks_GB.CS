//Задача 27: Напишите функцию, которая принимает на вход число и выдаёт сумму цифр в числе.

void Scalpel(int num){
    string number= Convert.ToString(num);
    int sum=0;
    for (int i=0; i<number.Length; i++){
        int Num=Convert.ToInt32(number[i]-'0');
        sum=Num+sum;        
        }
    System.Console.WriteLine(sum);
}
    
Scalpel(9012); 