namespace DesignPattern.Comportamental.TemplateMethod.Case3
{
    public abstract  class AbstractClass
    {
        public void TemplateMethod()
        {
            BaseOperation1();
            RequiredOperations1();
            BaseOperation2();
            Hook1();
            RequiredOperation2();
            BaseOperation3();
            Hook2();
        }

        protected void BaseOperation1()
        {
            Console.WriteLine("AbstractClass diz: Estou fazendo a maior parte do trabalho");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine("AbstractClass diz: Mas deixei as subclasses substituirem algumas operações");
        }

        protected void BaseOperation3()
        {
            Console.WriteLine("AbstractClass diz: Mas estou fazendo a maior parte do trabalho de qualquer maneira");
        }

        protected abstract void RequiredOperations1();

        protected abstract void RequiredOperation2();

        protected virtual void Hook1() { }

        protected virtual void Hook2() { }
    }
}
