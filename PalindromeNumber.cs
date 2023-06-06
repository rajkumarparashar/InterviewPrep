namespace InterviewPrep
{
    public class PalindromeNumber
    {
        public static void IsPalindrome()
        {
            Console.WriteLine("Enter a number to check if it is palindrome");
            var number = Convert.ToInt32(Console.ReadLine());
            int backupNumber = number;
            int remainder = 0, reverseNumber = 0;

            while(number> 0)
            {
                remainder = number % 10;
                reverseNumber = reverseNumber * 10 + remainder;
                number = number / 10;
            }
            Console.WriteLine("Is given number palindrome? {0}", backupNumber == reverseNumber);
        }
    }
}
