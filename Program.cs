Console.WriteLine ("Введите значение b1:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите значение k1:");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите значение b2:");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите значение k2:");
int k2 = Convert.ToInt32(Console.ReadLine());

void Peresechenei (int b1, int b2, int k1, int k2)
{
    double y;
    double x;
    x = (b2 - b1)/(k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine ($"Точка пересечения прямых ({x}, {y})");

}
Peresechenei ( b1,  b2,  k1, k2);
