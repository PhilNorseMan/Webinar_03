// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти(х и у).

void GetQuaterCoordinates(int quater)
{
    if(quater == 1)
        Console.WriteLine("Coordinate X: from 1 till inf. Coordinate Y: from 1 till inf.");

    if(quater == 2)
        Console.WriteLine("Coordinate X: from -inf till -1. Coordinate Y: from 1 till inf.");

    if(quater == 3)
        Console.WriteLine("Coordinate X: from -inf till -1. Coordinate Y: from -inf till -1.");

    if(quater == 4)
        Console.WriteLine("Coordinate X: from 1 till inf. Coordinate Y: from -inf till -1.");

}

Console.WriteLine("Set quater number:");
int quater = int.Parse(Console.ReadLine()!);
while(quater > 4 || quater < 1)
{
    Console.WriteLine("Quater " + quater + " doesn't exist. Incorrect quater number. Please, try again!");
    Console.WriteLine("Set quater number:");
    quater = int.Parse(Console.ReadLine()!);
}

GetQuaterCoordinates(quater);


