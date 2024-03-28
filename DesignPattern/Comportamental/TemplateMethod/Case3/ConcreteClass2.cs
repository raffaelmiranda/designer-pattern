namespace DesignPattern.Comportamental.TemplateMethod.Case3
{
    public class ConcreteClass2 : AbstractClass
    {
        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass2 diz: Operação Implementada1");
        }

        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass2 diz: Operação Implementada2");
        }

        protected override void Hook1()
        {
            Console.WriteLine("ConcreteClass2 diz: Hook1 substituído");
        }
    }
}
