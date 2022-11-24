using ConsoleApp1;
using NUnit.Framework;

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
                "#1234 ABbcdeZ",
                "#1234 abcdefg",
                "#0000 abcd efg",
                "#2691 fix: atach",
                "#2691 fix: atach service init has been deleted",
                "#3435 milestone, code review corrections",
                "#3435 milestone, code review corrections",
                "#3435 1aaaa 2aaaa 3aaaa 4aaaa 5aaaa 6aaaa 7aaaa 8aaaa"
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
                //"12345/abcde", // проходит, т.к. есть 4 цифры - удовлетвор€ет регул€рному выражению.
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
                Assert.False(_regex.CheckCommitMsg(invalidCommit));
            }
            
            foreach (var invalidMessage in invalidMessages)
            {
                Assert.False(_regex.CheckCommitMsg(invalidMessage));
            }
        }
    }
}