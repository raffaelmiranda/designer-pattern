namespace DesignPattern.Comportamental.TemplateMethod.Generico2
{
    public class ConcreteClass1 : AbstractClass
    {
        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass1 says: Implemented Operation1");
        }

        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass1 says: Implemented Operation2");
        }
    }
}
