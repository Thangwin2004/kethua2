using System;

public class Circle
{
    private double radius;
    private string color;

    public Circle()
    {
        radius = 1.0;
        color = "red";
    }

    public Circle(double radius, string color)
    {
        this.radius = radius;
        this.color = color;
    }

    public double GetRadius()
    {
        return radius;
    }

    public void SetRadius(double radius)
    {
        this.radius = radius;
    }

    public string GetColor()
    {
        return color;
    }

    public void SetColor(string color)
    {
        this.color = color;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }

    public override string ToString()
    {
        return "Circle[radius=" + radius + ",color=" + color + ",area=" + GetArea() + "]";
    }
}

public class Cylinder : Circle
{
    private double height;

    public Cylinder()
    {
        height = 1.0;
    }

    public Cylinder(double radius, string color, double height) : base(radius, color)
    {
        this.height = height;
    }

    public double GetHeight()
    {
        return height;
    }

    public void SetHeight(double height)
    {
        this.height = height;
    }

    public double GetVolume()
    {
        return GetArea() * height;
    }

    public override string ToString()
    {
        return "Cylinder[radius=" + GetRadius() + ",color=" + GetColor() + ",height=" + height + ",volume=" + GetVolume() + "]";
    }
}

