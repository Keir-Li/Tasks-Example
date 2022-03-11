namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Submission for an Example Task" + Environment.NewLine + "By Keir Li"  + Environment.NewLine + "Written in .NET 6");
            Console.WriteLine("" + Environment.NewLine + "------------------------------------------- " + Environment.NewLine + "");

            RunSentenceTask();
            RunNumbersTask();
            RunResultTask();

        }

        private static void RunSentenceTask()
        {
            // Initialise and set the sentence string variable
            string sentence = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Eanean sodales justo et Enim ornare, a congue lacus commodo.";

            // Using LINQ extension 'Count' to calculate how many character E's there are in the string.
            int resultCapital = sentence.ToCharArray().Count(c => c == 'E');
            int resultLowercase = sentence.ToCharArray().Count(c => c == 'e');
            int totalResult = resultCapital + resultLowercase;

            // Print the result to the console
            Console.WriteLine("The given sentence is as follows... \n" + sentence);
            Console.WriteLine();
            Console.WriteLine("There are " + resultCapital + " capitcal E's in sentence.");
            Console.WriteLine("There are " + resultLowercase + " lowercase e's in sentence.");
            Console.WriteLine("Meaning there is a total of " + totalResult + " character E's in the sentence.");
            Console.WriteLine("" + Environment.NewLine + "-------------------------------------------" + Environment.NewLine + "");





        }


        private static void RunNumbersTask()
        {
            // Initialise and set the numbers string variable
            string numbers = "17272838119191929838299111";

            // Using LINQ extension 'Count' to calculate how many number 1's there are in the string.
            int result = numbers.ToCharArray().Count(n => n == '1');

            // Print the result to the console
            Console.WriteLine("There are " + result + " number 1's in the following list:  \n" + numbers);
            Console.WriteLine("" + Environment.NewLine + "-------------------------------------------" + Environment.NewLine + "");


        }

        private static void RunResultTask()
        {
            // Initialise and set the two number variables
            int number1 = 7;
            int number2 = 5;

            // Add the two numbers together
            int result = number1 + number2;

            // Print the result to the console
            Console.WriteLine("The Result of " + number1 + " + " + number2 + " = " + result);
        }
    }
}
