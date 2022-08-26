using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {

        //List<string> files = new List<string>();

        //files.Add("vs.exe");
        //files.Add("note.exe");
        //files.Add("calc.exe");
        //files.Add("word.exe");

        Stopwatch stopwatch = new Stopwatch();



        stopwatch.Start();

        ParallelOptions op = new();
        op.MaxDegreeOfParallelism = 2; //maximo de threads que vai usar, respeitando a quantidade disponivel do sistema

        //Parallel.For(0, files.Count - 1, op, i =>
        //{
        //    DownloadFile(files[i]);
        //});

        //Parallel.ForEach(files, op, file =>
        //{
        //    DownloadFile(file);
        //});

        Parallel.Invoke(op, () => DownloadFile("chrome.exe"),
                        () => DownloadFile("opera.exe"),
                        () => DownloadFile("firefox.exe"),
                        () => DownloadFile("gx.exe")
        );

        stopwatch.Stop();
        Console.WriteLine($"O processo levou {stopwatch.ElapsedMilliseconds} ms");

    }


    public static void DownloadFile(string file)
    {
        Thread.Sleep(5000);
        Console.WriteLine($"Download Done: {file} - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
    }
}