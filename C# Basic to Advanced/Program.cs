using System;
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

        /*
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
        */


        /*
        bool isNumber10;

        if (number == 10)
        {
            isNumber10 = true;
            Console.WriteLine(isNumber10);
        }
        else
        {
            isNumber10 = false;
            Console.WriteLine(isNumber10);
        }
        */

        // int number = 10;
        // bool isNumber10 = number == 10 ? true : false;
        // Console.WriteLine("Number is {0}, and it's {1}", number, isNumber10);
        // Using Ternary Operator

        // bool? areYouMajor = null;

        /*
        if (areYouMajor == true)
        {
            Console.WriteLine("User is Major");
        }
        else if (areYouMajor == false)
        {
            Console.WriteLine("User is not Major");
        }
        else
        {
            Console.WriteLine("User Did not answered the Question");
        }
        */

        int? TicketOnSale = null;
        int AvailableTickets = TicketOnSale ?? 0;

        Console.WriteLine("Available ticket - {0}", AvailableTickets);

        /*
        if (TicketOnSale == null)
        {
            TicketOnSale = 0;
            Console.WriteLine("Avaiable Tickets - {0}, TicketOnSale - {1}", AvailableTickets, TicketOnSale);
        }
        else
        {
            AvailableTickets = (int)TicketOnSale;
            Console.WriteLine("Avaiable Tickets - {0}, TicketOnSale - {1}", AvailableTickets, TicketOnSale);
        }*/
    }
}