using ConsoleApp1;
using NUnit.Framework;
using System;

namespace TestProject1
{
    public class Tests
    {
        private readonly RegularExpression _regex; 

        public Tests()
        {
            _regex = new RegularExpression();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckCommitMsg_ValidData_Success()
        {
            // Arrange
            var validCommits = new[]
            {
                "#1234 /abcdez. 10 items",
                "#1234 /abcdefg",
                "#0000 /abcd efg",
                "#2691 /fix: atach",
                "#2691 /fix: atach service init has been deleted",
                "#3435 /milestone, code review corrections",
                "#3435 /milestone, code review corrections",
                "#3435 /1aaaa 2aaaa 3aaaa 4aaaa 5aaaa 6aaaa 7aaaa 8aaaa",
                "#0000 /,.:()-",
            };
            
            // Act

            // Assert
            foreach (var validCommit in validCommits) 
            {
                Assert.True(_regex.CheckCommitMsg(validCommit));
            }
        }
        
        [Test]
        public void CheckCommitMsg_InvalidData_Success()
        {
            // Arrange
            var invalidNumber = new[]
            {
                "/AbcdZ",
                "12/abcde",
                "123/abcde",
                //"12345/abcde", // ��������, �.�. ���� 4 ����� - ������������� ����������� ���������.
            };
            
            var invalidMessages = new[]
            {
                "1234/",
                "12/a",
                "3435/1aaaa 2aaaa 3aaaa 4aaaa 5aaaa 6aaaa 7aaaa 8aaaa 9aaaa 10aaaa"
            };

            // Act
            foreach (var invalidCommit in invalidNumber)
            {
                Assert.False(_regex.CheckFloat(invalidCommit));
            }
            
            foreach (var invalidMessage in invalidMessages)
            {
                Assert.False(_regex.CheckFloat(invalidMessage));
            }
        }

        [Test]
        public void CheckFloat() 
        {
            var valid = new[]
            {
                "0",
                "1",
                "2",
                "5",
                "10",
                //"",
                //"",
                //"",
                //"",
                //"",
                //"",
                //"",
                //"",
                //"",
                //"",
                //"",
                //"",
                //"",
                //"",
                //"",

                "0.0",
                "0.1",
                "0.2",
                "9.9",
                "10.0",

                "0,0",
                "0,1",
                "9,9",
                "10,0",
            };
            var invalid = new[]
            {
                "-1",
                "11",

                "",
                //null,
                "dsfsdfggf",
                "@#$%^&$",
                "a",
                "a1",
                "5.05",
                "05.5",
                "110",
                "111",
                "20",
                "50",
                "100",

                "00,0",
                "-0.1",
            };

            foreach (var item in valid)
            {
                Assert.True(_regex.CheckFloat(item));
                Console.WriteLine(item);
            }

            foreach (var item in invalid)
            {
                Assert.False(_regex.CheckFloat(item));
            }
        }
    }
}