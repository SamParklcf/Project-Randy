namespace Randy.DesignPatterns.Momento.Abstractions
{
    using System.Collections.Generic;

    /// <summary> Provides functionalities to save state of the <see cref="Originator"/>. </summary>
    public interface IState
    {
        /// <summary>
        /// Gets a list of <see cref="StateParameter"/> which indicates the <see cref="Originator"/>
        /// states that should be takes and restore of a snapshot of it.
        /// </summary>
        /// <returns> List of <see cref="StateParameter"/>.</returns>
        IList<StateParameter> GetState();
    }
}