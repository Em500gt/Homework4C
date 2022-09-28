using static System.Console;
Clear();
//Напишите метод, который принимает на вход два числа 
//(A и B) и возводит число A в натуральную степень B 
//с использованием цикла.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Write("Введите число A: ");
int A = int.Parse(ReadLine()!);
Write("Введите число B: ");
int B = int.Parse(ReadLine()!);
WriteLine(Degree(A,B));

double Degree(int a, int b)
{   
    bool flag = false;
    double result = 1;
    if(b == 0) return 1;
    if(b < 0) 
    {
        b = b * -1;
        flag = true;
    }
    for(int i = 0; i < b; i++)
    {
        result = result * a;
    }
    return flag == false? Convert.ToInt32(result): 1 / result;
}
