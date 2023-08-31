namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Overload1.Add(0,1));
            Console.WriteLine(Overload1.Add(3.4m,5.3m));
            Console.WriteLine(Overload1.Add(4,1,true));
        }
    }
}
