﻿using System;
// System all the collections of classes like - Console
// This namespace is a collection of - Interfaces, Structs, enum and Delegates

class Program
{
    static void Interactive()
    {
        Console.WriteLine("Please tell me your name:");
        string userName = Console.ReadLine();
        Console.WriteLine("Hello " + userName);
    }

    static void Main1()
    {
        Console.WriteLine("this is executing from Main1 function");
    }

    static void Main()
        // Main() method is the entry point of the Program.
    {
        Console.WriteLine("This is me who is a Noob Pythonista");
        // we also can use System.Console.WriteLine if we don't use namespace declaration - "using System"
        Main1();
        Interactive();
    }
}