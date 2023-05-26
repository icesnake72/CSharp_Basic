namespace ex15;
class Program
{
    static void Main(string[] args)
    {
        int[] values = new int[10];

        SetRandomValueToArray(values, 100, 1, false);
        Console.Write(string.Join(" ", values));

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Sorted Values");

        // 데이터의 정렬 
        SortArray(values);
        Console.Write(string.Join(" ", values));

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("찾을 값을 입력하세요 >>> ");

        string? strInput = Console.ReadLine();
        if (strInput!=null)
        {
            int toFind = int.Parse(strInput);
            int index = FindInArray(values, toFind);
            if (index > -1)
                Console.WriteLine($"{index}번째 인덱스에서 값({values[index]})을 찾았습니다");
            else
                Console.WriteLine("값을 찾지 못했습니다");
        }
    }


    // int[] array : 난수(정수)값이 대입되는 배열
    // int until : 난수의 생성 범위 상한 값
    // int start : 난수의 생성 범위 시작 값
    // bool allowDuplication : 배열 array에 중복값의 대입을 허용 여부를 결정하는 상태 변수 

    // 이 함수는 주어진 파라미터 start 값부터 until 값 사이의 난수를 생성하여 array 배열의 모든 요소에 갑을 대입하는 함수이다
    // 이때 allowDuplication 값이 true 이면 배열 array에 중복값이 들어갈 수 있음을 가능하게 하는것이고, false이면 중복값 대입을 막는다 
    public static void SetRandomValueToArray(int[] array, int until, int start, bool allowDuplication)
    {
        // 중복값이 발생했을 경우 위와 같이 처리하면 값을 대입하지 못한 요소가 생긴다
        // 괜찮다!!! 프로그래밍은 이렇게 하는것이다.. 시도와 테스트를 반복하면서 최적의 방법을 찾아가도록 한다
        for (int i = 0; i < array.Length;)
        {
            // 바로 직접 대입하지 않고 임시로 값을 저장함
            int tmp = GetRandomValue(start, until);

            if (!allowDuplication)
            {
                // lottos 배열에 tmp 값이 있는지 체크해봄 
                if (Exist(array, tmp))
                    continue;
            }
                        
            array[i++] = tmp;  // 값을 대입한뒤 i값을 증가시킨다
        }

        // 배열을 매개변수로 다른 함수로 전달하면 참조값만을 가져가기 때문에 실제 값이 바뀐다
        // 이렇게 참조의 형태로 매개변수로 값을 전달하여 함수를 호출하는것을,
        // Call by Reference라고 한다
        // 실제 값이 바뀌기 때문에 값을 반환할 필요가 없다 
    }


    static int GetRandomValue(int start, int until)
    {
        Random rnd = new Random();

        return rnd.Next(start, until + 1);
    }


    static bool Exist(int[] numbers, int val)
    {
        // lottos 배열의 모든 요소들에 대하여 순차적으로 ...
        foreach (int num in numbers)
        {
            // 이번에 생성한 난수와 배열에 담긴 값들중 같은 값이 있는가 ?
            if (val == num)
            {
                // 디버깅을 위한 출력 
                Console.WriteLine($"중복값{val}을 발견함!!!");

                return true;    // 같은 값이 있다면 true를 반환하고 끝냄 
            }
        }

        return false;
    }


    // 빠른 검색을 위해서는 배열 요소들의 정렬이 필요하다
    // 가장 기본적인 정렬 방법은 순차 정렬이다
    static void SortArray(int[] array)
    {
        for(int i=0; i<array.Length-1; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    int tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;
                }
            }
        }
    }

    static int FindInArray(int[] array, int toFind)
    {
        return FindByBinarySearch(array, toFind, 0, array.Length-1);
    }


    static int FindByBinarySearch(int[] array, int toFind, int startIndex, int lastIndex)
    {
        if (startIndex > lastIndex)
            return -1;
        
        int half = (startIndex + lastIndex) / 2;
                
        if (array[half] == toFind)
            return half;
        else if (array[half] < toFind)
            return FindByBinarySearch(array, toFind, half+1, lastIndex);
        
        return FindByBinarySearch(array, toFind, startIndex, half-1);
    }
}

