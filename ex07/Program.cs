namespace ex07;
class Program
{
    private static int hiddenNumber = 0;

    static void Main(string[] args)
    {
        // 기본 4가지 형식의 메소드

        // 1. 반환값(Return Value)도 없고, 매개변수(Parameters, Arguments)도 없는 메소드
        ShowUnknownError();     // 메소드의 호출 ( Call of a Method )


        // 2. 반환값(Return Value)이 없고, 매개변수(Parameters, Arguments)는 있는 메소드
        ShowErrorMessage("데이터 타입이 맞지 않습니다.", 1000); // 에러코드 1000번, 첫번째 파라미터 에러 메시지를 화면에 출력한다


        // 3. 반환값이 있고, 매개변수가 없는 메소드
        double pi = GetPI();   // GetPI()메소드 호출후 반환값을 pi 변수에 저장
        Console.WriteLine(GetUnknowMessage());  // GetUnknowMessage()메소드 호출후 받은 반환값을 콘솔 화면에 출력
        int nNumber = GetHiddenNumber();    // 특정 객체의 보안이 적용된 멤버 변수의 값을 노출시키는데 사용됨
        int randomValue = GetRandomNumber(); // 범위가 정해지지 않은 난수를 생성하는데 사용된 경우


        // 4. 반환값도 있고 매개변수도 있는 메소드
        string carName = IndexOf(3);
        Console.WriteLine(carName);
        Console.WriteLine(IndexOf(2));

        int hap = Add(10, 20);
        Console.WriteLine(hap);

        int myLottoNumber = GetRandomNumberInRange(45); // 1~45까지 랜덤한 숫자를 받아 myLottoNumber에 저장 
    }

    // 메소드 정의(구현)(Definition of a Method)

    // 1. 반환값(Return Value)도 없고, 매개변수(Parameters, Arguments)도 없는 메소드
    static void ShowUnknownError()
    {
        // 반환값과 매개 변수가 없는 메소드는, 일반적으로 정해져있는 값을 화면에 출력하거나 메세지를 띄울때 많이 사용됨
        Console.WriteLine("알 수 없는 에러입니다");
    }

    // 2. 반환값(Return Value)이 없고, 매개변수(Parameters, Arguments)는 있는 메소드
    static void ShowErrorMessage(string errorMsg, int errorCode)
    {
        //
        Console.WriteLine($"에러코드 : {errorCode}, {errorMsg}");
    }


    // 3. 반환값이 있고, 매개변수가 없는 메소드
    static double GetPI()
    {
        // 이미 보편적으로 정해져 있는 값이나, 또는 객체의 숨겨진 인스턴스 변수값을 외부로 전달할 때 사
        return 3.14D;
    }

    static string GetUnknowMessage()
    {
        // 이미 보편적으로 정해져 있는 값이나, 또는 객체의 숨겨진 인스턴스 변수값을 외부로 전달할 때 사용
        return "알 수 없는 에러입니다";
    }

    static int GetHiddenNumber()
    {
        hiddenNumber += 1;
        return hiddenNumber;
    }

    static int GetRandomNumber()
    {
        Random rnd = new Random();
        return rnd.Next();
    }


    // 4.반환값도 있고 매개변수도 있는 메소드
    // 일반적으로 가장 많이 사용되는 메소드의 형태 
    static string IndexOf(int index)
    {
        string[] cars = {"BMW", "BENZ", "AUDI", "PORCHE", "FERARRI"};
        if (cars.Length <= index || index < 0)
            return "";

        return cars[index];
    }

    static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    static int GetRandomNumberInRange(int until)
    {
        Random rnd = new Random();
        return rnd.Next(1, until+1);
    }

    // ...
}

