using System;
using static ex15.Program;

namespace ex16;

class Program
{
    static int myNum;

    const int ROWS = 3;
    const int COLS = 6;
    const int MAX_VALUE = 45;

    static void Main(string[] args)
    {
        // RangeOfVar();

        // TwoDimensionArray();

        // JaggedArray();

        LottoSimulator();
    }

    static void RangeOfVar()
    {
        int num = 100;
        if ( num == 100)
        {
            int num2 = 10;
            num = num2;
            Console.WriteLine(num2);
        }

        // Console.WriteLine(num2);     // num2는 이 영역에 더이상 존재하지 않는다 

        Console.WriteLine(num);
    }

    static void TwoDimensionArray()
    {
        int[,] TwoDimArray = { {1,2,3}, {4,5,6} };
        for(int i=0; i<2; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write($"{TwoDimArray[i,j]}\t");

            Console.WriteLine();
        }

        int[,] matrix = new int[ROWS, COLS];    // 뒤에서부터 행 , 열 의 형태로 초기화함 
        // SetRandomValueToArray(matrix, 45, 1, false);


        for (int i = 0; i < ROWS; i++)
        {
            for (int j = 0; j < COLS;)
            {
                bool exist = false;
                int tmp = GetRandomValue(1, MAX_VALUE);
                for (int k = 0; k < COLS; k++)
                {
                    if (matrix[i, k] == tmp)
                    {
                        exist = true;
                        break;
                    }
                }

                if (!exist)
                    matrix[i, j++] = tmp;
            }
        }

        //
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }

        foreach (int num in matrix)
            Console.Write($"{num}, ");


        Console.WriteLine();

        int[,,] multiDims = new int[3, 4, 5] {
            { {1,2,3,4,5 }, {1,2,3,4,5 }, {1,2,3,4,5 }, {1,2,3,4,5 } },
            { {1,2,3,4,5 }, {1,2,3,4,5 }, {1,2,3,4,5 }, {1,2,3,4,5 } },
            { {1,2,3,4,5 }, {1,2,3,4,5 }, {1,2,3,4,5 }, { 1,2,3,4,5} }
        };

        for(int i=0; i<multiDims.GetLength(0); i++)
        {
            for (int j = 0; j < multiDims.GetLength(1); j++)
            {
                for (int k = 0; k < multiDims.GetLength(2); k++)
                {
                    Console.Write($"{multiDims[i,j,k]}, ");
                }

                Console.Write("\t");
            }

            Console.WriteLine();
        }


    }

    static void JaggedArray()
    {
        // Multi Line Lotto
        // Jagged Array : 2차원배열 기반으로 열의 길이가 가변인 배열

        // 가변 배열의 선언
        int[][] JaggedArray = new int[3][];
        JaggedArray[0] = new int[] { 1,2,3};
        JaggedArray[1] = new int[] { 4,5,6,7,8,9,10};
        JaggedArray[2] = new int[] { 11,12};

        // 가변 배열은 아래와 같이 하나의 foreach문으로 모든 배열의 순회가 불가능함 
        // foreach(int num in JaggedArray)
        //    Console.Write($"{num}, ");

        Console.WriteLine();

        // 가장 기본적인 가변 배열의 순회 
        for (int i=0; i<3; i++)
        {
            for(int j=0; j < JaggedArray[i].Length; j++)
                Console.Write($"{JaggedArray[i][j]}, ");

            Console.WriteLine();
        }

        Console.WriteLine();

        // 배열의 길이를 알 수 있는 또 다른 방법
        /*
        for (int i = 0; i < JaggedArray.GetLength(0); i++)
        {
            for (int j = 0; j < JaggedArray.GetLength(1); j++)   // 다차원 배열과는 다름 , 이렇게 사용할수 없
                Console.Write($"{JaggedArray[i][j]}, ");

            Console.WriteLine();
        }
        */

        for (int i = 0; i < JaggedArray.GetLength(0); i++)
        {
            for (int j = 0; j < JaggedArray[i].GetLength(0); j++)   // 다차원 배열과는 다름 , 이렇게 사용할수 없
                Console.Write($"{JaggedArray[i][j]}, ");

            Console.WriteLine();
        }

        Console.WriteLine();

        // 전체 배열을 순회할 수 있는 방법
        foreach (int[] row in JaggedArray)
        {
            foreach(int num in row)     // 가변 길이 배열은 하나의 열(row)을 1차원 배열로 받을 수 있다 (핵심!!!)
            {
                Console.Write($"{num}, ");
            }

            Console.WriteLine();
        }       
    }


    static void LottoSimulator()
    {
        int[] lottos = new int[COLS];
        SetRandomValueToArray(lottos, MAX_VALUE, 1, false);
        SortArray(lottos);

        Console.Write(string.Join(' ', lottos));
        Console.WriteLine("\n\n");


        int[][] myMultiLineLottos = new int[ROWS][];
        for(int i=0; i<ROWS; i++)
            myMultiLineLottos[i] = new int[COLS];

        
        foreach (int[] row in myMultiLineLottos)
        {
            SetRandomValueToArray(row, MAX_VALUE, 1, false);
            SortArray(row);

            Console.Write(string.Join(' ', row));

            int count = 0;
            int[] hitNumbers = new int[COLS];
            foreach (int num in row)
            {
                int index = FindInArray(lottos, num);

                if (index >= 0)
                    hitNumbers[count++] = lottos[index];
            }

            Console.WriteLine();
            Console.Write(string.Join(" ", hitNumbers));
            Console.WriteLine();
            Console.WriteLine($"{count}개 맞음");

            Console.WriteLine();
        }
    }

}

