namespace ex10;
class Program
{
    static void Main(string[] args)
    {
        // 메소드에 배열을 전달하기 (매개변수로 배열을 전달하기)

        Random rnd = new Random();

        int[] arrNumbers = new int[10];
        for(int i=0; i<10; i++)
        {
            arrNumbers[i] = rnd.Next(1, 101);
        }

        int MaxVal = MaxValue(arrNumbers);

        Console.Write("배열의 값 : ");
        foreach (int num in arrNumbers)
            Console.Write($"{num}\t");

        Console.WriteLine();
        Console.WriteLine($"Maximum Value is {MaxVal}");

        //
        // 위 배열에서 최소값을 찾는 메소드를 만들고 위와 같은 방법으로 호출하고 위와 같은 형식으로 출력하세요
    }


    static int MaxValue(int[] arrNums)
    {
        if (arrNums.Length <= 0)
            return 0;

        int MaxValue = arrNums[0];
        for(int i=1; i<arrNums.Length; i++)
        {
            if (MaxValue < arrNums[i])
                MaxValue = arrNums[i];
        }

        return MaxValue;
    }
}

