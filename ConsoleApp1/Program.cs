using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var a1 = useRegex("#1234-abc de");
            //var a2 = useRegex("#1");
            //var a3 = useRegex("1, Red House, 2551");
            var false1 = RegularExpression.UseRegex("-1"); // floatRange
            var false2 = RegularExpression.UseRegex("-0.1"); // floatRange
            
            var double_true_1 = RegularExpression.UseRegex("0.0"); // floatRange
            var double_true_3 = RegularExpression.UseRegex("0.1"); // floatRange
            var double_true_4 = RegularExpression.UseRegex("0.2"); // floatRange
            var double_true_5 = RegularExpression.UseRegex("5.5"); // floatRange
            var double_true_6 = RegularExpression.UseRegex("9.9"); // floatRange
            var double_true_7 = RegularExpression.UseRegex("10"); // floatRange

            var comma_true_1 = RegularExpression.UseRegex("0,0"); // floatRange
            var comma_true_2 = RegularExpression.UseRegex("0,1"); // floatRange
            var comma_false_1 = RegularExpression.UseRegex("00,0"); // floatRange
            
            var wrong_delimeter_false_1 = RegularExpression.UseRegex("0`0"); // floatRange
            var wrong_delimeter_false_2 = RegularExpression.UseRegex("0 0"); // floatRange

            var double_true_8 = RegularExpression.UseRegex("10.0"); // floatRange
            var double_false_9 = RegularExpression.UseRegex("10.1"); // floatRange
            
            var double_false_10 = RegularExpression.UseRegex("11.1"); // floatRange
            var double_false_11 = RegularExpression.UseRegex("11"); // floatRange
            var double_false_12 = RegularExpression.UseRegex("5.05"); // floatRange
            var double_false_13 = RegularExpression.UseRegex("05.5"); // floatRange
            var double_false_14 = RegularExpression.UseRegex("110"); // floatRange
            var double_false_15 = RegularExpression.UseRegex("111"); // floatRange

            var true1 = RegularExpression.UseRegex("0"); // floatRange
            var true_9 = RegularExpression.UseRegex("12HELL0111(123)"); // floatRange
            var true_10 = RegularExpression.UseRegex("10.0"); // floatRange
            var true13 = RegularExpression.UseRegex("1"); // floatRange
            var true14 = RegularExpression.UseRegex("2"); // floatRange
            //var true15 = RegularExpression.UseRegex("5 f 9"); // floatRange
            //var true16 = RegularExpression.UseRegex("60"); // floatRange
            //var true17 = RegularExpression.UseRegex("a"); // floatRange
            //var true18 = RegularExpression.UseRegex("a1"); // floatRange

            //var a1 = RegularExpression.UseRegex("45");

            Console.WriteLine("Hello World!");
        }
    }
}
