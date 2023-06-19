namespace ex24;

class Program
{
    static void Main(string[] args)
    {
        Thread thread = new Thread(WorkerMethod);
        thread.Start("메인으로부터 전달되는 메시");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("메인 스레드 실행 중: " + i);
            Thread.Sleep(1); // 1초 대기
        }
    }


    // 스레드 메소드 
    static void WorkerMethod(Object param)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("작업 스레드 실행 중: " + i);
            Thread.Sleep(1); // 1초 대기
        }
    }
}

