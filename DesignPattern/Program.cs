using DesignPattern.Comportamental.Strategy.Frete;
using DesignPattern.Comportamental.Strategy.Rota;
using DesignPattern.Comportamental.Strategy.Sort;

Strategy();

#region Strategy
void Strategy()
{
    //Exemplo 01
    Frete();

    //Exemplo 02
    Rota();

    //Exemplo 03
    OrderList();
}

void Frete()
{
    //Pedido Eletronicos
    Pedido pedido = new PedidoEletronicos();
    pedido.Valor = 100;

    //Frete Comum
    IFrete freteComum = new FreteComum();
    pedido.Frete(freteComum);
    Console.WriteLine($"Frete Comum: R$ {pedido.CalcularFrete()}");

    //Pedido Moveis
    pedido = new PedidoMoveis();
    pedido.Valor = 500;

    //Frete Expresso
    IFrete freteExpresso = new FreteExpresso();
    pedido.Frete(freteExpresso);
    Console.WriteLine($"Frete Expresso: R$ {pedido.CalcularFrete()}");

    Console.WriteLine(Environment.NewLine);
}

void Rota()
{
    //Navegacao de Carro
    NavegacaoCarro carro = new NavegacaoCarro();
    carro.Partida = "A";
    carro.Destino = "B";

    IRota rotaCarro = new RotaCarro();
    carro.Rota(rotaCarro);
    Console.WriteLine($"Calculando rota de carro {carro.ContruirRota()}");

    //Navegacao de Carro
    NavegacaoOnibus onibus = new NavegacaoOnibus();
    onibus.Partida = "A";
    onibus.Destino = "B";

    IRota rotaOnibus = new RotaOnibus();
    onibus.Rota(rotaOnibus);
    Console.WriteLine($"Calculando rota de onibus {onibus.ContruirRota()}");

    Console.WriteLine(Environment.NewLine);
}

void OrderList()
{
    var list = new List<string>()
    {
     "Vaca",
     "Cavalo",
     "Gato"
    };

    var sort = new SortStrategy(new Descending());
    list = sort.Sort(list);
    list.ForEach(x => Console.WriteLine(x));

    sort = new SortStrategy(new Ascending());
    list = sort.Sort(list);
    list.ForEach(x => Console.WriteLine(x));

    Console.WriteLine(Environment.NewLine);
}
#endregion