using System;
namespace ex26
{
	public class ChampionData
	{		
		public ChampionData()
		{
		}       
    }


    public enum ChampionState
    {
        Normal,
        Injury,
        Dead
    }


	public abstract class Champion
	{
        ChampionState state;

        protected int hp;
        protected int damage;
        protected string name = "unknown";

        public Champion()
		{
            hp = 100;
            damage = 5;
            state = ChampionState.Normal;

        }

        public Champion(string name)
        {
            hp = 100;
            this.name = name;
            state = ChampionState.Normal;
        }


        public override string ToString()
        {
			return name;
        }

        protected virtual void BeAttacked(int damage)
        {
            hp -= damage;
        }


        public virtual void SkillQ(Champion target)
		{
			Console.WriteLine($"{target}에 Q 스킬을 사용하였습니다");
		}

		public virtual void Start()
		{
			ChampionData data = new();

			Thread thread = new Thread(ThreadLoop);
			thread.Start(data);
		}

		protected abstract void ThreadLoop(object? data);
	}



	public class Ezreal : Champion
	{
		public Ezreal() : base()
		{
		}

        public Ezreal(string name) : base(name)
        {
			Console.WriteLine($"{name} 객체가 생성되었습니");
        }

		// 메소드 오버라이드 
        public override void SkillQ(Champion target)
        {
            Console.WriteLine($"Ezreal이 {target}에 Q 스킬을 사용하였습니다");
        }

		// 추상 메소드의 오버라이드
		protected override void ThreadLoop(object? data)
		{
			while(true)
			{
				//Console.WriteLine($"{name}의 스레드 루프입니다.");
				Thread.Sleep(1000);
			}
		}
    }

	public class Kaisa : Champion
	{
		public Kaisa()
		{
		}

		public Kaisa(string name) : base(name)
		{
		}

        // 메소드 오버라이드 
        public override void SkillQ(Champion target)
        {
            Console.WriteLine($"Kaisa가 {target}에 Q 스킬을 사용하였습니다");
        }

        // 추상 메소드의 오버라이드
        protected override void ThreadLoop(object? data)
        {
            while (true)
            {
                //Console.WriteLine($"{name}의 스레드 루프입니다.");
                Thread.Sleep(1000);
            }
        }
    }

	public class Thresh : Champion
	{
        public Thresh()
        {
        }

        public Thresh(string name) : base(name)
        {
        }

        // 메소드 오버라이드 
        public override void SkillQ(Champion target)
        {
            Console.WriteLine($"Thresh가 {target}에 Q 스킬을 사용하였습니다");
        }

        // 추상 메소드의 오버라이드
        protected override void ThreadLoop(object? data)
        {
            while (true)
            {
                // Console.WriteLine($"{name}의 스레드 루프입니다.");
                Thread.Sleep(1000);
            }
        }
    }
}

