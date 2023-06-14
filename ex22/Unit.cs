

namespace ex22
{
	public class Weapon
	{
		private float damage;
		public Weapon()
		{
			damage = 10;
		}

		public void Upgrade()
		{
			damage += 5;
		}

        public float GetDamage()
		{
			return damage;
		}
	}

	public class SteamPack
	{
		private bool apply;
		private float addedSpeed;

		public SteamPack()
		{
			addedSpeed = 3f;
            apply = false;
		}

		public void Start()
		{
			apply = true;

			// thread를 시작함
		}

		private void ThreadRun()
		{
			// time check and apply to false
		}

		public bool steamPack
		{
			get
			{
				return apply;
			}
		}

		public float Speed
		{
			get
			{
				
				return apply==true ? addedSpeed : 0;
			}
		}
	}


	public class Vector
	{
		private float x;
		private float y;

		public Vector()
		{
			x = 0;
			y = 0;
		}

        public Vector(float x, float y)
        {
			this.x = x;
			this.y = y;
        }


		public void Move(string toward, float offset)
		{
            switch (toward)
            {
                case "LEFT":
                    x -= offset;
                    break;

                case "RIGHT":
                    x += offset;
                    break;

                case "UP":
                    y -= offset;
                    break;

                case "DOWN":
                    y += offset;
                    break;

                default:
                    break;
            }
        }

    }

    public class Unit
	{
		private protected string tag;

		private protected float hp;
		private protected float damage;
        private protected float speed;

        private protected Weapon? myWeapon;
		private protected Vector tranform;
        private protected SteamPack steampack = new();
		        
		public Unit()
		{
			tag = "Unit";

            tranform = new();
			hp = 100f;
			damage = 1f;
			myWeapon = null;
		}

		public void ShowHp()
		{
			Console.WriteLine("Hp is " + hp);
		}

		public void Attack(Unit target)
		{
			float damage = this.damage;
			if (myWeapon != null)
				damage += myWeapon.GetDamage();

			target.BeAttacked(damage);
		}

		public void BeAttacked(float damage)
		{
			hp -= damage;
		}

		public void SteamPack(bool trigger)
		{
			steampack.Start();
        }

		public void Move(string toward)
		{
			float offset = speed + steampack.Speed;
			tranform.Move(toward, offset);           
		}

		public void SetWeapon(Weapon weapon)
		{
			myWeapon = weapon;
		}

		public virtual void Skill(int x, int y)
		{
			Console.WriteLine($"{x},{y} 지점에 스킬을 사용하였습니");
		}

        public virtual void Skill(Unit target)
        {
            Console.WriteLine($"{target}에 스킬을 사용하였습니");
        }
    }

	public class Marine : Unit
	{
		public Marine() : base()
		{
			tag = "Marine";
        }
	}


	public class Firebat : Unit
	{
        public Firebat() : base()
        {
            tag = "Firebat";
            damage = 1.3f;            
        }

        public override void Skill(int x, int y)
        {
			Console.WriteLine("파이어뱃이 스킬을 사용합니다.");
			base.Skill(x, y);
        }

        public override void Skill(Unit target)
        {
            Console.WriteLine("파이어뱃이 스킬을 사용합니다.");
			base.Skill(target);
        }
    }

	public class Ghost : Unit
	{
		public Ghost() : base()
		{
            tag = "Ghost";
            damage = 1.3f;
        }

		public void NuclearLaunch(Vector location)
		{

		}
    }

	public class NuclearBomb
	{
        public NuclearBomb()
		{

		}
    }


	public class NuclearQueue
	{
		public NuclearQueue()
		{

		}
    }




    public class UnitGroup
	{
		private LinkedList<Unit> group = new LinkedList<Unit>();
		public UnitGroup()
		{

		}

		public void Add(Unit unit)
		{
			//return group.Append<Unit>(unit);
			group.AddLast(unit);
		}

		public IEnumerator<Unit> GetEnumerator()
		{
			return group.GetEnumerator();
		}
	}

	public class ProgramEx : ex14.Program
	{
		public ProgramEx()
		{
			this.myval = 0;		// protected 와 protected private 과의 차이
		}
	}


	//public class SingletonClass
	//{
	//	private static SingletonClass instance;

	//	private SingletonClass()
	//	{
	//	}

	//	public static SingletonClass Instance
 //       {
	//		get
	//		{
	//			if (instance==null)
	//			{
	//				instance = new SingletonClass();
	//			}
	//			return instance;
	//		}
	//	}
	//}
}

