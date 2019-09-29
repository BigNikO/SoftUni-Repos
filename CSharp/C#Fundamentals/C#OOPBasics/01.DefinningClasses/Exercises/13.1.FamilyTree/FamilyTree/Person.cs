using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTree
{
    public class Person
    {
        public string Name { get; set; }
        public List<Person> Parents { get; set; }
        public List<Person> Children { get; set; }
        public string BirthDate { get; set; }

        public Person()
        {
            this.Parents = new List<Person>();
            this.Children = new List<Person>();
        }

        public void AddChild(Person child)
        {
            this.Children.Add(child);
        }
        public void AddParent(Person parent)
        {
            this.Parents.Add(parent);
        }
    }
}
