using System;

public class SemSolucaoException : Exception
{
    
    public SemSolucaoException()
        : base("Nao há solucoes disponiveis")
    {
    }

    public SemSolucaoException(string message, Exception inner)
        : base(message, inner)
    {
    }
}