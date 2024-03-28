namespace DesignPattern.Comportamental.TemplateMethod.Generico
{
    public class Algorithm
    {
        public void TemplateMethod(IPrimitives a)
        {
            string s = a.Operation1() + " " + a.Operation2();
            
            Console.WriteLine(s);
        }
    }
}
