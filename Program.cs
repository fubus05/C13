using System;
public class Program
{
    public static void Main ()
    {   
        Console.WriteLine("Введите значение x");
        double X = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение a");
        double A = double.Parse(Console.ReadLine());

        double calendar = Math.Log((A + Math.Abs(X)), Math.Pow(X, 2));
        double denominator = Math.Sqrt(X - Math.Asin(X)/Math.Pow(Math.Acos(X + Math.Pow(A, 2)),5));

        Console.WriteLine("y = " + calendar/denominator);
    }
}