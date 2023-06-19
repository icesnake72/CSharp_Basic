using System;
namespace ex23
{
	public class Group
	{
		protected string tag = "Unknown";
        protected List<Person> members = new();

        public Group()
		{            
        }

        public override string ToString()
        {
			return tag;
        }

        public int Put(Person someOne)
        {
            members.Add(someOne);

            return members.Count;
        }

        public int Remove(Person member)
        {
            members.Remove(member);

            return members.Count;
        }

        public void ShowMembers()
        {
            foreach (Person one in members)
            {
                Console.WriteLine(one);
            }
        }

        public List<Person> GetMembers()
        {
            return members;
        }
    }
}

