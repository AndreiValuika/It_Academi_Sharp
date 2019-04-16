using System;

public class Square:Shape
{
	public Square()
	{
	}

    public Square(int length) : base(length)
    {
    }

    public override double GetArea()
    {
        return length*length;
    }
}

public class Triangle : Shape
{
    public Triangle()
    {
    }

    public Triangle(int length) : base(length)
    {
    }

    public override double GetArea()
    {
        return Math.Sqrt(3)/4 * length*length;
    }
}
public class Circle : Shape
{
    public Circle()
    {
    }

    public Circle(int length) : base(length)
    {
    }
    public override double GetArea()
    {
        return Math.PI*length*length;
    }
}
