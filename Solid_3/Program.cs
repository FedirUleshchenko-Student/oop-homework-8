// ANSWER:
// L. - Liskov Substitution
using System;
using System.Data.SqlTypes;

public interface IShape
{
    int GetArea();
}

public class Rectangle : IShape
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    public int GetArea()
    {
        return Width * Height;
    }
}

public class Square : IShape
{
    public int Side { get; set; }

    public int GetArea() => Side * Side;
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();
        rect.Width = 5;
        rect.Height = 10;

        Console.WriteLine(rect.GetArea());

        Square sq = new Square();
        sq.Side = 5;
        // overrides 5
        sq.Side = 10;

        Console.WriteLine(sq.GetArea());

        Console.ReadKey();
    }
}