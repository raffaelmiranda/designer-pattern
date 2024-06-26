﻿using DesignPattern.Comportamental.Strategy.Case1;
using DesignPattern.Comportamental.Strategy.Case2;
using DesignPattern.Comportamental.Strategy.Case3;

namespace DesignPattern.Comportamental.Strategy
{
    public static class RootStrategy
    {
        public static void Case1()
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

        public static void Case2()
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

        public static void Case3()
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
    }
}
