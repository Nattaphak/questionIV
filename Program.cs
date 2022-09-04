using System;

class Program
{
    static void Main(string[] args)
    {
        int a; 
        int.TryParse(Console.ReadLine(), out a);

        Console.WriteLine(Abs(a));

    }

    static int Abs(int a)
    {
        return a*((2*a+1)%2);
    }
}
