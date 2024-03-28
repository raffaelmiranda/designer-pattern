namespace DesignPattern.Comportamental.TemplateMethod.Case1
{
    public class Gateway
    {
        public bool Cobrar(float valor)
        {
            Console.WriteLine($"R${valor}");
            bool[] reposta = { true, false };

            Random random = new Random();
            return reposta[random.Next(reposta.Length)];
        }
    }
}
