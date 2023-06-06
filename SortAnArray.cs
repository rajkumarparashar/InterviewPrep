namespace InterviewPrep
{
    public class SortAnArray
    {
        public static void Sort()
        {
            Console.WriteLine("Enter input array");
            var inputstr = Console.ReadLine();

            int[] input = inputstr.Split(" ").Select(x => Convert.ToInt32(x)).ToArray();

            int temp = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if(input[i] < input[j])
                    {
                        temp = input[j];
                        input[j] = input[i];
                        input[i] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
