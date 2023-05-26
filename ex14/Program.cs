namespace ex14;
class Program
{
    static void Main(string[] args)
    {
        // 배열을 new 로 초기화하기 
        int[] lottos = new int[5];   // 각 배열의 요소가 0으로 초기화됨

        /*
        // 각 배열 요소에 접근
        lottos[0] = 1;      
        lottos[1] = 2;
        lottos[2] = 3;
        lottos[3] = 4;
        lottos[4] = 5;

        
        // 배열을 초기값으로 초기화하기 , 아래 예는 총 5개의 요소로 초기화 됨 
        string[] cars = { "Hyundai", "Kia", "BMW", "Benz", "Audi" };

        // 각 배열 요소의 데이터를 출력 
        Console.WriteLine(cars[0]);
        Console.WriteLine(cars[1]);
        Console.WriteLine(cars[2]);
        Console.WriteLine(cars[3]);
        Console.WriteLine(cars[4]);


        // float형 변수 총 6개로 배열 weights를 만들고 초기화 함 
        float[] weights = { 50.5F, 62.9F, 73.0F, 48.5F, 78.2F, 99.0F };

        // 위에서 생성한 lottos 배열은 5개의 요소로 한정되어 있다
        // 반복문중 정해진 반복횟수 만큼 반복을 수행하기 좋은 반복문은 ?
        // for 문 과 foreach

        // int i = 0;


        Console.WriteLine(string.Join("\t", lottos));
        // foreach (int num in lottos )
        for (int i=0; i<5; i++)
        {

            // 이 반복문은 이 중괄호 부분의 코드 블럭을 총 5회 반복을 수행한다
            // 이때 num 은 총 5회 순차적으로 바뀐다
            // 1회전때 num == lottos[0]    lottos ===> 배열명 
            // 2회전때 num == lottos[1]    [x] ======> 인덱스 , 첨자
            // 3회전때 num == lottos[2]    lottos <-> [x] ===> 배열 요소의 값 == 하나의 변수와 같다 
            // ...
            // 5회전때 num == lottos[4]

            // num = 0;
            lottos[i] = i + 1;
        }

        Console.WriteLine(string.Join("\t", lottos));

        
        // 배열 lottos 의 각각의 요소에 1~45 사이의 랜덤한 수를 입력하기
        for(int i=0; i<5; i++)
        {
            // GetRandomValue 메소드를 호출한 결과값을 순차적으로 lottos 배열의 각 요소에 대입한다 
            lottos[i] = GetRandomValue(45);
        }

        //
        Console.WriteLine(string.Join("\t", lottos));


        // lottos 배열의 모든 요소를 0으로 초기화 
        Array.Fill(lottos, 0);

        // 위와 같은 방법으로 처리했더니 중복값이 발생해서 방법을 바꿈
        for (int i = 0; i < 5; i++)
        {
            // 바로 직접 대입하지 않고 임시로 값을 저장함 
            int tmp = GetRandomValue(45);

            // 중복값이 있는지 체크하기 위한 변수 
            bool exist = false;

            // lottos 배열의 모든 요소들에 대하여 순차적으로 ...
            foreach(int num in lottos)
            {
                // 이번에 생성한 난수와 배열에 담긴 값들중 같은 값이 있는가 ?
                if (tmp == num)
                {
                    Console.WriteLine($"중복값{tmp}을 발견함!!!");
                    // 같은 값이 있다면 외부 for() 반복문으로 복귀한다
                    exist = true;   // 중복값이 있음을 체크한다 
                    break;  // foreach() 반복문을 탈출한다 
                }
            }
                        
            if (exist)
                continue;

            lottos[i] = tmp;
        }

        Console.WriteLine(string.Join("\t", lottos));
        */
        /*
        Console.WriteLine();    // 한줄 건너뛰기 


        // lottos 배열의 모든 요소를 0으로 초기화 
        Array.Fill(lottos, 0);


        // 중복값이 발생했을 경우 위와 같이 처리하면 값을 대입하지 못한 요소가 생긴다
        // 괜찮다!!! 프로그래밍은 이렇게 하는것이다.. 시도와 테스트를 반복하면서 최적의 방법을 찾아가도록 한다
        for (int i=0; i<5;)
        {
            // 바로 직접 대입하지 않고 임시로 값을 저장함
            int tmp = GetRandomValue(45);

            // lottos 배열에 tmp 값이 있는지 체크해봄 
            if ( Exist(lottos, tmp) )
                continue;

            lottos[i++] = tmp;  // 값을 대입한뒤 i값을 증가시킨다
        }

        // lottos 의 모든 내용을 출력함 
        Console.WriteLine(string.Join("\t", lottos));
        */

        SetRandomValueToArray(lottos, 45, 1, false);
        Console.WriteLine(string.Join("\t", lottos));


        int[] score = new int[10];
        SetRandomValueToArray(score, 100, 20, true);
        Console.WriteLine(string.Join("\t", score));
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
}

