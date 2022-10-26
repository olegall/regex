using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        public static bool useRegex(string input)
        {
            //Regex regex = new Regex("#1", RegexOptions.IgnoreCase);
            //Regex regex = new Regex("(#)(^[0-9]+$)", RegexOptions.IgnoreCase);

            //Regex regex = new Regex("(^[0-9])([a-z])", RegexOptions.IgnoreCase);
            //Regex regex = new Regex("^#[0-9]+$", RegexOptions.IgnoreCase);
            //Regex regex = new Regex("(^[0-9]+$)", RegexOptions.IgnoreCase);
            //var regex = new Regex(@"([a-zA-Z\s]*), ([a-zA-Z\s]*), ([0-9]{4})");
            var regex = new Regex(@"#([0-9]{4})-([a-z, ,0-9]{5,10}$)");
            return regex.IsMatch(input);
        }

        static void Main(string[] args)
        {
            var a1 = useRegex("#1234-abc de");
            var a2 = useRegex("#1");
            var a3 = useRegex("1, Red House, 2551");
            Console.WriteLine("Hello World!");
        }
    }
}
