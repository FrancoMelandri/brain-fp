using System;

namespace BrainFp;

public class Token
{
    public Token(Double data)
    {
        Data = data;
    }

    public static Token operator +(Token a, Token b)
        => new(a.Data + b.Data);

    public Double Data { get; }
}