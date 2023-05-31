namespace ex18;
class Program
{
    const int ROWS = 3;

    static void Main(string[] args)
    {
        Random rnd = new Random();

        // int num = rnd.Next(1, 11);   // 1~10 사이의 난수를 생성

        // 문제 1)
        // 1~9 사이의 랜덤한 숫자를 생성하여 10 x 10 배열의 모든 원소에 대입하고
        // 그 배열의 모든 원소를 행렬의 형태로 출력하시오 (정렬 없음)
        int[,] matrix = new int[10, 10];
        for(int i=0; i<matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rnd.Next(1, 10);
                Console.Write($"{matrix[i,j]} ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();


        // 문제 2)
        // 3열의 가변 배열에 각 열(row)의 행의 갯수를 2~10 사이의 갯수로 제한하여 생성하고,
        // 배열의 모든 원소에 1~10사이의 랜덤한 숫자를 대입하고,
        // 각 열의 모든 원소를 정렬하여 출력하시오 (열만 정렬)
        
        int[][] JaggedArray = new int[ROWS][];
        for(int i=0; i< ROWS; i++)
        {
            // 생성
            int cols = rnd.Next(2, 11);   // 1~10 사이의 난수를 생성 
            JaggedArray[i] = new int[cols]; // 행의 갯수를 2~10 사이의 갯수로 제한하여 생성
        }

        // 대입
        foreach (int[] row in JaggedArray)
        {
            for (int i = 0; i < row.Length; i++)
                row[i] = rnd.Next(1, 11);
        }

        // 정렬
        // 정렬 예제
        // int[] nums = new int[5];
        // Array.Sort(nums);    // 오름차순 정렬
        // Array.Reverse(nums); // 오름차순 정렬한것을 뒤집음 == 내림차순 정렬이 됨 
        foreach (int[] row in JaggedArray)
            Array.Sort(row);

        // 출력
        foreach (int[] row in JaggedArray)
        {
            Console.Write(string.Join(" ", row));
            Console.WriteLine();
        }
    }
}

