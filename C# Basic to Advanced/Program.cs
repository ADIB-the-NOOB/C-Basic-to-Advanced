﻿using System;
// System all the collections of classes like - Console
// This namespace is a collection of - Interfaces, Structs, enum and Delegates

class Program
{
    /* 
    static void DataTypes()
    {
        // Console.WriteLine("min = {0}, max = {1}", int.MinValue, int.MaxValue);
        string name = "C:\\Name\\Helo";
        Console.WriteLine(name);

        // for Double back slash with my string
        string newName = @"C:\\Name\\Helo";
        // if someone want to treat Escape sequences like Normal Sequence then use @
        Console.WriteLine(newName);
    }
    
    static void Interactive()
    {
        Console.WriteLine("Please tell me your FirstName:");
        string userName = Console.ReadLine();

        Console.WriteLine("LastName :");
        string lastName = Console.ReadLine();

        // Console.WriteLine("Hello " + userName);
        Console.WriteLine("Hello, {0} {1}", userName, lastName);
    }
    */

    static void Main()
        // Main() method is the entry point of the Program.
    {
        // Console.WriteLine("This is me who is a Noob Pythonista");
        // we also can use System.Console.WriteLine if we don't use namespace declaration - "using System"
        // Main1();
        // Interactive();
        // DataTypes();

        int number1 = 23;
        int number2 = 34;
        
        if (number1 == number2)
        {
            Console.WriteLine("number1 is equal to number2");
        }
        else
        {
            Console.WriteLine("it's not!");
        }
    }
}