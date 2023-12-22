namespace DatingProfile;

public class Profile
{
    // fields
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;
    
    // constructors
    public Profile(string name, int age, string city, string country, string pronouns, string[] hobbies)
    {
        this.name = name;
        this.age = age;
        this.city = city;
        this.country = country;
        this.pronouns = pronouns;
        this.hobbies = hobbies;
    }
    
    // methods
    
    // view profile
    
    public string ViewProfile()
    {
        string bio = $"Name: {name}\nAge: {age}\nCity: {city}\nCountry: {country}\nPronouns: {pronouns}\nHobbies: ";
        foreach (string hobby in hobbies)
        {
            bio += hobby + ", ";
        }
        return bio;
    }
    
}