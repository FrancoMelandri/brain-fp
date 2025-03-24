using Shouldly;

namespace TinyBrain.Test;

public class OperandTests
{
    [Test]
    public void Token_Sum_Is_Right()
    {
        var operand1 = new Operand(42.0);
        var operand2 = new Operand(66.0);
        var token = operand1 + operand2; 
        token.Data.ShouldBe(108.0);
        token.Previous.Operand1.Unwrap().ShouldBe(operand1);
        token.Previous.Operand2.Unwrap().ShouldBe(operand2);
    }

    [Test]
    public void Token_And_Constant_Sum_Is_Right()
    {
        var operand1 = new Operand(42.0);
        var operand2 = operand1 + 10; 
        var token3 = 10 + operand1; 
        operand2.Data.ShouldBe(52.0);
        token3.Data.ShouldBe(52.0);
        operand2.Previous.Operand1.Unwrap().ShouldBe(operand1);
        operand2.Previous.Operand2.Unwrap().Previous.Operand1.IsNone.ShouldBe(true);
        operand2.Previous.Operand2.Unwrap().Previous.Operand2.IsNone.ShouldBe(true);
        token3.Previous.Operand2.Unwrap().ShouldBe(operand1);
        token3.Previous.Operand2.Unwrap().Previous.Operand1.IsNone.ShouldBe(true);
        token3.Previous.Operand2.Unwrap().Previous.Operand2.IsNone.ShouldBe(true);
    }

    [Test]
    public void Token_Mul_Is_Right()
    {
        var operand1 = new Operand(42.0);
        var operand2 = new Operand(2.0);
        var token = operand1 * operand2; 
        token.Data.ShouldBe(84.0);
        token.Previous.Operand1.Unwrap().ShouldBe(operand1);
        token.Previous.Operand2.Unwrap().ShouldBe(operand2);
    }

    [Test]
    public void Token_And_Constant_Mul_Is_Right()
    {
        var operand1 = new Operand(42.0);
        var operand2 = operand1 * 2;
        var token3 = 2 * operand1;
        operand2.Data.ShouldBe(84.0);
        token3.Data.ShouldBe(84.0);
        operand2.Previous.Operand1.Unwrap().ShouldBe(operand1);
        operand2.Previous.Operand2.Unwrap().Previous.Operand1.IsNone.ShouldBe(true);
        operand2.Previous.Operand2.Unwrap().Previous.Operand2.IsNone.ShouldBe(true);
        token3.Previous.Operand2.Unwrap().ShouldBe(operand1);
        token3.Previous.Operand2.Unwrap().Previous.Operand1.IsNone.ShouldBe(true);
        token3.Previous.Operand2.Unwrap().Previous.Operand2.IsNone.ShouldBe(true);
    }
}