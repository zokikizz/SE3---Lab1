using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // init
            
            lineList lineStorage = new lineList();

            //Input module
            Input.parse("inputFile.txt", lineStorage);
            Console.WriteLine("Input:");
            lineStorage.print();
            
            Console.WriteLine();
            Console.WriteLine();

            // CircularShift
            CircularShift.generateShifts(lineStorage);
            //Alphabetizer
            Alphabetizer.getSorted(lineStorage);

            Console.WriteLine();
            Console.WriteLine();

            Output.print("output.txt", lineStorage);
            

        }
    }
}
