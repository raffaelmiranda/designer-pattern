namespace DesignPattern.Comportamental.TemplateMethod.Case3
{
    public class ConcreteClass1 : AbstractClass
    {
        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass1 diz: Operação Implementada1");
        }

        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass1 diz: Operação Implementada2");
        }
    }
}
