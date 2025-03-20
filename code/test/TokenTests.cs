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
}