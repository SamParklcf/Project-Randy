namespace Randy.DesignPatterns.Momento.Abstractions
{
    /// <summary>
    /// Provides functionalities for taking and restoring snapshots of an <see cref="Originator"/> object.
    /// </summary>
    public interface ISnapshot
    {
        /// <summary> Resotres a snapshot of the <see cref="Originator"/> object. </summary>
        /// <param name="snapshot">
        /// A snapshot to be restored to the <see cref="Originator"/> object.
        /// </param>
        void RestoreSnapshot(IMomento snapshot);

        /// <summary> Takes a snapshot of the object. </summary>
        /// <returns>
        /// An <see cref="IMomento"/> object which represents the state of the <see
        /// cref="Originator"/> at a moment.
        /// </returns>
        IMomento TakeSnapshot();
    }
}