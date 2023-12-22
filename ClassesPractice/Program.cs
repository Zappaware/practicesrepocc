namespace ForestClassPractice
{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            Forest.PrintTreeFacts();
            Console.WriteLine(Forest.ForestsCreated);
            Forest f = new Forest("Congo");
            Forest l = new Forest("Chiapas");
            Console.WriteLine(Forest.ForestsCreated);
        }
    }
}