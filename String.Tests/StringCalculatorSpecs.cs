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
    }
}