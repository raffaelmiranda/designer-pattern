using DesignPattern.Comportamental.Strategy;
using DesignPattern.Comportamental.TemplateMethod;

//Strategy();
TemplateMethod();

void Strategy()
{
    //Exemplo 01
    RootStrategy.Frete();

    //Exemplo 02
    RootStrategy.Rota();

    //Exemplo 03
    RootStrategy.OrderList();
}

void TemplateMethod()
{
    //Exemplo 01
    RootTemplateMethod.Pagamento();

    //Exemplo 02
    RootTemplateMethod.Generico();

    //Exemplo 03
    RootTemplateMethod.Generico2();
}


