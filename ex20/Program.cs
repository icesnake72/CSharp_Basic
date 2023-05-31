namespace ex20;
class Program
{
    static void Main(string[] args)
    {
        //Unit unit = new Unit();
        //unit.name = "test";
        //unit.mp = 200;

        //POINT pt;
        //pt.x = 10;
        //pt.y = 10;
        //unit.Position = pt;


        Marine mr1 = new Marine();
        Marine mr2 = new Marine();
        Marine mr3 = new Marine();

        Firebat fb1 = new Firebat();
        Firebat fb2 = new Firebat();

        Unit[] units = new Unit[5];
        units[0] = mr1;
        units[1] = mr2;
        units[2] = mr3;
        units[3] = fb1;
        units[4] = fb2;

        foreach (Unit unit in units)
            unit.Attack(mr1);


        foreach (Unit unit in units)
            unit.Skill(new POINT(10,10));

    }
}

