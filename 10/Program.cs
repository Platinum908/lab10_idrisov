//Лаб 10 Высокий 22

using System.IO;

try
{
    Console.WriteLine("Введите длины сторон балки прямоугольного сечения:");
    Console.Write("a: ");
    double a = double.Parse(Console.ReadLine()!);
    Console.Write("b: ");
    double b = double.Parse(Console.ReadLine()!);
    Console.Write("c: ");
    double c = double.Parse(Console.ReadLine()!);
    RodABC numABC = new RodABC(a, b, c);
    Console.WriteLine();
    Console.Write("Введите удельный вес балки: ");
    double weight = double.Parse(Console.ReadLine()!);
    Console.Write("Введите равное кол-во частей на которую ее распилят: ");
    double parts = double.Parse(Console.ReadLine()!);
    PotABCWP numABCWP = new PotABCWP(a, b, c, weight, parts);
    Console.WriteLine();
    Console.Write("Класс родитель: ");
    numABC.PrintClass();
    Console.Write("Класс потомок: ");
    numABCWP.PrintClass();
    Console.WriteLine("Удельный вес части распиленной балки: ");
    numABCWP.PrintWeight();
    Console.WriteLine("Площадь поверхности распиленной балки: ");
    numABCWP.PrintArea();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
class RodABC
{
    private double a;
    private double b;
    private double c;

    public RodABC(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public double A
    {
        get { return a; }
        set { a = value; }
    }
    public double B
    {
        get { return b; }
        set { b = value; }
    }
    public double C
    {
        get { return c; }
        set { c = value; }
    }
    public virtual void PrintClass()
    {
        Console.WriteLine($"a: {a}, b: {b}, c: {c}");
    }
}
class PotABCWP : RodABC
{
    private double weight;
    private double parts;

    public PotABCWP(double a, double b, double c, double weight, double parts) : base(a, b, c)
    {
        this.weight = weight;
        this.parts = parts;
    }
    public override void PrintClass()
    {
        Console.WriteLine($"weight: {weight}, parts: {parts}");
    }
    public void PrintWeight()
    {
        Console.WriteLine(weight/parts);
    }
    public void PrintArea()
    {
        Console.WriteLine((2 * (A* B + A * C + B * C))/parts);
    }
}