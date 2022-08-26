

using System.Diagnostics;
using System.Threading;


class Program
{
    static void Main(string[] args)
    {

        //Stopwatch stopwatch = new Stopwatch();

        //stopwatch.Start();

        //List<Thread> threads = new List<Thread>()
        //{
        //    new Thread(LavarLouca),
        //    new Thread(LavarRoupa),
        //    new Thread(FazerComida)
        //};

        //foreach (var thread in threads)
        //{
        //    thread.Start();
        //}

        //foreach (var thread in threads)
        //{
        //    thread?.Join();
        //}

        new Thread(LavarLouca).Start();
        new Thread(LavarRoupa).Start();
        new Thread(FazerComida).Start();


        //Console.WriteLine($"O processo levou {stopwatch.ElapsedMilliseconds} ms");

        //stopwatch.Stop();

    }

    static void LavarLouca()
    {
        Console.WriteLine($"Inicio Lavar louça. {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(2000);
        Console.WriteLine("Fim Lavar a Louça");
    }

    static void LavarRoupa()
    {
        Console.WriteLine($"Inicio Lavar a roupa. {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(3000);
        Console.WriteLine("Fim Lavar a roupa");
    }

    static void FazerComida()
    {
        Console.WriteLine($"Inicio Fazer comida. {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(8000);
        Console.WriteLine("Fim Fazer comida");
    }
}