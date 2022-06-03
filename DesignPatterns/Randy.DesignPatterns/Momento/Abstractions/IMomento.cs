namespace Randy.DesignPatterns.Momento.Abstractions
{
    using System;

    /// <summary> Provides functionalities which gives snapshot details. </summary>
    public interface IMomento : IState
    {
        /// <summary> Gets the date and time of the created snapshot. </summary>
        /// <returns> <see cref="DateTime"/> represents the moment of created snapshot. </returns>
        DateTime GetMomentoTime();
    }
}