// Задача 21: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double FindDistance(int ax, int ay, int az, int bx, int by, int bz)
{
    int leg1 = ax-bx;
    int leg2 = ay-by;
    int leg3 = az-bz;
    double distance = Math.Sqrt((leg1 * leg1) + (leg2 * leg2) + (leg3 * leg3)); 
    return distance;
}

Console.WriteLine("Введите координаты для точки A");
Console.Write("X : ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y : ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z : ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты для точки B");
Console.Write("X : ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y : ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z : ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = FindDistance(x1, y1, z1, x2, y2, z2);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(resultRound);
