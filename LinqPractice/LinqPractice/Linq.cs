using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    public class Linq
    {
        //member variable
        List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
        List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
        List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
        string name = "Carolynn";
        public Linq()
        {

        }      
        
        
        public void ReturnSubstring()
        {            
            List<string> resultOfFilter = words.Where(w => w.Contains("th")).ToList();
            foreach(string word in resultOfFilter)
            {
                Console.WriteLine(word);
            }

        }
        public void ReturnNoDuplicates()
        {
            List<string> resultOfNoDuplicates = names.Distinct().ToList();
            foreach( string name in resultOfNoDuplicates)
            {
                Console.WriteLine(name);                
            }
            Console.ReadLine();
        }
        public void ReturnAverage()
        {            
            var dropLowestForEachStudent = classGrades.Select(s => s.Split(',').Select(l => Convert.ToInt32(l)).ToList().OrderByDescending(n => n).Take(4).ToList().Average()).Average();
            Console.WriteLine(dropLowestForEachStudent);
            Console.ReadLine();

        }
        public void StringAlphabeticalFrequency()
        {            
            var result = name.ToLower().OrderBy(l => l).GroupBy(n => n).Select(n => new { Character = n.Key, Count = n.Count() });
            foreach (var item in result)
                Console.WriteLine(item.Character + "" + item.Count);         
                Console.ReadLine();
        }
    }
}
