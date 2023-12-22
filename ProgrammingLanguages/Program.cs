using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
    class Program
    {
        static void Main()
        {
            List<Language> languages = File.ReadAllLines("../../../languages.tsv")
                .Skip(1)
                .Select(line => Language.FromTsv(line))
                .ToList();
            
            foreach (var language in languages)
            {
                Console.WriteLine(language.Prettify());
            }
            
            Console.WriteLine();
            
            var queryLanguagueInString = languages
                .Select(l => l.Name);
            
            PrintItAll(queryLanguagueInString);
            var cSharp = languages
                .Where(l => l.Name == "C#")
                .Select(l => l.Year);
            Console.WriteLine(cSharp.First());
            
            var microsoftLanguages = languages
                .Where(l => l.ChiefDeveloper == "Microsoft")
                .Select(l => l.Name);
            
            PrintItAll(microsoftLanguages);
            
            var lispDescendants = languages
                .Where(l => l.Predecessors.Contains("Lisp"))
                .Select(l => l.Name);
            
            var scriptLanguages = languages
                .Where(l => l.Name.Contains("Script"))
                .Select(l => l.Name);
            
            PrintItAll(scriptLanguages);

            var countLanguages = languages
                .Where(l => l.Year >= 1995 && l.Year <= 2005)
                .Select(l => l.Name);
            Console.WriteLine(countLanguages.Count());

            var nearMillenium = languages
                .Where(l => l.Year >= 1995 && l.Year <= 2005)
                .Select(l => $"{l.Name} was created in {l.Year}.");
            
            PrintItAll(nearMillenium);
            
             static void PrintItAll<T>(IEnumerable<T> items)
            {
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}