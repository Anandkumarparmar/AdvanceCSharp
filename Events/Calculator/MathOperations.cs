using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp.Events.Calculator;

// Define delegate for an event
public delegate void MathOperationEventHandler(double result);

public class MathOperations
{
    // Create an event
    public event MathOperationEventHandler AdditionPerformed;
    public event MathOperationEventHandler SubtractionPerformed;
    public event MathOperationEventHandler MultiplicationPerformed;
    public event MathOperationEventHandler DivisionPerformed;

    public void Addition(double a, double b)
    {
        var sum = a + b;
        AdditionPerformed?.Invoke(sum);
    }

    public void Subtraction(double a, double b)
    {
        var sub = a - b;
        SubtractionPerformed?.Invoke(sub);
    }

    public void Division(double a, double b)
    {
        var div = b > 0? a / b : double.NaN;
        DivisionPerformed?.Invoke(div);
    }

    public void Multiplication(double a, double b)
    {
        var mul =  a * b;
        MultiplicationPerformed?.Invoke(mul);
    }
}
