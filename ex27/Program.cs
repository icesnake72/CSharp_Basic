namespace ex27;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        LinkedList<int> list = new();

        for(int i=0; i<5; i++)
            list.AddLast(i);

        Console.WriteLine(string.Join(" ", GetNumberInList(list)));

        //Console.WriteLine(14*3*3);

        // async & await
        //await foreach(int number in list)
        {
            //await Console.WriteLine(string.Join(", ", ));
            // await GetAsyncNumberInList(list);
        }

        ShowList(list);

        Console.WriteLine("foreach()문 종료!!!!");
    }

    public static IEnumerable<int> GetNumberInList(LinkedList<int> list)
    {
        foreach(int num in list)
        {
            yield return num;
        }
    }

    public async static void ShowList(LinkedList<int> list)
    {
        await foreach (int number in GetAsyncNumberInList(list))
        {
            Console.WriteLine(number);
        }
    }

    public async static IAsyncEnumerable<int> GetAsyncNumberInList(LinkedList<int> list)
    {
        foreach (int num in list)
        {
            yield return num;
            Thread.Sleep(1000);
        }
    }



}

