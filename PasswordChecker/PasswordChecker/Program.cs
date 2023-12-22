namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {

            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!@#$%^&*()_+";

            Console.WriteLine("Please enter a password: ");
            string password = Console.ReadLine();
            
            int score = 0;

            if (password.Length >= minLength)
            {
                score++;
            }

            if (Tools.Contains(password, uppercase))
            {
                score++;
            }

            if (Tools.Contains(password, lowercase))
            {
                score++;
            }

            if (Tools.Contains(password, digits))
            {
                score++;
            }
            
            if (Tools.Contains(password, specialChars))
            {
                score++;
            }
            Console.WriteLine($"Your password score is: {score}.");

            switch(score)
            {
                case 1:
                    Console.WriteLine("Your password is weak.");
                    break;
                case 2:
                    Console.WriteLine("Your password is medium.");
                    break;
                case 3:
                    Console.WriteLine("Your password is strong.");
                    break;
                case 4:
                    Console.WriteLine("Your password is very strong.");
                    break;
                case 5:
                    Console.WriteLine("Your password is extremely strong.");
                    break;
            }

        }
    }
}
