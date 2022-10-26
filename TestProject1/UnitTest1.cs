using ConsoleApp1;
using NUnit.Framework;
using System.ComponentModel.DataAnnotations;

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
        public void TestCommitMsgRegex()
        {
            // Arrange
            var validCommits = new[]
            {
                "#1234-abcde",
                "#1234-abcdefg",
                "#0000-abcdefg",
            };
            
            var invalidCommitsTaskNumber = new[]
            {
                "#123-abcde",
                "#12345-abcde",
                "#12-abcde"
            };

            // Act

            // Assert
            foreach (var validCommit in validCommits) 
            {
                Assert.True(_regex.CheckCommitMsg(validCommit));
            }
            
            foreach (var invalidCommit in invalidCommitsTaskNumber) 
            {
                Assert.False(_regex.CheckCommitMsg(invalidCommit));
            }

            Assert.Pass();
        }
    }
}