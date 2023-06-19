using System;
namespace ex23
{
	public class Family
	{
		protected const int FATHER = 0;
		protected const int MOTHER = 1;

		//public Family()
		//{
		//}

		// Person[] members = new Person[50];
		List<Person> members = new();

		public Family(Person daddy, Person mom)
		{
			members.Add(daddy);
			members.Add(mom);
		}

		public Person Father
		{
			get
			{
                return members[FATHER];
            }
		}

		//public Person GetMother()
		//{
		//	return members[MOTHER];
		//}

        public Person Mother
        {
            get
            {
                return members[MOTHER];
            }
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
			foreach(Person one in members)
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

