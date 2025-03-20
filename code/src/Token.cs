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

    public static Token operator +(Token a, double b)
        => new(a.Data + b);

    public static Token operator +(double a, Token b)
        => new(a + b.Data);

    public static Token operator *(Token a, Token b)
        => new(a.Data * b.Data);

    public static Token operator *(Token a, double b)
        => new(a.Data * b);

    public static Token operator *(double a, Token b)
        => new(a * b.Data);

    public Double Data { get; }
}