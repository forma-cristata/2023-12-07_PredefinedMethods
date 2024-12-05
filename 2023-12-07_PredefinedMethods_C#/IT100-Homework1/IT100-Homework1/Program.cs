/*
* Name: [YOUR NAME HERE]
* South Hills Username: [YOUR SOUTH HILLS USERNAME HERE]
*/

namespace IT100_Homework1
{
    public class Program
    {
        public static void Main()
        {
            //1
            String wizardOfOz = "Toto, I've a feeling we're not in Kansas anymore.";
            String feeling = wizardOfOz.Substring(13, 7);
            String kansas = wizardOfOz.Substring(34, 6);
            Console.WriteLine("1:\n" + feeling + " " + kansas);

            //2
            Thread.Sleep(1000);
            Console.WriteLine("\n2:\n" + wizardOfOz.IndexOf("Kansas"));

            //3
            Thread.Sleep(1000);
            Console.WriteLine("\n3:\n" + wizardOfOz.Replace(',', '\0').Replace('.', '\0'));

            //4
            Thread.Sleep(1000);
            Random rand = new Random();
            List<int> randos = new List<int>();
            int listIndex = rand.Next(10, 101);

            for (int i = 0; i < listIndex; i++)
            {
                randos.Add(rand.Next());
            }

            Console.WriteLine("\n4:\n" + String.Join(' ', randos) + "\n");

            //5
            Thread.Sleep(1000);
            int largestNumber = randos.Max();
            double average = randos.Average();
            int diff = Math.Abs(randos[0] - randos[listIndex - 1]);
            Console.WriteLine($"\n5:\nLargest element: {largestNumber} \nAverage: {average} \nDifference: {diff}");

            //6
            Thread.Sleep(1000);
            Console.Write("\n6:\nPick a number: ");
            String userPickString = Console.ReadLine();
            bool isNumeric;
            isNumeric = int.TryParse(userPickString, out int userPick);
            while (!isNumeric)
            {
                Console.WriteLine("Invalid input.  Only put in numbers please...");
                Console.Write("Pick a new number: ");
                userPickString = Console.ReadLine();
                isNumeric = int.TryParse(userPickString, out userPick);
            }
            bool containsNumber = randos.Contains(userPick);
            Thread.Sleep(1000);
            if (containsNumber) { Console.WriteLine("This list contains your number."); }
            else { Console.WriteLine("This list does not contain your number."); }

            //7
            Thread.Sleep(1000);
            Console.Write("\n7:\nPlease input several numbers, separated by spaces: ");
            String input = Console.ReadLine();
          
            List<String> inputStrings = input.Split(' ').ToList();
            Console.WriteLine(String.Join(", ", inputStrings));
            List<int> inputInts = new List<int>();

            for(int i = 0; i < inputStrings.Count; i++)
            {
                inputInts.Add(int.Parse(inputStrings[i]));
            }
            Console.WriteLine($"Sum of the numbers you input is {inputInts.Sum()}.");
        }
    }
}