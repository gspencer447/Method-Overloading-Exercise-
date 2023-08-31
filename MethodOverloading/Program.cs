namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Overload1.Add(0,1));
            Console.WriteLine(Overload1.Add(3.4,5.3));
            Console.WriteLine(Overload1.Add(-2,1,true));
        }
    }
}
