namespace Randy.DesignPrinciples.SOLID.ISP
{
    public interface ISubject
    {
        void Action1();
        void Action2();
        void Action3();
        void Action4();// but what if there is an object that is type of the subject but can not perform this action?
    }

    public class Subject1 : ISubject
    {
        public void Action1()
        {
        }

        public void Action2()
        {
        }

        public void Action3()
        {
        }

        public void Action4()
        {
        }
    }

    public class Subject2 : ISubject
    {
        public void Action1()
        {
        }

        public void Action2()
        {
        }

        public void Action3()
        {
        }

        public void Action4()
        {
            throw new InvalidOperationException("Sorry, I can not perform this action.");
        }
    }
}
