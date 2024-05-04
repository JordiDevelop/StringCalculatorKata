namespace String.Tests
{
    public class StringCalculatorSpecs
    {
        [Fact]
        public void Return0IfEmpty()
        {
            var result = StringCalculator.Add("");
            Assert.Equal(0, result);
        }
        
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void ReturnNumbersIfOnlyOneNumber(int number)
        {
            var result = StringCalculator.Add(number.ToString());
            Assert.Equal(number, result);
        }
        
        [Theory]
        [InlineData("1,1",2)]
        [InlineData("1,2",3)]
        [InlineData("2,2",4)]
        public void ReturnSumIfTwoNumbers(string value, int expectedResult)
        {
            var result = StringCalculator.Add(value);
            Assert.Equal(expectedResult, result);
        }
        
        [Theory]
        [InlineData("1,1,1",3)]
        [InlineData("1,2,3",6)]
        [InlineData("2,2,3,5",12)]
        public void ReturnSumIfMoreThanTwoNumbers(string value, int expectedResult)
        {
            var result = StringCalculator.Add(value);
            Assert.Equal(expectedResult, result);
        }
        
        [Fact]
        public void ReturnSumIfMoreThanTwoSeparator()
        {
            var result = StringCalculator.Add("1,2\n3");
            Assert.Equal(6, result);
        }
    }
}