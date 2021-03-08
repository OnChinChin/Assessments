/*
 * Appendix 3 - Exercise 1: Alphabetize a File
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace AIE_Assessment_Exercise_06
{
    class Program
    {
        


        static void Main(string[] args)
        {
            
            List<string> words = LoadWords("./Word.txt");
            SortWords(words);
            SaveWords(words , "./output.txt");

        }

         static List<string> LoadWords(string words)
        {
           
            List<string> tmp = new List<string>();


            using (StreamReader sr = File.OpenText(words)) 
            {
                // reads first line from file as an int
                int.TryParse(sr.ReadLine(), out int numberOfWords);


                for (int i = 0; i < numberOfWords; i++) //read the 
                {
                    tmp.Add(sr.ReadLine());

                }
            }
            return tmp;

        }
        static void SortWords(List<string> words)
        {
            words.Sort();
            
           
        }
        static void SaveWords(List<string> words, string filename)
        {
            var fileinfo = new FileInfo(filename);
            var dir = fileinfo.Directory.FullName;
            Directory.CreateDirectory(dir);

            using (StreamWriter sw = File.CreateText(filename))
            {
                for(int i = 0; i < words.Count; i++)
                {
                    sw.WriteLine(words[i]);

                }
           
            }
            
        }

    }
}
