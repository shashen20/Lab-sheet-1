using System

class Program
{
    static void Main()
    {
        Console.Write("Enter the length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        double area = CalculateArea(length, width);

        Console.WriteLine($"The area of the rectangle is: {area}");
    }

    static double CalculateArea(double length, double width)
    {
        return length * width;
    }
}