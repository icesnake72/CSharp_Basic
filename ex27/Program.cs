using System.Net;

namespace ex27;

public delegate void DelegateProc(long param1, long? param2);

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //LinkedList<int> list = new();

        //for(int i=0; i<5; i++)
        //    list.AddLast(i+1);

        //Console.WriteLine(string.Join(" ", GetNumberInList(list)));

        ////Console.WriteLine(14*3*3);

        //// async & await
        ////await foreach(int number in list)
        //{
        //    //await Console.WriteLine(string.Join(", ", ));
        //    // await GetAsyncNumberInList(list);
        //}

        //List<int> newList = list.Where(x => x % 2 == 0).ToList();
        //Console.WriteLine(string.Join(" ", newList));
        //ShowList(list);


        //Task t1 = AsyncMethod1();
        //Console.WriteLine("AsyncMethod1()호출완료!");
        //Task t2 = AsyncMethod2();
        //Console.WriteLine("AsyncMethod2()호출완료!");

        //await Task.WhenAll(t1, t2);


        FileCopy copy = new();
        Task tk = copy.StartCopy("/Users/eunbumkim/Documents/유튜브 배너.psd", "copy.psd", ShowDownloadProgress);
        await Task.WhenAll(tk);

        // Console.ReadLine();

        Console.WriteLine("프로그램 종료 ");
    }

    public static void ShowDownloadProgress(long param1, long? param2)
    {
        if (param2 == null)
            return;

        if ( param2!=0 )
        {
            float progress = (param1 / (float)param2) * 100f;
            Console.WriteLine($"{Math.Round(progress,2)}% progressing...");
        }
    }

    public static async IAsyncEnumerable<int> GetRandomValue(int count)
    {
        Random rnd = new();
        for(int i=0; i<count; i++)
        {
            yield return rnd.Next(101);
        }
    }

    public static async Task AsyncMethod1()
    {
        await Task.Delay(1);

        //using (var client = new WebClient())
        //{
        //    await client.DownloadFileTaskAsync(FormUrlEncodedContent, filename);
        //}

        await foreach(int num in GetRandomValue(5))
        {
            Thread.Sleep(100);
            Console.WriteLine($"1 : {num}");
        }

        //await Task.Run(() =>
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Thread.Sleep(100);
        //        Console.WriteLine($"1 : {i}");
        //    }
        //});
    }

    public static async Task AsyncMethod2()
    {
        await Task.Delay(1);
        await foreach (int num in GetRandomValue(5))
        {
            Thread.Sleep(100);
            Console.WriteLine($"2 : {num}");
        }

        //await Task.Run( () =>
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Thread.Sleep(100);
        //        Console.WriteLine($"2 : {i}");
        //    }
        //});
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

