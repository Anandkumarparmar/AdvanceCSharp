using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp.Events.Calculator;

public class MathSubscriber
{
    private readonly string _subscriber;
    private readonly MathResult _mathResult;
    private readonly MathOperations _mathOperations;
    public MathSubscriber(string subscriber, MathResult mathResult, MathOperations mathOperations)
    {
        _subscriber = subscriber;
        _mathResult = mathResult;
        _mathOperations = mathOperations;

        // Subscribe the math operations
        _mathOperations.AdditionPerformed += _mathResult.AdditionHandler;
        _mathOperations.SubtractionPerformed += _mathResult.SubtractionHandler;
        _mathOperations.MultiplicationPerformed += _mathResult.MultiplicationHandler;
        _mathOperations.DivisionPerformed += _mathResult.DivisionHandler;
    }
}
