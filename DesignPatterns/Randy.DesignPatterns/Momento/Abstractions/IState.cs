namespace Randy.DesignPatterns.Momento.Abstractions
{
    using System.Collections.Generic;

    public interface IState
    {
        IList<State> GetState();
    }
}