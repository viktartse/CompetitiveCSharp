using System;
using System.Text;
using static ConsoleReader;

class Program
{
    static void Main(string[] args)
    {
    }
}

public static class IntExtentions
{
    public static void Times(this int n, Action<int> action)
    {
        for (var i = 0; i < n; i++)
        {
            action(i);
        }
    }

    public static void Times(this (int n, int m) dimensions, Action<int, int> action)
    {
        var (n, m) = dimensions;
        n.Times(i => m.Times(j => action(i, j)));
    }
}

public static class ConsoleReader
{
    public static T Read<T>()
        where T : IConvertible
    {
        var inputBuffer = new StringBuilder();
        int currChar;

        while ((currChar = Console.Read()) != -1)
        {
            if (!char.IsWhiteSpace((char)currChar))
            {
                inputBuffer.Append((char)currChar);
            }
            else if (inputBuffer.Length != 0)
            {
                break;
            }
        }

        return (T)Convert.ChangeType(inputBuffer.ToString(), typeof(T));
    }

    public static T[] ReadArray<T>(int count)
        where T : IConvertible
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count), $"'{nameof(count)}' must be >= 0");
        }

        var result = new T[count];

        for (var i = 0; i < count; i++)
        {
            result[i] = Read<T>();
        }

        return result;
    }
}