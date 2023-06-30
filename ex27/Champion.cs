using System;
namespace ex27
{
	public abstract class Champion : Skill
	{
		public string name;
		public Champion(string name)
		{
			this.name = name;
		}

        public override string ToString()
        {
			return name;
        }

        public abstract void SkillQ(Champion unit);
        public abstract void SkillW(Champion unit);
        public abstract void SkillE(Champion unit);
        public abstract void SkillR(Champion unit);
    }

	public class Ezreal : Champion
	{
		public Ezreal(string name) : base(name)
		{
		}

        public override void SkillQ(Champion unit)
		{
		}

        public override void SkillW(Champion unit)
		{
		}

        public override void SkillE(Champion unit)
		{
		}

        public override void SkillR(Champion unit)
		{
		}
    }
}

