using Xunit;
using MyTeamCityProject;

namespace MyTeamCityProject.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestGreeting()
        {
            var message = Program.GetGreeting();
            Assert.Equal("Hello, TeamCity!", message);
        }
    }
}