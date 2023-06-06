namespace InterviewPrep
{
    public class LetterCountInSentence
    {
        public static void GetLetterCount()
        {
            Console.WriteLine("Enter sentence!");
            var sentence = Console.ReadLine();  

            Console.WriteLine("Enter letter to check!");
            char letter = char.Parse(Console.ReadLine());
            
            var count = sentence.Count(x => x == letter);

            Console.WriteLine(count);
        }
    }
}
