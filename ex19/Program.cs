using System;
using System.Linq;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ex19;
public class MyData
{
    public int code;
    public string name;
    public int[] nums = new int[5];
}

class Program
{
    static void Main(string[] args)
    {
        // FileIOTest();

        // LoggingTest();

        // TestWriteJson();

        TestReadJson();
    }

    static void TestReadJson()
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        string filePath = Path.Combine(currentDirectory, "my_data.json");

        string json = File.ReadAllText(filePath);
        var data = JsonConvert.DeserializeObject<MyData>(json);

        if ( data!=null )
        {
            Console.WriteLine(data.code);
            Console.WriteLine(data.name);
            Console.WriteLine(string.Join(" ", data.nums));
        }        
    }

    static void TestWriteJson()
    {
        MyData data = new MyData();
        data.code = 100;
        data.name = "Kim";
        for (int i = 0; i < 5; i++)
            data.nums[i] = i;

        string json = JsonConvert.SerializeObject(data, Formatting.Indented);
        Console.WriteLine(json);

        string currentDirectory = Directory.GetCurrentDirectory();        
        string filePath = Path.Combine(currentDirectory, "my_data.json");

        File.WriteAllText(filePath, json);
    }

    static void LoggingTest()
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        DateTime date = DateTime.Now;
        string fileName = date.ToString("yyyy_MM_dd") + ".txt";
        string filePath = Path.Combine(currentDirectory, fileName);

        Console.WriteLine(filePath);

        for(int i=0; i<100; i++)
        {
            string now = (DateTime.Now).ToString("HH:mm:ss:ff");
            string strLog = $"[{now}]Logging Data ... {i}";
            File.AppendAllText(filePath, strLog);
            File.AppendAllText(filePath, "\n");

            Thread.Sleep(10);            
        }
    }


    static void FileIOTest()
    {
        string str = string.Empty;
        Console.WriteLine(str);

        str = "foo";
        str.Append('1');
        Console.WriteLine(str);

        if (str.Contains('o'))
            Console.Write("o 가 있습니다");
        else
            Console.Write("o 가 없습니다");

        Console.WriteLine();

        string currentDirectory = Directory.GetCurrentDirectory();
        string filePath = Path.Combine(currentDirectory, "test_file.txt");
        // string content = "저장할 내용";

        // 파일에 텍스트 저장
        // File.WriteAllText(filePath, content);

        // string newContents = File.ReadAllText(filePath);
        // Console.WriteLine(newContents);

        foreach (string line in File.ReadLines(filePath))
        {
            Console.WriteLine(line);
        }

        Console.WriteLine();
        Console.WriteLine("저장할 내용을 계속해서 입력하세요");
        Console.WriteLine("더이상 저장할 내용이 없으면 빈줄을 입력하세요");

        string? strInput = string.Empty;
        do
        {
            strInput = Console.ReadLine();

            // 파일에 텍스트 저장
            File.AppendAllText(filePath, strInput);
            if (strInput != "")
                File.AppendAllText(filePath, "\n");


        } while (strInput.Length != 0);
    }
}

