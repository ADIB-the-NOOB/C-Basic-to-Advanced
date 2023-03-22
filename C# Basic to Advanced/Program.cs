using System;
using System.Runtime.Serialization;
// System all the collections of classes like - Console
// This namespace is a collection of - Interfaces, Structs, enum and Delegates

class Program
{
    static void Main()
    // Main() method is the entry point of the Program.
    {

        /*
            string[] carList = new string[3];
            carList[0] = "VN";
            carList[1] = "F";
            carList[2] = "C";
            Console.WriteLine(carList[1]);
        */
        /* Console.WriteLine("please give me your Number:");
        int userNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(userNumber);
        Console.WriteLine();
        */

        Console.WriteLine("phone_number");
        int userNumber = int.Parse(Console.ReadLine()); 

        switch(userNumber)
        {
            case 10:
                Console.WriteLine("Number is 10.");
                break;
            case 20:
                Console.WriteLine("Number is 20");
                break;
            default: Console.WriteLine("Number is not 10 or 20"); break;
        }

    }
}