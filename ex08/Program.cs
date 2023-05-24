namespace ex08;
class Program
{
    static void Main(string[] args)
    {
        // 응용 문제

        // 자동 로또 번호 생성기
        // 1 ~ 45 사이의 난수를 발생하여 5칸짜리 배열에 저장한다

        // 규칙 1.
        // 5개의 숫자가 중복되면 안된다
        // 1-1. 중복된 값을 막기위해서는 이번에 생성된 난수값이 이미 배열에 존재하는지 검사하고 저장 여부를 결정한다
        // 1-2. 이미 배열에 저장된 값이 존재하면 새로운 난수를 생성하여 1-1을 반복한다

        // 규칙 2.
        // 배열에 값 정렬은 하지 않, 생성된 순서대로 인덱스 0부터 4까지 생성된 순서대로 저장한다

        // 규칙 3.
        // 생성된 로또 번호 5개를 모두 출력한다

        // 규칙 4.
        // 정수값을 반환하는 GetRandomValueInRange 라는 이름의 메소드를 만들고 매개 변수 45를 전달하면 1~45까지의 난수를 반환하도록 한다 

        // 출력 예 )
        // 13   45  42  2   28

        int[] lottos = new int[5];  // 정수형 배열의 경우 선언과 함께 0으로 초기화된다 

        int index = 0;  // lottos 배열 인덱싱을 위한 변
        do
        {
            bool exist = false; // 중복값을 체크하기 위한 플래그 변수, 초기값은 없다고(false) 가정!
            int tmp = GetRandomValueInRange(45);    // 변수 tmp에 난수를 생성하여 값을 대입한다
            foreach (int num in lottos) // lottos내의 모든 값들을 순차적으로 순회하며...
                if (tmp == num)     // 이번에 생성한 난수값이 이미 배열에 존재하는 값이면 ?
                {
                    exist = true;   // exist 플래그 변수를 true로 바꾼뒤 foreach반복문을 탈출한다
                    break;          // foreach 반복문 탈출
                }

            if (exist) continue;    // 이미 값이 존재할때는 lottos배열에 값을 추가하지 않고 인덱스 값도 증가시키지 않고 루프의 처음으로 돌아간다

            lottos[index++] = tmp;  // 이번 반복회차에서 생성된 난수는 lottos 배열내에 중복된 값이 없으므로 값을 저장하, 인덱스 값을 증가 시킨다

        } while (index < 5);    // index 값이 0 ~ 4인동안 반복수행한다

        foreach (int num in lottos) // lottos 배열에 있는 모든 값들을 순회하며...
            Console.Write($"{num}\t");  // 한개씩 그 값들을 탭문자와 함께 한줄에 출력한다 

    }

    static int GetRandomValueInRange(int until)
    {
        // 랜덤 클래스로 rnd 객체 생성
        Random rnd = new Random();      

        // rnd 객체의 Next()메소드로 난수를 생성하여 값을 반환한다,
        // 이때 난수의 생성 범위는 1~until 까지 이므로 until+1을 주어야 한다
        return rnd.Next(1, until+1);    
    }
}

