namespace MutliThreadingDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Function 1 Executed");
                    Thread.Sleep(1000);
                }
            });
           await Task.Run(()=>Function2());
            Task.WaitAll(Task.Delay(1000));
        }
        static void Function1()
        {
            
        }
        static async void Function2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 2 Executed");
            }
        }
    }
}
