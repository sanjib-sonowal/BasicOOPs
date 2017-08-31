using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public static class FactoryMethodPattern
    {
        /*
         * Define an interface for creating an object, but let subclasses decide which class to instantiate. 
         * Factory Method lets a class defer instantiation to subclasses.
         */
        public static void RunProgram()
        {
            Console.WriteLine("FACTORY METHOD PATTERN");
            Console.WriteLine("=============================>>>");

            Document[] documents = new Document[3];
            documents[0] = new SkillsPage();
            documents[1] = new EducationPage();
            documents[2] = new ExperiencePage();

            foreach(Document doc in documents)
            {
                Page page = doc.Create();
                Console.WriteLine("Created {0}", page.GetType().Name);
            }

            Console.WriteLine("*************************************************\n");
        }
    }
}
