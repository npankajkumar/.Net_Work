namespace MutliThreadingDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            Parallel.ForEach([1, 2, 3, 23, 2, 1, 231, 23, 12, 31, 321, 231, 23, 123, 1], i =>
            {
                Console.WriteLine(i);
            });
            Parallel.For(1, 102, (i) => { Console.Write("hi"); }
            );
            Parallel.Invoke(() =>{
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Function with sleep Executed");
                    Thread.Sleep(1000);
                }

            }, () => {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Function without sleep Executed");
                }
            },Function2);



            // Task.Run(() =>
            // {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Function 1 Executed");
            //    Thread.Sleep(1000);
            //}
            // });
            //await Task.Run(()=>Function2());
            // Task.WaitAll(Task.Delay(1000));
        }
        static void Function1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 1 Executed");
                Thread.Sleep(1000);
            }

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
