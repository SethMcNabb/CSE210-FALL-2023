using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };

        foreach (string s in animationStrings)
        {
            Console.Write("\r" + s);
            Thread.Sleep(1000);
        }

        Console.WriteLine("\rDone!");
    }
}
