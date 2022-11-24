using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class RegularExpression
    {
        public bool CheckCommitMsg(string input)
        {
            var regex = new Regex(@"#([0-9]{4}) ([A-Za-z,0-9, ,,,.,:]{5,300}$)");
            return regex.IsMatch(input);
        }

        /// <summary>
        /// Test
        /// </summary>
        public static bool UseRegex(string input)
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
    }
}
