
using System.Diagnostics;

Console.WriteLine("Hello, World!");

Trace.Listeners.Add(new TextWriterTraceListener("trace.txt"));
Trace.Listeners.Add(new EventLogTraceListener("Application"));
Trace.AutoFlush = true;


Debug.WriteLine("Hallo Debugger");
Trace.WriteLine("Hallo Trace");
Trace.TraceInformation("Hallo Trace Info");
Trace.TraceWarning("Hallo Trace Warning");
Trace.TraceError("Hallo Trace Error");
