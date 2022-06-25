namespace Randy.DesignPrinciples.SOLID.LSP
{
    public class BaseClass
    {
        public virtual void DoAction1()
        {

        }
    }

    public class SubClass : BaseClass
    {
        public override void DoAction1()
        {
            throw new InvalidOperationException("I can not do Action1, sorry");
            // But why? if you are a sub class of base class you should perform the DoAction1 as your parent can do.
        }
    }

    public class SomeClass
    {
        BaseClass _instance;

        public void Main()
        {
            _instance = new SubClass();// so far is good, because we can instantiate the SubClass from BaseClass

            _instance.DoAction1(); 
            // oh god, it can not be completed due to SubClass can not perform the action and it breaks code. because a developer expects that SubClass
            // can perform DoAction1 as it's parent can do.
            // so what? SubClass should can whatever BaseClass do. do LSP please!!!
        }
    }
}
