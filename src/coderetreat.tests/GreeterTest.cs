using Xunit;
using FluentAssertions;

namespace coderetreat.tests
{
    public class GreeterTest
    {
        [Fact]
        public void GreeterGreets()
        {
            var name = "foo";
            var expectedGreeting = "Hello, foo!";
            var actualGreeting = Greeter.Greet(name);
            actualGreeting.Should().Be(expectedGreeting);
        }
    }
}
