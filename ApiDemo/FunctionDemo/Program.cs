using System.Security.Cryptography.X509Certificates;

namespace FunctionDemo
{
    internal class Program
    { 

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Func<int,int,string> f=GetAddress;
            Console.WriteLine(f(3, 4));
            f = delegate (int x, int y) { return "hi delegate"; };
            Console.WriteLine(f(3, 4));
            f = (a, b) => "anonymus";
            Console.WriteLine(f(3, 4));
           
            Action<int, string> ff=(x,y) => { Console.WriteLine( ""+x+y); };
            ff(300, " hiii");
            Predicate<int> iseq = (u)=>{ return true; };
        
        }

        static string GetAddress(int a,int b)
        {
            return "Pankaj";
        }
    }
    internal class Funcdemo
    {
        static void Demo()
        {


        }
    }
}
