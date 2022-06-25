namespace Randy.DesignPrinciples.SOLID.OCP
{
    public enum SubjectType
    {
        Type1,
        Type2,
        Type3,
    }

    public class SubjectManager
    {
        public void Action(SubjectType type)
        {
            if (type == SubjectType.Type1)
            {
                // Type1 related stuff
            }
            else if (type == SubjectType.Type2)
            {
                // Type2 related stuff
            }
            else if (type == SubjectType.Type3)
            {
                // Type3 related stuff
            }

            // What if we have another modem type, or what if we want add some more modem types in the future? 
            // so we should add them to this if..else statement to adding more functionaliteis to this Action method without 
            // avoiding to change the method block. so it can be extended just with modification of it's block.
            // OCP DOES NOT recommend this.
        }
    }
}
