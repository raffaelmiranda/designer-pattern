namespace DesignPattern.Comportamental.TemplateMethod.Case2
{
    public class ConcreteClassA : IPrimitives
    {
        public string Operation1()
        {
            return "ClassA:Op1 ";
        }

        public string Operation2()
        {
            return "ClassA:Op2 ";
        }
    }
}
