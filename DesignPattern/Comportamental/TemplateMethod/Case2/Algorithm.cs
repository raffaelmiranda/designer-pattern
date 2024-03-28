namespace DesignPattern.Comportamental.TemplateMethod.Case2
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
