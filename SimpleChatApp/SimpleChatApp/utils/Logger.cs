using System;
using System.Runtime.CompilerServices;

public static class Logger
{
    public static bool Verbose = false;
    public static void Log(string message,
        [CallerMemberName] string memberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0)
	{
        if (Verbose)
        {
            Console.WriteLine($"[Caller: {memberName}, File path: {sourceFilePath}, Line number: {sourceLineNumber}]");
        }
		Console.WriteLine($"{DateTime.Now} {message}");
	}
}
