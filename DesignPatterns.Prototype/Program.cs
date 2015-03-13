using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    /// <summary>
    /// The prototype pattern specifies the kind of objects to create using a prototypical instance and 
    /// allows to create new objects by copying this prototype.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var developer = new Developer() { Name = "Alex", Role = "Team Lead", PreferredLanguage = "C#" };
            var developerCopy = (Developer)developer.Clone();
            developerCopy.Name = "Tom";

            Console.WriteLine(developer.GetDetails());
            Console.WriteLine(developerCopy.GetDetails());

            Console.ReadLine();
        }
    }
}
