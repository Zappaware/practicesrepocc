namespace MagicalInheritance;

public class Storm
{
    string Essence { get; set; }
    bool IsStrong { get; set; }
    string Caster { get; set; }
    
    public Storm(string essence, bool isStrong, string caster)
    {
        Essence = essence;
        IsStrong = isStrong;
        Caster = caster;
    }
    
    public string Announce()
    {
        if (IsStrong)
        {
            return $"{Caster} cast a strong {Essence} storm!";
        }
        else
        {
            return $"{Caster} cast a weak {Essence} storm!";
        }
    }
}