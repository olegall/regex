using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class RegularExpression
    {
        public bool CheckCommitMsg(string input)
        {
            var regex = new Regex(@"#([0-9]{4}) /([a-z,0-9, ,,,.,:,(,),-]{5,100}$)");
            return regex.IsMatch(input);
        }

        /// <summary>
        /// Test
        /// ^...$ - начало/конец строки
        /// </summary>
        public static bool UseRegex(string input)
        {
            //Regex regex = new Regex("#1", RegexOptions.IgnoreCase);
            //Regex regex = new Regex("(#)(^[0-9]+$)", RegexOptions.IgnoreCase);

            //Regex regex = new Regex("(^[0-9])([a-z])", RegexOptions.IgnoreCase);
            //Regex regex = new Regex("^#[0-9]+$", RegexOptions.IgnoreCase);
            //Regex regex = new Regex("(^[0-9]+$)", RegexOptions.IgnoreCase);
            //var regex = new Regex(@"([a-zA-Z\s]*), ([a-zA-Z\s]*), ([0-9]{4})");
            //var regex = new Regex(@"#([0-9]{4})-([a-z, ,0-9]{5,10}$)");
            //var regex = new Regex(@"^[0.1-10.0]*$"); // float range
            //var regex = new Regex(@"^\d{1}(?:\.\d{0,1})|10|10.0?$"); // 0...10 float range

            //var regex = new Regex(@"^(\d{1}(?:\.\d{1}))|([1]{1}[0]{1})$"); // 0...10 float range

            //var regex = new Regex(@"^\d{1}(?:(\.|\,)\d{1})|[1]{1}[0]{1}$"); // 0...10 float range

            //var regex = new Regex(@"HELLO"); // float range
            //var regex = new Regex(@"[1]{1}[0]{1}\.[0]{1}"); // 10.0

            //var regex = new Regex(@"^[0-5]?[0-9]$"); // 0..59
            //var regex = new Regex(@"^\d{1}$"); // 0..9
            //var regex = new Regex(@"[0-9]|[0]");
            //var regex = new Regex(@"\d{3}");

            return regex.IsMatch(input);
        }
    }
}
