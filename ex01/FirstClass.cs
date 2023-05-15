using System;

// namespace는 class들을 그룹화하, 관리하는 영역(범위)을 정의합니다
// namespace는 실행되는 해당 프로세스안에서 고유한 명칭을 사용합니다
// 일반적으로 namespace 영역안에(inside of namespace range) class들을 정의합니다
//
// 'using'키워드를 이용하여 정의한 namespace 영역을 불러올 수 있으며,
// 불러들인 namespace안에 정의된 모든 class들을 사용하여 객체로 생성하여 접근할 수 있습니다 
namespace ex01
{
	// 이것은 클래스 입니다
	// 클래스는 객체를 정의하는 C#형식에 따르는 구조화된 코드입니다
	// 클래스로부터 객체(Object, Instance)를 생성할 수 있습니다
	// 클래스는 기본적으로 속성(Member Variable, Property(ies), Attribute(s)),
	// 행위(Member Function(s), Method(s))를 갖습니다

	// 이러한 클래스들의 정의와 정의된 클래스로 객체들을 생성하,
	// 객체들간의 유기적인 관계와 그들간의 데이터의 흐름을 유도하여,
	// 프로그래밍하는 기법을 '객체 지향형 프로그래밍(Object Oriented Programming, OOP)'이라고 합니
	
	// 아래에서 'public'은 클래스의 접근 제어자로써,
	// 해당 클래스로 객체를 생성할 수 있는 caller들을 제한하는 역할을 수행하는 키워드입니다.
	// 접근제어자로 'public'을 사용하면 외부에 완전 공개되어 객체 생성이 자유로운 클래스입니다

	// 'class'는 아래 코드 블럭이 class임을 명시하는 키워드입니다
	// class 이후 처음 나오는 '{'부터 '}'까지 해당 클래스의 코드입니다

	// 'FirstClass'는 class의 명칭(이름)입니다
	// 해당되는 namespace 영역에서 이 명칭은 고유한 값이어야 합니다
	// namespace 영역밖의 다른 namespace영역에서는 명칭이 중복되어도 괜찮고 ,
	// 이때 중복된 class명을 구분하기 위해 namespace(명).class(명)으로 구분하여 사용합니다
	// class의 이름은 'class'키워드 바로 다음에 위치해야 합니다 
	public class FirstClass
	{
		// 이것은 FirstClass의 생성자입니다.
		// 클래스의 생성자 메소드는 해당 클래스로 객체를 생성할때 실행됩니다.
		public FirstClass()
		{
            Console.WriteLine("Hello, C#!");
        }
	}
}

