namespace ex17;
class Program
{
    static void Main(string[] args)
    {
        // 추가적인 데이터 형
        bool exist = false;
        int number = 1;
        long lNumber = 10L;
        float pi = 3.14F;
        double distance = 42.195D;

        char ch = '김';
        string myName = "Kim";


        Console.WriteLine(exist);
        Console.WriteLine(number);
        Console.WriteLine(lNumber);
        Console.WriteLine(pi);
        Console.WriteLine(distance);
        Console.WriteLine(ch);
        Console.WriteLine(myName);


        byte b = 10;    // 1 byte (unsigned integer)
        uint uNumber = 100;     // 4byte
        ulong ulNumber = 1000L; // 8byte
        short shortNumber = -300;   // 2byte signed integer
        ushort ushortNumber = 300;  // 2byte unsigned integer

        decimal dNum = 100000000000;    // 16 byte, 금융등 정밀하고 매우 큰숫자를 표현하는데 사용가
        var myVar = 10;

        Console.WriteLine(b);
        Console.WriteLine(uNumber);
        Console.WriteLine(ulNumber);
        Console.WriteLine(shortNumber);
        Console.WriteLine(ushortNumber);
        Console.WriteLine(dNum);
        Console.WriteLine(myVar);

        // myVar = 1.0;   // 이미 정수로 초기화되었으므로 다른 타입 대입 불가

        var myFloatVar = 2.0F;
        //myFloatVar = 1;
        Console.WriteLine(myFloatVar);
        Console.WriteLine(myFloatVar.GetType());

        // var 타입
        // 지역 변수로만 사용가능
        // 선언과 동시에 초기화되어야만 함
        // 한번 데이터 형식이 결정되면 바꿀수 없음
        // 형식을 알수 없는 데이터의 초기화를 해야하는 경우 사용
    }
}

