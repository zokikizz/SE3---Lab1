using System;
using System.IO;

namespace Lab1 
{
    public class Input
    {
        public static void parse(string readFromFile, lineList lines)
        {

            string line;
            StreamReader file= new StreamReader("./inputFilesFolder/" + readFromFile);
            int lineNum = 0;
            //read from file
            while(  (line = file.ReadLine() ) != null)
            {
                lines.addNewSentence(line);
                
                lineNum++;
            }
        }
    }
}