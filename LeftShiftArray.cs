namespace InterviewPrep
{
    public class LeftShiftArray
    {
        public static void Shift()
        {
            Console.WriteLine("Enter input array");
            var inputstr = Console.ReadLine();

            int[] input = inputstr.Split(" ").Select(x => Convert.ToInt32(x)).ToArray();

            int temp = input[0];
            for (int i = 0; i < input.Length-1; i++)
            {
                input[i] = input[i+1];
            }
            input[input.Length - 1] = temp;

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
