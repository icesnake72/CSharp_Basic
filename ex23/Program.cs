namespace ex23;
class Program
{
    // c#에서 Thread 
    static void Main(string[] args)
    {
        // Person yoo = new();

        //DateTime dateTime = new DateTime(1900, 6, 15);
        //Person yoo = new("유재석", dateTime);

        // 첫번째 인물
        Person yoo = new("유재석", new DateTime(1972, 6, 15));

        // 이름 출력하기
        // Console.WriteLine(yoo.GetName());   // oldest format
        Console.WriteLine(yoo.Name);        // nice
        Console.WriteLine(yoo);             // excellent

        string? strName = yoo.Name;     // 특정 변수에 저장할때는 이런 방식이 좋다
        strName = yoo.ToString();       // 아니면 이와같은 방식도 많이 사용한다

        Console.WriteLine(yoo.Age);     // Person 클래스에는 없는 필드이, 프로퍼티 기능으로 나이를 지원함


        // 두번째 인물 
        Person jeon = new("전지현", new DateTime(1980, 6, 15));

        // 이름 출력하기
        // Console.WriteLine(yoo.GetName());   // oldest format
        Console.WriteLine(jeon.Name);        // nice
        Console.WriteLine(jeon);             // excellent

        strName = jeon.Name;     // 특정 변수에 저장할때는 이런 방식이 좋다
        strName = jeon.ToString();       // 아니면 이와같은 방식도 많이 사용한다

        Console.WriteLine(jeon.Age);     // Person 클래스에는 없는 필드이, 프로퍼티 기능으로 나이를 지원함


        // 세번째 인물
        Person iyou = new("아이유", new(2010, 6, 15));
        Console.WriteLine(iyou);


        // 네번째 인물
        Person rapmon = new("랩몬", new(2013, 6, 15));
        Console.WriteLine(rapmon);

        // 가족 구성원 만들기 
        Family yoosFam = new(yoo, jeon);
        yoosFam.Put(iyou);
        yoosFam.Put(rapmon);
        Console.WriteLine("유재석 가족의 구성원은 ... ");
        yoosFam.ShowMembers();

        Console.WriteLine($"아빠 : {yoosFam.Father}");
        Console.WriteLine($"엄마 : {yoosFam.Mother}");

        // 유재석의 가족찾기



        // 

    }
}

