namespace ex26;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        LinkedList<Champion> list = new();
        int count = list.Count();
        Console.WriteLine($"아군 캐릭터는 총 {count}개입니다");


        Ezreal ezreal = new("이즈리얼");
        ezreal.Start();

        Kaisa kaisa = new("카이사");
        kaisa.Start();

        Thresh thresh = new("쓰레쉬");
        thresh.Start();

        Ezreal enemy = new("상대편 이즈리얼");
        enemy.Start();

        list.AddLast(ezreal);
        list.AddLast(kaisa);
        list.AddLast(thresh);

        count = list.Count();
        Console.WriteLine($"아군 캐릭터는 총 {count}개입니다");

    }
}

