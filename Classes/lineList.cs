using System;
using System.Collections.Generic;

namespace Lab1 
{
    public class lineList
    {
       private List<string> parseList;

        public lineList()
        {
            this.parseList = new List<string>();
        }


        //for Input class

        public void addNewSentence(string sentence)
        {
            this.parseList.Add(sentence);
        }

        // for Circular Shift class

        public List<string> getLineAsListOfWords(int lineNum)
        {
            List<string> line = new List<string>();
            string[] sentence = this.parseList[lineNum].Split(' ', StringSplitOptions.None);
            for(int i = 0; i < sentence.Length; i++)
                line.Add(sentence[i]);

            return line;
        }

        public int getNumberOfLines()
        {
            return this.parseList.Count;
        }

        public void Sort()
        {
            this.parseList.Sort();
        }

        public void print()
        {
            for(int i = 0; i < this.parseList.Count; i++)
            {
                for(int j = 0; j < this.parseList[i].Split(' ', StringSplitOptions.None).Length; j++)
                {
                    Console.Write(parseList[i].Split(' ', StringSplitOptions.None)[j]);
                    if(j != (parseList[i].Split(' ', StringSplitOptions.None).Length - 1))
                        Console.Write(" -> ");
                }
                Console.WriteLine();
            }
        }

        public string getLine(int number)
        {
            if(number >= parseList.Count)
                return null;
            
            return parseList[number];
        }

        
    }
}