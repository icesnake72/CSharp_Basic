namespace ex04;


class Unit
{
    public const int INIT_HP = 100;
    public const int INIT_MP = 50;

    public int hp;
    public int mp;
    public Unit()
    {
        hp = INIT_HP;
        mp = INIT_MP;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Unit unit1 = new Unit();
        Unit unit2 = new Unit();

        unit1.hp += 20;
        unit1.mp += 20;

        if (unit1.hp != unit2.hp)
            Console.WriteLine($"unit1.hp={unit1.hp}, unit2.hp={unit2.hp}");

        // int type의 Max값과 Min값 
        Console.WriteLine(int.MaxValue);
        Console.WriteLine(int.MinValue);

        //
        decimal min = decimal.MinValue;
        decimal max = decimal.MaxValue;
        Console.WriteLine($"The range of the decimal type is {min} to {max}");

        //
        double a = 1.0;
        double b = 3.0;
        Console.WriteLine(a / b);

        decimal c = 1.0M;
        decimal d = 3.0M;
        Console.WriteLine(c / d);

        Console.WriteLine(sizeof(double));
        Console.WriteLine(sizeof(decimal));

        List<string> names = new List<string>();
        names.Add("kim");
        names.Add("Yang");
        names.Add("Lee");
        Console.WriteLine(names);
        Console.WriteLine(unit1);

        Console.WriteLine();

        foreach (string name in names)
        {
            Console.WriteLine(name.ToUpper());
        }

        int index = names.IndexOf("Yang");
        if (index != -1)
            Console.WriteLine($"이름 : {names[index]}의 index 값은 {index} 입니다");


        short shortNum;
        ushort unsignedShortNum;
        object obj = 10;
        Console.WriteLine(obj);

        // L, F, D, M, U(uint), UL(ulong)

        int? i = null;
        int newVal = i ?? -1;
    }
}

