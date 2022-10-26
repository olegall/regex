using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class RegularExpression
    {
        public bool CheckCommitMsg(string input)
        {
            var regex = new Regex(@"#([0-9]{4})-([a-z, ,0-9]{5,10}$)");
            return regex.IsMatch(input);
        }
    }
}
