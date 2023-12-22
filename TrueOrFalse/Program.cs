namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Type your code below
            
            string[] questions = new string[]
            {
                "An eggplant is also known as an aubergine.", "The color orange is named after the fruit.", "Carrots are purple."
            };
            
            bool[] answers = new bool[]
            {
                true, true, false
            };
            
            bool[] responses = new bool[questions.Length];
            
            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Warning! The number of questions and answers are not equal.");
            }
            
            int askingIndex = 0;

            foreach (string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;
                
                Console.WriteLine(question);
                Console.WriteLine("True or False?");
                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);
                
                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                
                responses[askingIndex] = inputBool;
                askingIndex++;
            }
            /*Console.WriteLine("Let's see how you did!");
            foreach (bool response in responses)
            {
                Console.WriteLine(response);
            */
            int scoringIndex = 0;
            
            int score = 0;
            
            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex + 1}. Input: {response} | Answer: {answer}");
                
                if (response == answer)
                {
                    score++;
                }
                
                scoringIndex++;
            }
            
            Console.WriteLine($"You got {score} out of {questions.Length} correct!");
        }
      
        }
    }
