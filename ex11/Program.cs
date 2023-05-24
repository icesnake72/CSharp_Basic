namespace ex11;
class Program
{
    static void Main(string[] args)
    {
        // 변수가 매개 변수로 전달될때의 특성
        int num1 = 10;
        int num2 = Accumulate(num1);
        Console.WriteLine($"num1={num1}, num2={num2}");


        // 배열이 매개 변수로 전달될때의 특성
        Random rnd = new Random();

        int[] arrNumbers = new int[5];
        for (int i = 0; i < 5; i++)
        {
            arrNumbers[i] = rnd.Next(1, 101);
        }

        Console.WriteLine("정렬 전 배열");
        foreach (int num in arrNumbers)
            Console.Write($"{num}\t");

        Console.WriteLine();
        Console.WriteLine();

        // Sort 메소드에서 정렬한 뒤 출력을 Sort메소드 내부에서 출력한다!!!
        Sort(arrNumbers);   // 배열은 매개변수로 전달될때 참조의 형식으로 전달되기 때문에 호출받은 메소드에서 내용을 변경하면 호출한 쪽에서도 내용이 변경된다


        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("정렬 전 배열 ???");
        foreach (int num in arrNumbers)
            Console.Write($"{num}\t");
    }


    static int Accumulate(int n)
    {
        n += 10;
        return n;
    }


    // 낮은 값에서 높은값으로 순차적으로 정렬하는 오름 차순 정렬 메소드 
    static void Sort(int[] arrNums)
    {
        if (arrNums.Length <= 0)
            return;     // void 메소드에서도 return을 사용할 수 있다, 이때 return은 값을 반환하는게 아니라 메소드를 중간에 끝낸다 는 의미이다

        for(int i=0; i< arrNums.Length-1; i++)
        {
            for (int j = i + 1; j < arrNums.Length; j++)
            {
                if (arrNums[i] > arrNums[j])
                {
                    int tmp = arrNums[i];
                    arrNums[i] = arrNums[j];
                    arrNums[j] = tmp;
                }
            }
        }

        Console.WriteLine("정렬 후 배열");
        foreach (int num in arrNums)
            Console.Write($"{num}\t");
    }
}

