using System;
namespace ex23
{
	public class Person
	{
		protected string? name;		// 이름 필드
        protected DateTime birth;	// 생년월일 필드

		// default constructor
		public Person()
		{
			name = "Unknown";
			birth = new(1800, 1, 1);
		}

		// option, customized constructor
		public Person(string name, DateTime dateOfBirth)
		{
			this.name = name;
			birth = dateOfBirth;
		}

		// method to set name field
		public void SetName(string name)
		{
			this.name = name;
		}

		// method to set birth field
		public void DateOfBirth(DateTime dateOfBirth)
		{
			birth = dateOfBirth;
		}

		// method to return name
		// public string? GetName()
		// {
		//	 return name;
		// }

        // C#으로 만드는 모든 클래스의 조상은 System.Object 클래스이며 묵시적으로, 필수적으로 상속된다!
        // 따라서 다음과 같이 ToString() 메소드를 상속 구현할 수 있다!
        // 이렇게 클래스를 대표하는 필드인것 같은 경우에는 ToString()메소드를 상속받아 처리해주면 좋다
        public override string? ToString()
        {
			return name;
        }

		// name 필드를 propery의 형식으로 반환해준다
		public string? Name
		{
			get
			{
				return name;
			}

			// 필드의 set method 사용은 신중히...
			set
			{
				name = Name;
			}
		}

        // method to return birth
        public DateTime GetDateOfBirth()
		{
			return birth;
		}

		// 나이를 갖는 필드를 따로 저장해둘 필요없이 birth필드로 나이 속성값을 만들어 반환해줌
		public ushort Age
		{
			get
			{
				TimeSpan days = DateTime.Now - birth;		// 현재 시간에서 birth 값을 빼줌(TimeSpan 객체로 반환)
				double daysOfYear = days.TotalDays / 365d;	// 토탈날짜에서 365로 나누어 나이를 대략 계산
				return (ushort)daysOfYear;
			}
		}
	}



	

}

