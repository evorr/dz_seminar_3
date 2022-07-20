// Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А: ");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());


double Distance (int xA, int yA, int zA, int xB, int yB, int zB)
{
    double result = Math.Sqrt (Math.Pow((xB-xA),2)+Math.Pow((yB-yA),2)+Math.Pow((zB-zA),2));
    return result;
}

double dist = Math.Round((Distance (x1,y1,z1,x2,y2,z2)),2);
Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {dist}");
