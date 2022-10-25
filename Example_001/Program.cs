// Написать программу, которая принимает на вход координаты точки (Х и У),
// причем Х и У не равны 0, и выдает номер четверти плоскости, в которой находится точка.

int GetQuaterNumber(int x, int y)
{
    Console.WriteLine("GetQuaterNumber: " + x + " " + y);
    if(x > 0 && y > 0)
        return 1;

    if(x < 0 && y > 0)
        return 2;

    if(x < 0 && y < 0)
        return 3;

    if(x > 0 && y < 0)
        return 4;

    return -1;
}

Console.WriteLine("Set point coordinates (position X, position Y");

Console.WriteLine("Set position X:");
int x = int.Parse(Console.ReadLine()!);

Console.WriteLine("Set position Y:");
int y = int.Parse(Console.ReadLine()!);

int result = GetQuaterNumber(x, y);
if(result > 0)
{
    Console.WriteLine("Quater number of named point is: " + result);
}
else
    Console.WriteLine("Incorrect point coordinates!");