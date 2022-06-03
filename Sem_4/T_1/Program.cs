//Задача 25: Программа принимает число А и возводит в степень B

void Pow_1(int A,int B){
    int result=1;
    for (int i = 0; i < B; i++)
    {
        result=result*A;
    }
    System.Console.WriteLine(result);
}
Pow_1(2,4);