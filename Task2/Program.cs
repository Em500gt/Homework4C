using static System.Console;
Clear();
//Напишите метод, который принимает на 
//вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Write("Введите число: ");
int number = int.Parse(ReadLine()!);
WriteLine(sum(number));


int sum(int n)
{
    if(n < 0) n = n * -1;
    int result = 0;
    for(int i = 0; i < n; i++)
    {
        result = result + n % 10;
        n = n / 10;
    }
    return result;
}