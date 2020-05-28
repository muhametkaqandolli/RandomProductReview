using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndClasses
{
    class Program
    {
        static string[] laudatoryPhrases =
        {
            "The product is excellent.",
            "This is a great product.",
            "I use this product constantly.",
            "This is the best product from this category."
        };
        static string[] laudatoryStories =
        {
            "Now I feel better.",
            "I managed to change.",
            "It made some miracle.",
            "I can't believe it, but now I am feeling great.",
            "You should try it, too. I am very satisfied."
        };
        static string[] authorName = { "Dayan", "Stella", "Hellen","Kate" };
        static string[] authorSurname =
        {
            "Johnson","Peterson","Charls"
        };
        static string[] cities = { "London","Paris","Berlin","New York","Madrid" };
        
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            Console.Write("{0} ", laudatoryPhrases[randomNumber.Next(0, 4)]);
            Console.Write("{0} ", laudatoryStories[randomNumber.Next(0, 5)]);
            Console.Write($"\n{authorName[randomNumber.Next(0,4)]} ");
            Console.Write($"{authorSurname[randomNumber.Next(0,3)]} ");
            Console.Write($"from {cities[randomNumber.Next(0,5)]}.");

            Console.ReadLine();
        }
    }
}
