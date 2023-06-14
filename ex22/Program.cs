using ex14;

namespace ex22;
class MyClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Unit myUnit = new Unit();        
        
        Weapon someWeapon = new Weapon();
        myUnit.SetWeapon(someWeapon);

        Unit enemy = new Unit();

        myUnit.Attack(enemy);
        myUnit.SteamPack(true);

        // 시간이 흐르는것을 체크했다, steampack을 다시 꺼줌
        myUnit.SteamPack(false);




        UnitGroup ug = new UnitGroup();
        ug.Add(myUnit);
        foreach(Unit unit in ug)
        {
            unit.ShowHp();
        }        
    }
}

