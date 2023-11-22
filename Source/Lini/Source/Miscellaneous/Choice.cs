using System.Diagnostics.CodeAnalysis;

namespace Lini.Miscellaneous;

public class Choice<T1, T2>
{
    public Choice(T1 first)
    {
        First = first;
        IsFirstCase = true;
    }

    public Choice(T2 second)
    {
        Second = second;
        IsFirstCase = false;
    }

    public T1? First { get; init; }
    public T2? Second { get; init; }

    [MemberNotNullWhen(true, nameof(First))]
    [MemberNotNullWhen(false, nameof(Second))]
    public bool IsFirstCase { get; init; }
    
    [MemberNotNullWhen(false, nameof(First))]
    [MemberNotNullWhen(true, nameof(Second))]
    public bool IsSecondCase => !IsFirstCase;
}