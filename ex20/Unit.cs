using System;
namespace ex20
{
    // class 객체를 생성하기 위한 정의(설계) 코드
    // 객체(object, instance) : class에 의 정의에 따라 구현된(생성된) 메모리 블럭

    /* class 의 정의는
	 * 
	 * class 클래스명
	 * {
	 * }
	 * 
	 * 와 같은 형식으로 정의할 수 있으, { } 내에 객체 생성에 필요한 모든 정의들이 이루어져야 한다 
	*/

    /*
	 * 멤버(Member)
	 * 필드(변수) , 상수 , 속성 , 메소드 , 생성자 , 이벤트 , 종료자 , 인덱서 , 연산자 , 중첩 형식 
	 * 
	*/


    /*
     * 접근 제어자 : 멤버 접근 가능성에 대한 제한을 두는 지시자 
     * public : 접근에 대한 제한이 없음, 완전 공개 
     * protected : 해당 클래스 또는 파생(상속된) 클래스에서 접근 가능 
     * internal : 현재 어셈블리까지 접근 가능 
     * protected internal : 현재 어셈블리 + 파생된 클래스 접근 가능 
     * private : 현재 클래스에서만 접근 가능 
     * private protected : 현재 클래스 + 현재 어셈블리내의 파생 클래스에서 접근 가능      * 
	*/

	public struct POINT
	{
		public int x;
		public int y;

		public POINT(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
	}


    public abstract class Unit
	{
		// 필드 
		internal string name;	// 현재 클래스와 이 프로그램내의 다른 클래스들에서 접근 가능 
		protected int id;		// 현재 클래스와 파생되는(상속받는) 클래스에서 접근 가능 
		protected internal int mp;  // 실행 파일내 모든 클래스들과 파생되는(상속받는) 클래스에서 접근 가능 
		private protected int color; // 현재 클래스와 파생되는(상속받는) 클래스에서 접근 가능 
        int hp;     // 접근지정자를 지정하지 않으면 기본은 private, 현재 클래스에서만 접근 가능
		int x;
		int y;


		// 생성자 : 객체를 생성할때 초기화등을 위해 가장 먼저 실행되는 코드(메소드)
		// 생성자는 class명과 이름이 같아야 한다
		// 생성자의 접근 제어자는 public 이어야 한다 
		public Unit()
		{
			id = 1;
			name = "Unit";
			hp = 100;
			mp = 200;
			color = 0;
			x = 0;
			y = 0;
		}


		// 속성 : property
		public POINT Position
		{
			get
			{
				POINT pt;
				pt.x = this.x;
				pt.y = this.y;
				return pt;
			}

			set
			{
				x = value.x;
				y = value.y;
			}
		}

		~Unit()
		{
			// 종료자 : finalizer, 보통 할당된 자원들을 해제할때 구현 
		}

		// 일반적인 메소드의 형태 인스턴스 메소드라고 함 
		public void Move(int x, int y)
		{
			// this 는 이 객체 자체를 의미함 
			this.x = x;
			this.y = y;
		}

		public void Move(POINT pt)		// 메소드 오버로딩 Overloading
		{
            this.x = pt.x;
            this.y = pt.y;
        }

		public virtual void Attack(Unit target)		// virtual 키워드를 이용하여 오버라이딩 가능한 메소드로 정의 	
		{
			// Attack 기능에 대한 기본 구현만 처리함 (필요없으면 구현하지 않아도 됨)
			Console.WriteLine("Unit class의 Attack이 실행됨");
		}

		public abstract void Skill(POINT pt);

	}

	public class Marine : Unit
	{
		public Marine()
		{
			id = 100;
			mp = 300;
			color = 255;
		}

        public override void Attack(Unit target)		// 메소드 오버라이딩 Overriding
        {
			// 파생된 객체의 특성에 맞는 Attack 기능을 수행하고...
            Console.WriteLine("Marine class의 Attack이 실행됨");

            // base 객체의 기본 구현된 Attack 기능을 실행함 (필요없으면 안해도 됨)
            base.Attack(target);	
		}

        // 추상 메소드를 오버라이딩 한것임, 추상 메소드는 자식 클래스에서 반드시 구현(Overriding)해야됨 
        public override void Skill(POINT pt)	
		{
			Console.WriteLine($"Marine이 {pt.x}, {pt.y} 지점에 스킬을 사용함");
		}
    }

    public class Firebat : Unit
    {
        public Firebat()
        {
            id = 100;
            mp = 300;
            color = 255;
        }

        public override void Attack(Unit target)		// 메소드 오버라이딩 Overriding
        {
            // 파생된 객체의 특성에 맞는 Attack 기능을 수행하고...
            Console.WriteLine("Firebat class의 Attack이 실행됨");

            // base 객체의 기본 구현된 Attack 기능을 실행함 (필요없으면 안해도 됨)
            base.Attack(target);
        }

        // 추상 메소드를 오버라이딩 한것임, 추상 메소드는 자식 클래스에서 반드시 구현(Overriding)해야됨 
        public override void Skill(POINT pt)
        {
            Console.WriteLine($"Firebat이 {pt.x}, {pt.y} 지점에 스킬을 사용함");
        }
    }
}



/*
구조체(struct)와 클래스(class)는 C#에서 둘 다 사용되는 형식입니다. 하지만 구조체와 클래스는 몇 가지 중요한 차이점을 가지고 있습니다.

값 형식 vs 참조 형식:

구조체는 값(Value) 형식입니다.구조체 변수는 스택(stack)에 할당되며, 값 복사에 의해 전달됩니다.
클래스는 참조(Reference) 형식입니다.클래스 변수는 힙(heap)에 할당되며, 참조를 통해 전달됩니다.
상속:

구조체는 다른 구조체나 클래스로부터 상속받을 수 없습니다. 구조체는 단일 상속만 가능합니다.
클래스는 다른 클래스로부터 상속받을 수 있으며, 다중 상속도 가능합니다.
Null 가능성:

구조체는 값 형식이므로 null 값을 가질 수 없습니다. 구조체 변수는 항상 초기화되어 유효한 값을 갖습니다.
클래스는 참조 형식이므로 null 값을 가질 수 있습니다. 클래스 변수는 초기화되지 않았을 경우 null로 설정됩니다.
메모리 할당:

구조체는 스택(stack)에 할당되므로 메모리 할당 및 해제가 빠릅니다. 작은 크기의 데이터를 저장하는 데 유용합니다.
클래스는 힙(heap)에 할당되므로 메모리 할당 및 해제에 오버헤드가 발생합니다. 크기가 큰 객체 및 동적인 데이터 구조를 나타내는 데 유용합니다.
사용 방법:

구조체는 주로 작은 데이터 값을 표현하거나 간단한 동작을 가지는 작은 개체에 사용됩니다.
클래스는 주로 복잡한 개체, 상태를 유지하고 동작을 포함하는 객체에 사용됩니다.
*/
