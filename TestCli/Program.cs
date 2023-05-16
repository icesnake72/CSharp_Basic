// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

Console.WriteLine(dice.ToString());
Console.WriteLine(dice);

byte[] arr = new byte[10];
dice.NextBytes(arr);
foreach (byte a in arr)
{
  Console.WriteLine(a);
}

double rndDouble = dice.NextDouble();
Console.WriteLine(rndDouble);


int firstValue = 500;
int secondValue = 600;
int largerValue = System.Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);


roll1 = dice.Next(1, 7);
roll2 = dice.Next(1, 7);
roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
System.Console.WriteLine($"Dice roll : {roll1} + {roll2} + {roll3} = {total}");
if ( total > 14)
{
  System.Console.WriteLine("You Win!");
}

if ( total < 15 )
{
  System.Console.WriteLine("Sorry, you lose...");
}

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}



Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
System.Console.WriteLine($"남은 구독일 수 : {daysUntilExpiration}");

if (daysUntilExpiration < 1)
  System.Console.WriteLine("구독 기간이 지났습니다.");
else if (daysUntilExpiration == 1)
{
  System.Console.WriteLine("구독 기간이 하루 남았습니다.\n 새롭게 갱신하시고 20% 할인받으세요");
  discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
  System.Console.WriteLine($"구독 기간이 {daysUntilExpiration}일 남았습니다.");
  System.Console.WriteLine("새롭게 갱신하고 10% 할인받으세요");
}
else if (daysUntilExpiration < 11)
{
  System.Console.WriteLine("구독기간이 곧 만료됩니다. 지금 갱신하세요.");
}


