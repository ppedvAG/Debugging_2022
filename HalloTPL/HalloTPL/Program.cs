Console.WriteLine("Hello, World!");


Task t1 = new Task(() =>
{
    Console.WriteLine("T1 gestartet");
    Thread.Sleep(1000);
    Console.WriteLine("T1 fertig");
});

Task t2 = new Task(() =>
{
    Console.WriteLine("T2 gestartet");
    Task t22 = new Task(() =>
    {
        Console.WriteLine("T22 gestartet");
        Thread.Sleep(2000);
        Console.WriteLine("T22 fertig");
    },TaskCreationOptions.AttachedToParent);
    t22.Start();
    Thread.Sleep(2000);
    Console.WriteLine("T2 fertig");
});

Task t3 = new Task(() =>
{
    Console.WriteLine("T3 gestartet");
    Thread.Sleep(800);
    Console.WriteLine("T3 fertig");
});

t1.Start();
t2.Start();
t3.Start();


//Parallel.For(0, 1000000, new ParallelOptions() { MaxDegreeOfParallelism = 6 },
//             i => Console.WriteLine($"Thread: [{Thread.CurrentThread.ManagedThreadId}] {i}"));

Parallel.Invoke(Zähle, Zähle, Zähle, Zähle, Zähle, Zähle, Zähle, Zähle);

//Zähle();
//Zähle();
//Zähle();
//Zähle();
//Zähle();

Console.WriteLine("Ende");
Console.ReadKey();

void Zähle()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Thread: [{Thread.CurrentThread.ManagedThreadId}] {i}");
    }
}