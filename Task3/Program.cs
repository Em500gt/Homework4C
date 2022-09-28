using static System.Console;
Clear();
//Напишите метод, который формирует массив 
//из 8 случайных элементов и выводит их на экран.
//1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33]
Write("Введите количество элементов массива: ");
int size = int.Parse(ReadLine()!);
int[] arr = ArrayRandom(size);
PrintArray(arr);

int[] ArrayRandom(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next();
    }
    return array;
}

void PrintArray(int[] inArray)
{
    Write("[");
    for(int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]},");
    }
    WriteLine($"{inArray[inArray.Length - 1]}]");
}