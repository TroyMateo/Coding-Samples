
// URL: https://www.youtube.com/watch?v=cST5TT3OFyg
// AUTHOR: Tim Corey
// TITLE: C# Data Access: Text Files
// FILE: tc_fileio_3.cs
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
            //String representing file path is created
            string filePath = "./tc_fileio.txt";

            //A list is created to hold person objects which the objects will be instantiated with data read from the file
            List<Person> people = new List<Person>();

            //A list of strings to hold all the read in data
            List<string> lines = File.ReadAllLines(filePath).ToList();

            //Foreach loop to iterate through the data and split the data by comma delimiters
            //All those newly split strings are used as the parameters passed to instantiate Person objects
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
            //This is display onto the console all the Person objects added so far and reflects data from file input
            Console.WriteLine("Read from text file");
            foreach (var person in people)
            {
                Console.WriteLine($"{ person.FirstName } { person.LastName }: { person.URL }");
            }
            //A new person is added to the people list by means of creating an anonymous object
            people.Add(new Person("Greg", "Jones", "www.test.com"));

            //String list output is created to hold all the elements to be written back out to the file
            List<string> output = new List<string>();

            //Foreach to add the Person objects that need to be written out to the file
            foreach (var person in people)
            {
                output.Add($"{ person.FirstName },{ person.LastName },{ person.URL }");
            }

            Console.WriteLine("Writing to text file");
            //All entries in the output list are now written back out onto the txt file
            File.WriteAllLines(filePath, output);

            Console.WriteLine("All entries written");

            Console.ReadLine();
        }
    }

    //==========
    //Person class and all of its definitions
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
//Greg,Jones,www.test.com