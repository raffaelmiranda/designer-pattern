namespace DesignPattern.Comportamental.TemplateMethod.Case2
{
    public class ConcreteClassB : IPrimitives
    {
        public string Operation1()
        {
            return "ClassB:Op1 ";
        }

        public string Operation2()
        {
            return "ClassB.Op2 ";
        }
    }
}
