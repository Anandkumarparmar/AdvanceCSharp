using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp.Events.Calculator;

public class MathResult
{
    public void AdditionHandler(double result)
    {
        Console.WriteLine($"Addition Result: {result}");
    }

    public void SubtractionHandler(double result)
    {
        Console.WriteLine($"Subtraction Result: {result}");
    }

    public void MultiplicationHandler(double result)
    {
        Console.WriteLine($"Multiplication Result: {result}");
    }

    public void DivisionHandler(double result)
    {
        Console.WriteLine($"Division Result: {result}");
    }
}
