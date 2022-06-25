namespace Randy.DesignPrinciples.SOLID.OCP.StaticPolymorphism
{
    /// <summary>
    /// Instead of using interfaces, we can use abstract class too. it dependens on the context of your need.
    /// </summary>
    public interface ISubject
    {
        void Action();
    }

    public class SubjectManager
    {
        public void Action<T>(T subject)
            where T : ISubject, new()
        {
            subject.Action();
        }
    }
}
