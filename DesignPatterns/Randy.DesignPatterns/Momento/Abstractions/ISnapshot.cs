namespace Randy.DesignPatterns.Momento.Abstractions
{
    public interface ISnapshot
    {
        void RestoreSnapshot(IMomento snapshot);

        IMomento TakeSnapshot();
    }
}