namespace ex05;
class Program
{
    static void Main(string[] args)
    {
        // 복습 연습 문제

        // 가장 기본적인 .NET 클래스 라이브러리 ...
        // Console.WriteLine("안녕하세요"); // Console 클래스의 기본 출력 메소드 
        // Console.ReadLine(); // Console 클래스의 기본 입력 메소드

        // .NET클래스 라이브러리의 Random 클래스를 이용하여 dice란 이름의 객체를 생성한다
        // Random dice = new Random();
        // int roll = dice.Next(1, 7); // 1부터 7미만의 숫자들중에 랜덤하게 한개의 숫자를 생성하여 반환한다 

        //
        // 블랙잭 게임 
        // 규칙 1. 컴퓨터는 무조건 카드 두장을 받는다.
        //        이는 Random 클래스를 이용한 객체를 생성하여 1~13의 난수를 입력받아 그 합을 저장한다.
        //        카드는 나중에 확인이 가능하도록 2칸짜리 배열에 저장한다 

        // 규칙 2. 사용자도 규칙 1과 같은 방법으로 최초 2장의 카드를 제공받는다
        //        이때 사용자의 카드를 화면에 보여줍니다
        //        사용자 카드의 숫자의 합이 21을 초과했으면 사용자의 패배이고 게임을 종료합니다

        // 규칙 3. 사용자는 컴퓨터의 카드를 볼 수 없다

        // 규칙 4. 사용자는 h(it) 또는 s(tay)를 입력받아 한 장의 카드를 제공 받거나 승부를 시도할 수 있다 

        // 규칙 5. 사용자가 s를 입력했을때 컴퓨터의 카드와는 상관없이 21이 넘었으면 사용자의 패배이고 메시지를 출력하고 게임을 종료합니다 

        // 규칙 6. 사용자가 s를 입력할때까지 카드를 최대 10개까지(배열 10) 제공받는다 (do ~ while() 루프를 이용하시요)

        // 규칙 7. 사용자가 s를 입력했을때 사용자의 카드의 합이 21보다 작거나 같으면 컴퓨터가 갖고 있는 카드와 비교하여 승부를 겨룬다

        // 규칙 8. 사용자 또는 컴퓨터가 갖고 있는 카드의 합이 21에 가까운 사람이 승자이다,
        //        컴퓨터 카드 숫자들의 합이 21이 넘어도 사용자의 승리입니다 

        // 규칙 9. 컴퓨터와 사용자의 카드를 모두 오픈하고 승 또는 패를 출력하고 게임을 종료한다

        // 규칙 10. 숫자 리터럴 14, 21등은 상수를 이용하여 숫자 리터럴의 사용을 최소화하시요

        /*

        출력 예1)

        당신의 카드의 합은 23입니다
        당신의 카드 숫자의 합은 23입니다. 21을 초과하여 당신이 졌습니다

        =====================================================

        출력 예2)

        당신의 카드는 13, 7입니다
        당신의 카드의 합은 20입니다
        카드를 받으시겠습니까 ?
        s

        컴퓨터의 카드는 10, 6이고 합은 16 입니다
        당신의 승리입니다

        =====================================================

        당신의 카드는 2, 1입니다
        당신의 카드의 합은 3입니다
        카드를 받으시겠습니까 ?
        s

        컴퓨터의 카드는 4, 13이고 합은 17입니다
        컴퓨터의 승리입니다

        =====================================================

        당 신의  카드의  합은  19입니다
        카 드를  받으시겠습니까 ?
        s

        컴 퓨터의  카드는  10, 12이고  합은  22 입니다
        당 신의  승리입니다

        =====================================================

        출력 예3)

        당신의  카드는  2, 12입니다
        당 신의  카드의  합은  14입니다
        카 드를  받으시겠습니까 ?
        h
        당 신의  카드는...
        1 번째  카드  : 2
        2 번째  카드  : 12
        3 번째  카드  : 11
        당 신의  카드의  합은  25입니다

        당 신의  카드  숫자의  합은  25입니다 . 21을  초과하여  당신이  졌습니다

        =====================================================

        당신의  카드는  4, 8입니다
        당 신의  카드의  합은  12입니다
        카 드를  받으시겠습니까 ?
        h
        당 신의  카드는  ...
        1 번째  카드  : 4
        2 번째  카드  : 8
        3 번째  카드  : 8
        당 신의  카드의  합은  20입니다

        카 드를  받으시겠습니까 ?
        s

        컴 퓨터의  카드는  10, 9이고  합은  22 입니다
        당 신의  승리입니다


        */





        const int BLACK_JACK = 21;
        const int MAX_VAL = 13 + 1;

        Random dealer = new Random();

        int dealer_total = 0;
        int[] dealer_has = new int[2];
        
        dealer_has[0] += dealer.Next(1, MAX_VAL);
        dealer_has[1] += dealer.Next(1, MAX_VAL);
        dealer_total = dealer_has[0] + dealer_has[1];

        int user_total = 0;
        int[] user_has = new int[10];

        user_has[0] = dealer.Next(1, MAX_VAL);
        user_has[1] = dealer.Next(1, MAX_VAL);
        user_total = user_has[0] + user_has[1];

        Console.WriteLine($"당신의 카드는 {user_has[0]}, {user_has[1]}입니다");
        Console.WriteLine($"당신의 카드의 합은 {user_total}입니다");

        int slot = 2;
        bool looping = true;
        string? strInput = "";
        do
        {
            if (user_total > BLACK_JACK)
            {
                Console.WriteLine("21을 초과하여 당신이 졌습니다");
                return;
            }

            Console.WriteLine("카드를 받으시겠습니까?");
            strInput = Console.ReadLine();
            if (strInput == null || strInput.ToUpper() == "S")
                looping = false;
            else
            {
                user_has[slot] = dealer.Next(1, MAX_VAL);
                user_total += user_has[slot++];

                Console.WriteLine("당신의 카드는 ...");
                for (int i=0; i<slot; i++)
                    Console.WriteLine($"{i + 1}번째 카드 : {user_has[i]}");

                Console.WriteLine($"당신의 카드의 합은 {user_total}입니다");
            }

            Console.WriteLine();

        } while (looping);

        Console.WriteLine($"컴퓨터의 카드는 {dealer_has[0]}, {dealer_has[1]}이고 합은 {dealer_total} 입니다");


        Console.WriteLine((dealer_total <= BLACK_JACK && dealer_total > user_total) ? "컴퓨터의 승리입니다" : "당신의 승리입니다");
        //if ( dealer_total <= BLACK_JACK && dealer_total > user_total )
        //{
        //    Console.WriteLine("컴퓨터의 승리입니다");
        //}
        //else
        //{
        //    Console.WriteLine("당신의 승리입니다");
        //}
    }
}

