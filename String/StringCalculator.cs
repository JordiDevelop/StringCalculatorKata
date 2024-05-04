namespace String
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            var requestNumbers = numbers.Split(',', StringSplitOptions.RemoveEmptyEntries);
            if (requestNumbers.Length == 2)
            {
                return Int32.Parse(requestNumbers[0]) + Int32.Parse(requestNumbers[1]);
            }
            
            if (!string.IsNullOrEmpty(numbers))
            {
                return int.Parse(numbers);
            }
            
            return 0;
        }
    }
}