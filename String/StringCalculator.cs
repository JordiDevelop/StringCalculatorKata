namespace String
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            var requestNumbers2 = numbers.Split(',', StringSplitOptions.RemoveEmptyEntries);
            if (requestNumbers2.Length < 1) return 0;
            
            int total = 0;
            foreach (var number in requestNumbers2)
            {
                total += Int32.Parse(number);
            }

            return total;

        }
    }
}