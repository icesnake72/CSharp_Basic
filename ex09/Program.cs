namespace ex09;
class Program
{
    static void Main(string[] args)
    {
        // 응용 문제

        // 정수 0 ~ 6을 매개변수로 전달하면 "일요일" ~ "토요일" 까지 문자열을 반환하는 함수를 만들고
        // 호출하여 출력하는 예제를 만드세요

        // 이때 매개 변수가 6보다 크거나 , 0 보다 작을 경우 "그런 요일 없음" 을 반환하세요

        Console.WriteLine(GetWeek(0));
        Console.WriteLine(GetWeek(1));
        Console.WriteLine(GetWeek(2));
        Console.WriteLine(GetWeek(3));
        Console.WriteLine(GetWeek(4));
        Console.WriteLine(GetWeek(5));
        Console.WriteLine(GetWeek(6));

        Console.WriteLine(GetWeek(7));
        Console.WriteLine(GetWeek(59));
        Console.WriteLine(GetWeek(-1));
        Console.WriteLine(GetWeek(-487));
    }

    static string GetWeek(int n)
    {
        string[] week = {"일요일", "월요일", "화요일", "수요일", "목요일", "금요일", "토요일" };

        if (n > week.Length - 1 || n < 0)
            return "그런 요일 없음";

        return week[n];
    }
}

