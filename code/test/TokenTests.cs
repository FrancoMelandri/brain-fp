using System;
using Shouldly;

namespace BrainFp.Test;

public class TokenTests
{
    [Test]
    public void Token_Int_Is_Right()
    {
        var token = new Token<int>(42);
        token.Data.ShouldBe(42);
    }

    [Test]
    public void Token_Double_Is_Right()
    {
        var token = new Token<Double>(42.0);
        token.Data.ShouldBe(42.0);
    }
}