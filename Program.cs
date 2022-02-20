using System;
using System.IO;
using System.Collections.Generic;
/* Allen Atkins 
 * CST 150
 * Activity 12
 */

namespace Activity_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a StreamReader variable.
            StreamReader inputFile;

            // Open the file and get a StreamReader object.
            inputFile = File.OpenText("TextFile1.txt");

            // Creating a single string from inputFile
            string sRead = inputFile.ReadToEnd();
            string removeP = null;

            // Removing punctuation

            foreach (char c in sRead)
            {
                if (!char.IsPunctuation(c))
                {
                    removeP += c;
                }
            }

            // intializing and creating array 
            const int SIZE = 7;
            string[] stringSplit = removeP.Split(new[] { " ", "\n" }, StringSplitOptions.None);

            int charCounter = 0; // holder for counter 
            foreach(string str in stringSplit)
            {
                if(str.ToLower().EndsWith("e")  || str.ToLower().EndsWith("t"))
                {
                    charCounter++;
                    
                }
            }

            Console.WriteLine("The number of words that end with t's and e's is " + charCounter);
            Console.ReadLine();


        }
    }
}
