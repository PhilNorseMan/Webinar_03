//Написать программу, которая принимает на вход координаты двух точек, и находит расстояние между ними в 2-х мерном пространстве.



//Первый вариант решения

/*Console.WriteLine("Set coordinates for point A");
Console.WriteLine("Set coordinate xA:");
int xa = int.Parse(Console.ReadLine()!);
Console.WriteLine("Set coordinate yA:");
int ya = int.Parse(Console.ReadLine()!);

Console.WriteLine("Set coordinates for point B");
Console.WriteLine("Set coordinate xB:");
int xb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Set coordinate yB:");
int yb = int.Parse(Console.ReadLine()!);

int[] coordinates_a = {xa, ya};
int[] coordinates_b = {xb, yb};

int DistanceCount(int xa, int ya, int xb, int yb)
{
    int subtraction_x = coordinates_b[0] - coordinates_a[0];
    int subtraction_y = coordinates_b[1] - coordinates_a[1];
    int square_x = subtraction_x * subtraction_x;
    int square_y = subtraction_y * subtraction_y;
    int root = Convert.ToInt32(Math.Sqrt(square_x + square_y));

    return root;
}

Console.WriteLine("Distace between A and B = " + DistanceCount(xa, ya, xb, yb));*/




// Альтернативный вариант решения:

double DistanceCount(int[] coordinates_a, int[] coordinates_b)
{
    return Math.Sqrt(Math.Pow(coordinates_a[0] - coordinates_b[0], 2) + Math.Pow(coordinates_a[1] - coordinates_b[1], 2));
}

int[] coordinates_a = new int[2];
int[] coordinates_b = new int[2];

Console.WriteLine("Set coordinates for point A");
Console.WriteLine("Set coordinate xA:");
coordinates_a[0] = int.Parse(Console.ReadLine()!);
Console.WriteLine("Set coordinate yA:");
coordinates_a[1] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Set coordinates for point B");
Console.WriteLine("Set coordinate xB:");
coordinates_b[0] = int.Parse(Console.ReadLine()!);
Console.WriteLine("Set coordinate yB:");
coordinates_b[1] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Distace between A and B = ");
Console.WriteLine(Math.Round(DistanceCount(coordinates_a, coordinates_b), 3));