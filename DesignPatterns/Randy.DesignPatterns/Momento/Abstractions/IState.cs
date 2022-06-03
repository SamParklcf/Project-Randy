namespace Randy.DesignPatterns.Momento.Abstractions
{
    using System.Collections.Generic;

    /// <summary> Provides functionalities to save state of the <see cref="Originator"/> class. </summary>
    public interface IState
    {
        /// <summary>
        /// Gets list of <see cref="StateParameter"/> s which indicates the <see cref="Originator"/>
        /// states that should be takes and restore of a snapshot of it.
        /// </summary>
        /// <returns> </returns>
        IList<StateParameter> GetState();
    }
}