using System;

class Program 
{
    static void Main(string[] args) 
    {
        int x = 5; // Can be changed according to your desire value

        decimal factorial = ComputeFactorial(x);
        
        Console.WriteLine("x!=" + factorial);
    }

    static decimal ComputeFactorial(int x)
    {
        decimal factorial = 1;

        do
        {
            factorial *= x; 
            x--;
        } while (x > 0);

        return factorial;
    }
}
