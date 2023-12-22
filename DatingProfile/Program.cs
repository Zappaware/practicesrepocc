namespace DatingProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hobbies = { "reading", "soccer", "writing" };
            Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him", hobbies);
            Console.WriteLine(sam.ViewProfile());
        }
    }
}