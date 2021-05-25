using System;
using System.Collections.Generic;
using System.IO;

namespace NedoExam2
{
    class Program
    {
        static void Main(string[] args)
        {
            var peopleInfo = File.ReadAllLines(@"../../../People.txt");
        } 
    }
}
