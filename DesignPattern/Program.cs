using DesignPattern.Comportamental.Observer;
using DesignPattern.Comportamental.State;
using DesignPattern.Comportamental.Strategy;
using DesignPattern.Comportamental.TemplateMethod;

//Strategy();
//TemplateMethod();
//Observer();
State();

#region Comportamental
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
    //Exemplo 01
    RootObserver.Case1();
}

void State()
{
    //Exemplo 01
    RootState.Case1();
}
#endregion

