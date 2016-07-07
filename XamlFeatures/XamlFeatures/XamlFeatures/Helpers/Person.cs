using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamlFeatures
{
    public class Person
    {
        public string Name { get; }
        public int Age { get; }
        public string Gender { get; }

        public Person(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
    }

}
