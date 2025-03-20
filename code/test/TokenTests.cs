using System;
using Shouldly;

namespace BrainFp.Test;

public class TokenTests
{
    [Test]
    public void Token_Sum_Is_Right()
    {
        var token1 = new Token(42.0);
        var token2 = new Token(66.0);
        var token = token1 + token2; 
        token.Data.ShouldBe(108.0);
    }

    [Test]
    public void Token_And_Constant_Sum_Is_Right()
    {
        var token1 = new Token(42.0);
        var token2 = token1 + 10; 
        var token3 = 10 + token1; 
        token2.Data.ShouldBe(52.0);
        token3.Data.ShouldBe(52.0);
    }

    [Test]
    public void Token_Mul_Is_Right()
    {
        var token1 = new Token(42.0);
        var token2 = new Token(2.0);
        var token = token1 * token2; 
        token.Data.ShouldBe(84.0);
    }
    [Test]
    public void Token_And_Constant_Mul_Is_Right()
    {
        var token1 = new Token(42.0);
        var token2 = token1 * 2;
        var token3 = 2 * token1;
        token2.Data.ShouldBe(84.0);
        token3.Data.ShouldBe(84.0);
    }
}