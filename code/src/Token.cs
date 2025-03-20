using System;

namespace BrainFp;

public class Token<T>
    where T: struct
{
    private T _data;

    public Token(T data)
    {
        _data = data;
    }
    
    public T Data => _data;
}