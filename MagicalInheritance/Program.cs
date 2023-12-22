namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm storm = new Storm("wind", false, "Zul'rajas");
            Console.WriteLine(storm.Announce());
            
            Pupil pupil = new Pupil("Mezil-kree");
            Storm windStorm = pupil.CastWindStorm();
            Console.WriteLine(windStorm.Announce());
            
            Mage mage = new Mage("Gul'dan");
            Storm rainStorm = mage.CastRainStorm();
            Console.WriteLine(rainStorm.Announce());
            
            Archmage archmage = new Archmage("Nielas Aran");
            Storm archmageRainStorm = archmage.CastRainStorm();
            Storm archmageLightningStorm = archmage.CastLightningStorm();
            Console.WriteLine(archmageRainStorm.Announce());
        }
    }
}