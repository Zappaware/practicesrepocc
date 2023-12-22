namespace ForestClassPractice
{
  class Forest
  {
    // FIELDS
    
    public int age;
    private string biome;
    private static int forestsCreated;
    private static string treeFacts;
    
    // CONSTRUCTORS
    
    public Forest(string name, string biome)
    {
      this.Name = name;
      this.Biome = biome;
      Age = 0;
      ForestsCreated++;
    }
    
    public Forest(string name) : this(name, "Unknown")
    { }

    static Forest()
    {
      treeFacts = "Forests provide a diversity of ecosystem services including:\r\n  aiding in regulating climate.\r\n  purifying water.\r\n  mitigating natural hazards such as floods.\n";
      ForestsCreated = 0;
    }
    
    // PROPERTIES
    
    public string Name
    { get; set; }
    
    public int Trees
    { get; set; }
    
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
    
    public int Age
    { 
      get { return age; }
      private set { age = value; }
    }
    
    public static int ForestsCreated
    {
      get { return forestsCreated; }
      private set { forestsCreated = value; }
    }
    
    public static string TreeFacts
    {
      get { return treeFacts; }
      // private set { treeFacts = value; }
    }
    
    // METHODS
     
    public int Grow()
    {
      Trees += 30;
      Age += 1;
      return Trees;
    }
    
    public int Burn()
    {
      Trees -= 20;
      Age += 1;
      return Trees;
    }
    public static void PrintTreeFacts()
    {
      Console.WriteLine(TreeFacts);
    }
    
  }
  /*class Forest
  {
      private int? _age;
      private string? _biome;
      
      public Forest(string? name, string? biome)
      {
         this.Name = name;
         this.Biome = biome;
         Age = 0;
      }
      
      public Forest(string? name) : this(name, "Unknown")
      {
          Console.WriteLine("Biome not specified. Value defaulted to 'Unknown'.");
      }
    
    public string? Name
    { get; set; }
    
    public int? Trees
    { get; set; }
    
    public string? Biome
    {
      get { return _biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          _biome = value;
        }
        else
        {
          _biome = "Unknown";
        }
      }
    }
    
    public int? Age
    { 
      get { return _age; }
      private set { _age = value; }
    }
    
    public int? Grow()
    {
        Trees += 30;
        Age += 1;
        return Trees;
    }
    
    public int? Burn()
    {
        Trees -= 20;
        Age += 1;
        return Trees;
    }
    
  }*/

}

