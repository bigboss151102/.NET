using System;
using System.ComponentModel.DataAnnotations;

namespace CSharpFundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really long text ";
            var summary = StringUtility.SummerisingText(sentence, 25);
            Console.WriteLine(summary);
        }

       
       
    }
}