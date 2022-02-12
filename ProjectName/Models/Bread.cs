using System;
using Treats.Logic;

namespace BreadTime
{
    public class KeepItClassy
    {
        public static string whoIsClassy(string name) 
        {
            Console.WriteLine(name);
            string classyPerson = name + " you are classy!";
            return classyPerson;
        }
    }
}