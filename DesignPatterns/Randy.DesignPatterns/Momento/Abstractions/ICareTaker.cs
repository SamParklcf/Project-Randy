namespace Randy.DesignPatterns.Momento.Abstractions
{
    /// <summary>
    /// Provides functionalities to take care of snapshots of the <typeparamref name="T"/> object.
    /// </summary>
    /// <typeparam name="T"> Originator type to take care. </typeparam>
    public interface ICareTaker<T>
        where T : ISnapshot, new()
    {
        /// <summary> Gets all snapshots which have been created. </summary>
        /// <returns> List of all snapshots which have been created. </returns>
        IList<IMomento> GetAllSnapshots();

        /// <summary> Restore last snapshot in the snapshots list. </summary>
        /// <param name="cascade">
        /// Defines that <see cref="RestoreSnapshot(bool)"/> should be iterate throw snapshots if a
        /// snapshot has not valid or not. if true, it will iterate throw all snapshots to find a
        /// valid one, otherwise it throws a validation exception related to the snapshot validation.
        /// </param>
        void RestoreSnapshot(bool cascade = false);

        /// <summary>
        /// Takes a snapshot of the <typeparamref name="T"/> object.
        /// </summary>
        void TakeSnapshot();
    }
}