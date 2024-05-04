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
    }
}