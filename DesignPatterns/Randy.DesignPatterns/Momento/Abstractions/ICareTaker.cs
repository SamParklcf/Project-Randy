namespace Randy.DesignPatterns.Momento.Abstractions
{
    public interface ICareTaker
    {
        IList<IMomento> GetAllSnapshots();

        void RestoreSnapshot(bool cascade = false);

        void TakeSnapshot();
    }
}