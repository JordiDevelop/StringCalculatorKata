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
        
        [Fact]
        public void ReturnNumbersIfOnlyOneNumber()
        {
            var result = StringCalculator.Add("1");
            Assert.Equal(1, result);
        }
        
        [Fact]
        public void Return2IfOnlyNumber2()
        {
            var result = StringCalculator.Add("2");
            Assert.Equal(2, result);
        }
    }
}