namespace String
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            var requestNumbers2 = numbers.Split(',', '\n');

            int total = 0;
            foreach (var number in requestNumbers2)
            {
                total += Int32.Parse(number);
            }

            return total;

        }
    }
}