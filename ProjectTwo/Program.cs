namespace ProjectTwo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // updated for demo
            // Create an instance of the StringProcessor class
            var processor = new StringProcessor();

            // Sample usage of the CountVowels method
            string inputString = "hello world";
            int vowelCount = processor.CountVowels(inputString);
            Console.WriteLine($"The number of vowels in '{inputString}' is: {vowelCount}");

            string inputString = "hello Saurang";
            int vowelCount = processor.CountVowels(inputString);
            Console.WriteLine($"The number of vowels in '{inputString}' is: {vowelCount}");

            // Sample usage of the Reverse method
            string reversedString = processor.Reverse(inputString);
            Console.WriteLine($"The reverse of '{inputString}' is: '{reversedString}'");

            // Sample usage of the Reverse method - 2
            inputString = "hello GitHub";
            string reversedString = processor.Reverse(inputString);
            Console.WriteLine($"The reverse of '{inputString}' is: '{reversedString}'");

        }
    }
}
