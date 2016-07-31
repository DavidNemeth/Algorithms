using System;

namespace Progression
{
    class Program
    {
        static void Main(string[] args)
        {
            BProgression prog;

            // test ArithmeticProgression
            Console.WriteLine("Arithmetic progression with default increment: ");
            prog = new ArithmeticProgression();
            prog.PrintProgression(10);
            Console.WriteLine("Arithmetic progression with increment 5: ");
            prog = new ArithmeticProgression(5);
            prog.PrintProgression(10);
            Console.WriteLine("Arithmetic progression with start 2: ");
            prog = new ArithmeticProgression(5, 2);
            prog.PrintProgression(10);

            // test GeometricProgression
            Console.WriteLine("Geometric progression with default base: ");
            prog = new GeometricProgression();
            prog.PrintProgression(10);
            Console.WriteLine("Geometric progression with base 3: ");
            prog = new GeometricProgression(3);
            prog.PrintProgression(10);

            // test FibonacciProgression
            Console.WriteLine("Fibonacci progression with default start values: ");
            prog = new FibonacciProgression();
            prog.PrintProgression(10);
            Console.WriteLine("Fibonacci progression with start values 4 and 6: ");
            prog = new FibonacciProgression(4, 6);
            prog.PrintProgression(8);
        }
    }
}
