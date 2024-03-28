using DesignPattern.Comportamental.Observer;
using DesignPattern.Comportamental.Strategy;
using DesignPattern.Comportamental.TemplateMethod;

//Strategy();
//TemplateMethod();
Observer();

void Strategy()
{
    //Exemplo 01
    RootStrategy.Case1();

    //Exemplo 02
    RootStrategy.Case2();

    //Exemplo 03
    RootStrategy.Case3();
}

void TemplateMethod()
{
    //Exemplo 01
    RootTemplateMethod.Case1();

    //Exemplo 02
    RootTemplateMethod.Case2();

    //Exemplo 03
    RootTemplateMethod.Case3();
}

void Observer()
{
    RootObserver.Case1();
}


