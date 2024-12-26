namespace Calculator.Tests
{
    public class CalculateTests
    {
        [Theory]
        [InlineData("3+1", 4)]
        [InlineData("10+10", 20)]
        [InlineData("-19+10", -9)]
        [InlineData("-19+(-1)", -20)]
        [InlineData("0+4", 4)]
        [InlineData("0+(-1)", -1)]
        [InlineData("0+0", 0)]


        [InlineData("3-1", 2)]
        [InlineData("10-10", 0)]
        [InlineData("-19-10", -29)]
        [InlineData("-19-(-1)", -18)]
        [InlineData("0-4", -4)]
        [InlineData("0-(-1)", 1)]
        [InlineData("0-0", 0)]


        [InlineData("3*1", 3)]
        [InlineData("10*10", 100)]
        [InlineData("-19*10", -190)]
        [InlineData("-19*(-1)", 19)]
        [InlineData("0*4", 0)]
        [InlineData("0*(-1)", 0)]
        [InlineData("0*0", 0)]


        [InlineData("3/1", 3)]
        [InlineData("10/10", 1)]
        [InlineData("-19/10", -1.9)]
        [InlineData("-19/(-1)", 19)]
        [InlineData("0/4", 0)]
        [InlineData("0/(-1)", 0)]


        public void CheckingTheResults(string input, double expected)
        {
            double actual = Calculator.Calculate(input); ;
            Assert.Equal(expected, actual);
        }



        [InlineData("")]
        [InlineData("10/0")]
        [InlineData("-1(9/)10")]
        [InlineData(")-19/(-1)")]
        [InlineData("0/4)(")]
        [InlineData("0/((-1)")]
        [InlineData(")-19/(-1)(")]


        public void CheckingTheResults_ThrowsOnBadInput(string input)
        {
            Action action = () => Calculator.Calculate(input);
            Assert.ThrowsAny<Exception>(action);
        }

    }
}