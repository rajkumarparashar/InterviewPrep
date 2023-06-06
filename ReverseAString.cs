namespace InterviewPrep
{
    public class ReverseAString
    {
        public static void Reverse()
        {
            Console.WriteLine("Enter a string to reverse");
            var str = Console.ReadLine();

            int length = str.Length;
            string reverseString = string.Empty;

            while(length > 0)
            {
                reverseString = reverseString + str[length-1];
                length--;
            }

            Console.WriteLine(reverseString);
        }
    }
}
