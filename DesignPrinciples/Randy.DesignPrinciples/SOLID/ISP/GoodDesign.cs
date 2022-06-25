namespace Randy.DesignPrinciples.SOLID.ISP.GoodDesign
{
    public interface ISubject
    {
        void Action1();
        void Action2();
        void Action3();
    }
    public interface ISpecificSubject : ISubject
    {
        void Action4();
    }

    public class Subject1 : ISpecificSubject
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
    }
}
