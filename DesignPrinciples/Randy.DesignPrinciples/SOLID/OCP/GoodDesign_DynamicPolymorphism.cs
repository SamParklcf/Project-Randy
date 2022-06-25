namespace Randy.DesignPrinciples.SOLID.OCP.DynamicPolymorphism
{
    /// <summary>
    /// Instead of using interfaces, we can use abstract class too. it dependens on the context of your need.
    /// </summary>
    public interface ISubject
    {
        void Action();
    }

    public class Subject1 : ISubject
    {
        public void Action()
        {
        }
    }
    public class Subject2 : ISubject
    {
        public void Action()
        {
        }
    }
    public class Subject3 : ISubject
    {
        public void Action()
        {
        }
    }

    public class SubjectManager
    {
        public void Action(ISubject subject)
        {
            subject.Action();

            // In this practice we have not to modify the Action method block to doing some extensions, you just simply
            // need to add the other subject type class/es to have more extensions.
        }
    }
}
