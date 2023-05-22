namespace ex06;
class Program
{
    static void Main(string[] args)
    {
        int[] arrNums = new int[10];

        Random rnd = new Random();

        // 문제 1. 배열의 모든 칸에 1에서부터 100사이의 값을 대입
        for (int i = 0; i < 10; i++)
            arrNums[i] = rnd.Next(1, 101);

        unsafe
        {
            fixed (int* p = arrNums)
            {
                string hex = ((long)p).ToString("X");
                Console.WriteLine($"arrNums's Address = {hex}");
            }
        }
        

            // 문제 2. 배열의 모든 내용을 출력 (foreach)
            PrintArray(arrNums);
        //foreach (int i in arrNums)
        //    Console.Write($"{i}\t");

        Console.WriteLine();

        // 문제 3. 배열에 있는 값들을 오름차순으로 정렬하기
        for(int i=0; i<10-1; i++)
            for(int j=i+1; j<10; j++)
            {
                if (arrNums[i] > arrNums[j])
                {
                    int temp = arrNums[i];
                    arrNums[i] = arrNums[j];
                    arrNums[j] = temp;
                }
            }

        // 문제 4. 배열의 모든 내용을 출력
        PrintArray(arrNums);

        //foreach (int i in arrNums)
        //    Console.Write($"{i}\t");
        Console.WriteLine();
        for (int i = 0; i < 5; i++)
            SayHello();

        Console.WriteLine();
        SayGreetingMessages("안녕하세요", "대단히 반갑습니다", "상당히 고맙습니다", "더 많이 써도 됩니다");
        SayGreetingMessages();

        if (arrNums[0] is int)
        {
            Console.WriteLine("arrNums[0] is type of integer.");
        }

    }

    static void PrintArray(int[] arrNumbers)
    {
        foreach (int i in arrNumbers)
            Console.Write($"{i}\t");

        unsafe
        {
            fixed (int* p = arrNumbers)
            {
                string hex = ((long)p).ToString("X");
                Console.WriteLine($"arrNumbers's Address = {hex}");
            }
        }
    }

    static void SayHello()
    {
        Console.WriteLine("Hello!!!");
    }


    static void SayGreetingMessage(string msg)
    {
        Console.WriteLine(msg);
    }

    static void SayGreetingMessages(params string[] msgs)
    {
        foreach(string msg in msgs)
        {
            Console.WriteLine(msg);
        }
    }
}

