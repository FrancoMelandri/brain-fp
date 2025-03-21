using TinyFp;

namespace TinyBrain;

public class Token
{
    public (Option<Token> Token1, Option<Token> Token2) Previous { get; }
    public double Data { get; }

    public Token()
    {
        Previous = (Option<Token>.None(), Option<Token>.None());
    }

    public Token(double data)
        : this()
    {
        Data = data;
    }

    private Token(double data, (Token, Token) previous)
        : this(data)
    {
        Previous = (Option<Token>.Some(previous.Item1), Option<Token>.Some(previous.Item2));
    }

    public static Token operator +(Token a, Token b)
        => new(a.Data + b.Data, (a, b));

    public static Token operator +(Token a, double b)
        => new(a.Data + b, (a, new Token(b)));

    public static Token operator +(double a, Token b)
        => new(a + b.Data, (new Token(a), b));

    public static Token operator *(Token a, Token b)
        => new(a.Data * b.Data, (a, b));

    public static Token operator *(Token a, double b)
        => new(a.Data * b, (a, new Token(b)));

    public static Token operator *(double a, Token b)
        => new(a * b.Data, (new Token(a), b));
}