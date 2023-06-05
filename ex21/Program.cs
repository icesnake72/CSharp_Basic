using ex15;

namespace ex21;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("숫자 야구 게임!!!");

        int[] comsArr = new int[3];
        int[] userArr = new int[3];

        ex15.Program.SetRandomValueToArray(comsArr, 9, 1, false);

        Console.WriteLine(string.Join("", comsArr));

        bool loop = true;
        int tryComp = 0;
        while( loop )
        {
            tryComp++;
            Console.WriteLine("3자리 숫자를 입력하세요(게임 종료는 x키 입력) >>> ");
            string? strInput = Console.ReadLine();
            if ( strInput==null )
            {
                Console.WriteLine("게임을 종료합니다");
                return;
            }

            if (strInput.ToUpper() == "X")
            {
                Console.WriteLine("게임을 종료합니다");
                return;
            }

            if ( strInput.Length > 3)
            {
                Console.WriteLine("3자리 숫자로 다시 입력해주세요");
                continue;
            }

            // if ( Convert.ToInt32(strInput)==0 )

            for(int i=0; i<strInput.Length; i++)
            {                
                userArr[i] = int.Parse(strInput[i].ToString());
            }

            Console.WriteLine(string.Join("", userArr));

            int count = 0;
            int s = 0;
            int b = 0;
            for(int i=0; i<comsArr.Length; i++)
            {
                // int index1 = ex15.Program.FindInArray(comsArr, userArr[i]);
                int index = Array.IndexOf(comsArr, userArr[i]);
                if (index < 0)
                    continue;

                Console.WriteLine($"{userArr[i]}가 comsArr의 {index}번째에 있음");

                count++;
                if (index == i)
                    s++;
                else
                    b++;
            }

            Console.WriteLine($"{s}스트라이크 {b}볼입니다");

            if ( s==3 )
            {
                Console.WriteLine($"{tryComp}번째만에 정답을 맞혔습니다");
                loop = false;    
            }
        } 
    }
}

