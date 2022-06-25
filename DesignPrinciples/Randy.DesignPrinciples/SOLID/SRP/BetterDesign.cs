namespace Randy.DesignPrinciples.SOLID.SRP
{
    public abstract class SubjectBase
    {
        public abstract void Read();

        public abstract void Save();
    }

    public class Subject1 : SubjectBase
    {
        public override void Read()
        {
        }

        public override void Save()
        {
        }
    }

    public class Subject2 : SubjectBase
    {
        public override void Read()
        {
        }

        public override void Save()
        {
        }
    }
}