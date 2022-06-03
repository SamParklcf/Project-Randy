namespace Randy.DesignPatterns.Momento.Abstractions
{
    using System;

    public interface IMomento : IState
    {
        DateTime GetMomentoTime();
    }
}