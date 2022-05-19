using System.Diagnostics;

Console.WriteLine("Hello, World!");
#if RELEASE
    Console.WriteLine("RELEASE VERSION");
#else
Console.WriteLine("DEBUG VERSION");
#endif

Console.WriteLine("Eine Taste drücken, dann geht es los");
Console.ReadKey();

var morgen = DateTime.Now.AddDays(1);
var text = "Dies ist ein Text";
var zahl = 12;



for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Zahl {i}");

    Debug.WriteLine("HALLLO DEbugger");
    if (i == 12)
    {

        Debugger.Break();
    }


}

SagHallo();

Console.WriteLine("Ende");
Console.ReadKey();

void SagHallo()
{
    ZeigeTextInConsole("Hallo");
    ZeigeTextInConsole("");
    //ZeigeTextInConsole(null);
}

void ZeigeTextInConsole(string text)
{
    //    Debug.Assert(text != null);

    Console.WriteLine($"{text} [{text.Length}]");
    Console.WriteLine(String.Format("{0} [{1}]", text, text.Length));

    Console.WriteLine(text + "[" + text.Length + "]");

    try
    {
        if (true)
            throw new ExecutionEngineException();
    }
    catch (Exception)
    {
        Console.WriteLine("Schade");
        Console.ReadLine();
    }

}