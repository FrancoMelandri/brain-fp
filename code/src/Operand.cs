using TinyFp;

namespace TinyBrain;

public class Operand
{
    public (Option<Operand> Operand1, Option<Operand> Operand2) Previous { get; }
    public double Data { get; }

    public Operand()
    {
        Previous = (Option<Operand>.None(), Option<Operand>.None());
    }

    public Operand(double data)
        : this()
    {
        Data = data;
    }

    private Operand(double data, (Operand, Operand) previous)
        : this(data)
    {
        Previous = (Option<Operand>.Some(previous.Item1), Option<Operand>.Some(previous.Item2));
    }

    public static Operand operator +(Operand a, Operand b)
        => new(a.Data + b.Data, (a, b));

    public static Operand operator +(Operand a, double b)
        => new(a.Data + b, (a, new Operand(b)));

    public static Operand operator +(double a, Operand b)
        => new(a + b.Data, (new Operand(a), b));

    public static Operand operator *(Operand a, Operand b)
        => new(a.Data * b.Data, (a, b));

    public static Operand operator *(Operand a, double b)
        => new(a.Data * b, (a, new Operand(b)));

    public static Operand operator *(double a, Operand b)
        => new(a * b.Data, (new Operand(a), b));
}