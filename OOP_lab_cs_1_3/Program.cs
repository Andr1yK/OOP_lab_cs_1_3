using System;

class Program
{
    static void Main()
    {
        double x, xp, xk, dx, A, B, y;

        Console.Write("xp = ");
        xp = double.Parse(Console.ReadLine());

        Console.Write("xk = ");
        xk = double.Parse(Console.ReadLine());

        Console.Write("dx = ");
        dx = double.Parse(Console.ReadLine());

        Console.WriteLine("----------------------");
        Console.WriteLine("|    x    |     y    |");
        Console.WriteLine("----------------------");

        x = xp;

        while (x <= xk)
        {
            A = (2 + x) / Math.Pow(x, 2) + 1;

            if (x < 0)
                B = Math.Pow(x, 3) - 2 * Math.Pow(x, 4);
            else if (x > 2)
                B = 4 * Math.Cos(Math.Pow(x, 2) - 2);
            else
                B = Math.Pow(Math.Abs(x) + Math.Exp(x), 3);

            y = A + B;

            Console.WriteLine("|{0,8:f2}|{1,10:f3}|", x, y);

            x += dx;
        }

        Console.WriteLine("----------------------");
    }
}