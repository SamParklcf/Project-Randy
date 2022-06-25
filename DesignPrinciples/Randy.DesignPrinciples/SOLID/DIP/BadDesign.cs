namespace Randy.DesignPrinciples.SOLID.DIP
{
    public class Subject1
    {
        public void Action1()
        {
        }

        public void Action2()
        {

        }
    }

    public class Subject2 : Subject1
    {
    }

    // what if Subject3 is a type of Subject1, BUT it has not the Action2 functionality? so we need to decouple the functionalities.

    public class Usage
    {
        public void Main(Subject1 subject)
        {
            if (subject is Subject2 subject2)
            {
                subject2.Action1();
            }
        }
    }
}
