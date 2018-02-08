using System;
using System.IO;

namespace Lab1
{
    public class Output
    {
        public static void print(string path, lineList list)
        {
            using( StreamWriter OutputFile = new StreamWriter("./outputFilesFolder/" + path))
            {
                int lineNumber = 0;
                Console.WriteLine("Output:");
                while( lineNumber < list.getNumberOfLines())
                {
                    Console.WriteLine(list.getLine(lineNumber));
                    OutputFile.WriteLine(list.getLine(lineNumber));
                    lineNumber++;
                }
            }

            
        }
    }
}