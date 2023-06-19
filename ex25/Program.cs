namespace ex25;

// 비동기 프로세

class Program
{
    static bool steamPack = false;
    static int damage = 10;

    static void Main(string[] args)
    {
        steamPack = true;
        Console.WriteLine("스팀팩!!!!");
        TaskTest();
        for(int i=0; i<50; i++)
        {
            if ( steamPack )
                Console.WriteLine("스팀팩 공격..." + damage);
            else
                Console.WriteLine("일반 공격..." + damage);

            Thread.Sleep(200);
        }


        Console.WriteLine("공격 종료");
    }

    private static async void TaskTest()
    {
        Console.WriteLine("스팀팩이 시작되었습니다");
        damage = 15;
        await Task.Delay(5000);
        Console.WriteLine("스팀팩이 종료되었습니다");
        damage = 10;
        steamPack = false;
    }

    static async Task<int> PerformAsyncTask(int taskId)
    {
        Console.WriteLine($"비동기 작업 {taskId} 시작");

        // 비동기 작업 시뮬레이션
        await Task.Delay(taskId * 1000);

        Console.WriteLine($"비동기 작업 {taskId} 완료");

        return taskId;
    }
}

