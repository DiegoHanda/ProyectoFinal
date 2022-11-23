using System;

public class Check
{
    public class PreconditionException : Exception
    {
        public PreconditionException() : base() { }
        public PreconditionException(string message) : base(message) { }
    }

    public class PostconditionException : Exception
    {
        public PostconditionException() : base() { }
        public PostconditionException(string message) : base(message) { }
    }

    public class InvariantException : Exception
    {
        public InvariantException() : base() { }
        public InvariantException(string message) : base(message) { }
    }

    public static void Precondition(bool condition, string message)
    {
        if (!condition)
        {
            throw new PreconditionException(message);
        }
    }

    public static void Precondition(bool condition)
    {
        Precondition(condition, "Precondición insatisfecha");
    }
}    