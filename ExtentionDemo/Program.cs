using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionDemo
{
    static class StringHelper //by using extention method we can extend the 
    {
        public static string FirstCaseChange(this string name)
        {
            char[] input = name.ToCharArray();
            input[0] = char.IsUpper(input[0]) ? Char.ToLower(input[0]) : Char.ToUpper(input[0]);
            return new string(input);
            //return input.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = "welcome";
            Console.WriteLine(name.FirstCaseChange());
        }
    }
}
