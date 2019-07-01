using System;

public class Shape
{
    public int length { get; set; }
    public Shape()
	{
	}
    public Shape(int length)
    {
        this.length = length;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}
