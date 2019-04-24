/*
 * https://www.sanfoundry.com/csharp-program-count-file-extensions-linq/
 * 4/24/2019
 * Author: Manish Bhojasia
 * C# Program to Count File Extensions and Group it using LINQ
 * Edited by: Troy Mateo
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ConsoleApplication9
{
    class Program
    {
        public static void Main()
        {
            //A string array is created with a variety of file extensions
            string[] arr = { "aaa.txt", "bbb.TXT", "xyz.abc.pdf", "aaaa.PDF",
                             "abc.xml", "ccc.txt", "zzz.txt" };

            //Variable egrp is created and uses a LINQ function to sort and group the extensions from the string array
            //arr is letting us know where we are operating and Select is the keyword used to let us know what it is we are selecting
            //GroupBy is the keyword to..group the extensions
            var egrp = arr.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
                       .GroupBy(x => x, (ext, extCnt) => new
                       {
                           Extension = ext,
                           Count = extCnt.Count()
                       });
            //Program finishes up with a foreach loop now to go through egrp and group and count the extensions
            foreach (var v in egrp)
                Console.WriteLine("{0} File(s) with {1} Extension ",
                                    v.Count, v.Extension);
            Console.ReadLine();
        }
    }
}

/*4 File(s) with txt Extension
*2 File(s) with pdf Extension
*1 File(s) with xml Extension 
 */
