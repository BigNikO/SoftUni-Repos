using System.Collections.Generic;
using System.Linq;

namespace OldestFamilyMember
{
    public class Family
    {
        private List<Person> members;

        public List<Person> Members
        {
            get => this.members;
            set => this.members = value;
        } 
        
        public void AddMember(Person member)
        {
            this.Members.Add(member);
        }

        public Person GetOldestFamilyMember()
        {
            return this.members.OrderByDescending(x => x.Age).ToList()[0];
        }
    }
}
