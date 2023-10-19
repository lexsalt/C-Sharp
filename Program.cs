
/*
FIRST TUTORIAL
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello C#!");
Random dice = new Random();
int roll = dice.Next(1, 99);
Console.WriteLine($"Roll: {roll}");
// Console.WriteLine();
int number = 7;
string text = "seven";

Console.WriteLine(number);
// Console.WriteLine();
Console.WriteLine(text);

//Random dice = new Random();
// The first version of the Next() method doesn't set an upper and lower boundary, 
//so the method will return values ranging from 0 to 2,147,483,647, which is the maximum value an int can store.
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
*/
// Second Test
/*
int firstValue = 500;
int secondValue = 600;
int largerValue = System.Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);
*/
// Third test: DICE GAME

Random dice = new Random();

int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);
int roll1 = dice.Next(1,7);

int total = roll1+roll2+roll3;

Console.WriteLine($"Dice Roll: {roll1} + {roll2} + {roll3} = Total: {total}");

if ((roll1 == roll2 && roll1 != roll3) || (roll2 == roll3 && roll1 != roll3) || (roll1 == roll3 && roll1 != roll2)) {
    Console.WriteLine("You rolled a double. Adding +2 to your total");
    total += 2;
    Console.WriteLine($"New total: {total}");
}
if ((roll1 == roll2) && (roll2 == roll3)) {
    Console.WriteLine("You Rolled triple! adding +6 to total");
    total +=6;
    Console.WriteLine($"New total: {total}");
}

if (total >= 15) {
    Console.WriteLine("You win");
} else if (total < 15) {
    Console.WriteLine("You loose");
}

// Fourth 