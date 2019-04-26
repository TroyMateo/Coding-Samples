// URL: https://www.youtube.com/watch?v=cST5TT3OFyg
// AUTHOR: Tim Corey
// TITLE: C# Data Access: Text Files
// FILE: tc_fileio_1.cs
// CAPTURE DATE: 25 Apr 2019
// STUDENT: Troy Mateo
// SYNOPSIS: read in CSV text file; turn around and write it out

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ConsoleUI
{

    //=========
    class Program
    {

        //----------
        static void Main(string[] args)
        {
            //A string is declared using the same name as the file and the path the programmer intends to use
            string filePath = "./tc_fileio.txt";

            //File keyword used to identify that its a file we are about to read from
            //ReadAllLines is reading all the data from the txt file and putting it into a list of strings
            List<string> lines = File.ReadAllLines(filePath).ToList();

            //Foreach to put out onto the console all the data that was just read from the file
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            //A new entry is added to the string list lines
            lines.Add("Sue,Storm,www.stormy.com");

            //The information from the string list lines is written out to the txt file
            File.WriteAllLines(filePath, lines);

            Console.ReadLine();
        }
    }
}

//Outout 
//Tim,Corey,www.IamTimCorey.com
//Joe,Smith,www.youtube.com/IamTimCorey
//Sue,Storm,www.stormy.com