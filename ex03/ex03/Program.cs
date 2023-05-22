namespace ex03;
class Program
{
    static void Main(string[] args)
    {
        //MyClass me = new MyClass();

        //Console.WriteLine("이름을 입력하세요 >>>");
        //me.name = Console.ReadLine();

        //Console.WriteLine("나이를 입력하세요 >>> ");        
        //me.age = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("내이름은 " + me.name + "입니다");
        //Console.WriteLine("나이는 " + me.age + "살 입니다");

        string str1 = "hello";
        string str2 = "hello";
        if (str1 == str2)
            Console.WriteLine("같음");
        else
            Console.WriteLine("다름");

        // 문자열 붙이기 
        string str3 = str1 + str2;
        Console.WriteLine(str3);

        str3 = string.Concat(str1, str2);
        Console.WriteLine(str3);

        // 문자열 보간
        str3 = $"str1={str1}, str2={str2}";
        Console.WriteLine(str3);

        // 문자열의 접근
        Console.WriteLine(str1[0]); // h
        Console.WriteLine(str1[1]); // e
        Console.WriteLine(str1[2]); // l
        Console.WriteLine(str1[3]); // l
        Console.WriteLine(str1[4]); // o
        //Console.WriteLine(str1[5]); // 여기에서 오류 발생

        // 첫번째 나오는 l의 인덱스값을 반환 
        Console.WriteLine(str1.IndexOf("l"));
        int start = str1.IndexOf("l");

        // 해당 인덱스 값부터 뒤로 문자열 끝까지를 반환 
        str3 = str1.Substring(start);
        Console.WriteLine(str3);


        // 해당 인덱스 값부터 2개 문자를 반환
        // 첫번째 파라미터는 시작 인덱스이고, 두번째 파라미터는 그 이후부터 취할 문자열의 길이이다 
        str3 = str1.Substring(start, 2);    
        Console.WriteLine(str3);

        Console.WriteLine();

        // Escape 문자 ( Special Character )
        // \" (큰따옴표 표현), \'(작은따옴표 표현), \\(역슬레쉬 표현)
        // \n : 한 줄(Line) 띄기
        // \t : Tab
        // \b : Backspace
        str1 = "내 이름은 \"유재석\" 입니다";
        Console.WriteLine(str1);

        str2 = "내 이름은 \'강호동\' 입니다\n나이는 20세 입니다..\b\n\t씨름선수 출신이에요...";
        Console.WriteLine(str2);
    }
}

