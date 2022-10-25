/* Написать программу, которая принимает на вход число N, и выдает таблицу квадратов чисел от 1 до N. 
5 -> 1, 4, 9, 16, 25
2 -> 1, 4 */

Console.WriteLine("Set number: ");
int num = int.Parse(Console.ReadLine()!);

int SqareNum(int num)
{
    int sqare_num = num*num;
    return sqare_num;
}

int[] arr = new int[num];

while(num > 0)
{
    arr[num - 1] = SqareNum(num);
    num = num - 1;
}

void PrintArray(int[] arr)
{
    int count = arr.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

PrintArray(arr);