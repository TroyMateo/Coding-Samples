// URL: https://www.youtube.com/watch?v=cST5TT3OFyg
// AUTHOR: Tim Corey
// TITLE: C# Data Access: Text Files
// FILE: tc_fileio_2.cs
// CAPTURE DATE: 25 Apr 2019
// STUDENT: Troy Mateo
// SYNOPSIS: read in CSV text file; dump objects out to console

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
            //String representing the file path is created
            string filePath = "./tc_fileio.txt";

            //The programmer this time wants to be able to read in the data from the file and put it into a list of people
            List<Person> people = new List<Person>();

            //String list is created to hold the read in data
            List<string> lines = File.ReadAllLines(filePath).ToList();

            //Foreach to iterate through the lines of data and splitting them by the comma delimiter. Each string split is then
            //used to create newPerson objects
            foreach (string line in lines)
            {
                string[] entries = line.Split(',');

                if (entries.Length != 3)
                {
                    Console.WriteLine("skipping invalid line in file: " + line);
                    continue;
                }

                Person newPerson = new Person(entries[0], entries[1], entries[2]);

                people.Add(newPerson);
            }

            Console.WriteLine();

            //A foreach to display that the person objects we indeed added properly
            foreach (var person in people)
            {
                Console.WriteLine($"{ person.FirstName } { person.LastName }: { person.URL }");
            }

            Console.ReadLine();
        }
    }

    //==========
    //The details of the person class have been created here. The split strings are used to instantiate a person object with the listed 
    //fields
    class Person
    {
        public string FirstName;
        public string LastName;
        public string URL;

        //----------
        public Person(string fn, string ln, string url)
        {
            FirstName = fn;
            LastName = ln;
            URL = url;
        }
    }
}

//Output
//Tim,Corey,www.IamTimCorey.com
//Joe,Smith,www.youtube.com/IamTimCorey
//Sue,Storm,www.stormy.com
