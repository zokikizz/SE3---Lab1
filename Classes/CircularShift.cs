using System;
using System.Collections.Generic;


namespace Lab1 
{
    public class CircularShift
    {
        public static lineList generateShifts(lineList list)
        {
            //shift
            List<string> currentLine;
            List<string> temp = new List<string>();
            int numberOfLines = list.getNumberOfLines();
            string sentence = string.Empty;

            for(int i = 0 ; i < numberOfLines; i++)
            {
                currentLine = list.getLineAsListOfWords(i);

                int numberOfWords = currentLine.Count;
                for(int j = 0; j < (numberOfWords - 1); j++)
                {
                    temp.Add(currentLine[currentLine.Count-1]);

                    for(int k = 0; k < currentLine.Count-1; k++)
                        temp.Add(currentLine[k]);


                    for(int k = 0; k < numberOfWords; k++)
                    {
                        if( k != temp.Count-1)
                            sentence += temp[k] + " ";
                        else
                            sentence += temp[k];
                    }
                    currentLine = temp;
                    temp = new List<string>();
                    list.addNewSentence(sentence);
                    sentence = string.Empty;
                }

            }

            Console.WriteLine("After shifting:");
            list.print();

            return list;
        }
    }
}