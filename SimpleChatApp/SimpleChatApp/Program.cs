using System;
using System.Runtime.InteropServices;

namespace SimpleChatApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static void Init()
        {
            [DllImport("kernel32.dll")]
            static extern IntPtr GetConsoleWindow();

            [DllImport("user32.dll")]
            static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

            IntPtr ptr = GetConsoleWindow();
            MoveWindow(ptr, 10, 10, 800, 600, true);

            Console.SetWindowSize(200, 70);

            Logger.Verbose = false;
        }

        static void Main(string[] args)
        {
            Init();
            Logger.Log("Hello world!");
        }
    }
}