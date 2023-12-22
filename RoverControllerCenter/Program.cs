namespace RoverControllerCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            IDirectable lunokhod = new Rover("Lunokhod 1", 1970);
            IDirectable apollo = new Rover("Apollo 15", 1971);
            IDirectable sojourner = new Rover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);
            
            IDirectable[] rovers = {lunokhod, apollo, sojourner};
            
            DirectAll(rovers);
            
            IDirectable[] probes = {lunokhod, apollo, sojourner, sputnik};
            
            DirectAll(probes);
  		
        }
            static void DirectAll(IDirectable[] directables)
            {
                foreach (IDirectable d in directables)
                {
                    Console.WriteLine(d.GetInfo());
                    Console.WriteLine(d.Explore());
                    Console.WriteLine(d.Collect());
                }
            }
    }
}