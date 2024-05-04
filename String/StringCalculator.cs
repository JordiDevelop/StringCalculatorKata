namespace String
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            if (!string.IsNullOrEmpty(numbers))
            {
                return int.Parse(numbers);
            }
            
            return 0;
        }
    }
}