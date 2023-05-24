namespace ex12;
class Program
{
    static void Main(string[] args)
    {
        // 참조란 무엇인가???
        // 참조란 변수의 메모리상의 주소(Address)이다.


        int num1 = 10;
        int num2 = Accumulate(num1);
        Console.WriteLine($"num1={num1}, num2={num2}");

        // 일반 변수도 참조의 형태로 매개변수로써 이용할 수 있는가?
        num2 = Accumulate(ref num1);
        Console.WriteLine($"num1={num1}, num2={num2}");


        num1 = 10;
        num2 = 20;
        Console.WriteLine($"num1={num1}, num2={num2}");

        Swap(ref num1, ref num2);

        Console.WriteLine($"num1={num1}, num2={num2}");

    }

    // Call By Value (함수를 호출할때 값을 갖고 호출함)
    static int Accumulate(int n)
    {
        n += 10;
        return n;
    }

    // Call By Reference (함수를 호출할때 참조값을 갖고 호출함)
    static int Accumulate(ref int n)
    {
        n += 10;
        return n;
    }

    // Call By Reference (함수를 호출할때 참조값을 갖고 호출함)
    static void Swap(ref int num1, ref int num2)
    {
        int tmp = num1;
        num1 = num2;
        num2 = tmp;
    }
}

