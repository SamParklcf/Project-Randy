namespace Randy.DesignPrinciples.SOLID.DIP.GoodDesign
{
    public interface ISubject
    {
        void Action1();
        void Action2();
    }

    public class Subject1 : ISubject
    {
        public virtual void Action1()
        {
        }

        public virtual void Action2()
        {
        }
    }

    public class Subject2 : Subject1, ISubject
    {
        public override void Action1()
        {
            base.Action1();
        }

        public override void Action2()
        {
            base.Action2();
        }
    }

    public class Usage
    {
        public void Main(ISubject subject)
        {

        }
    }
}
