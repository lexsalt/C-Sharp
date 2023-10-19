
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

// Random dice = new Random();

// int roll2 = dice.Next(1,7);
// int roll3 = dice.Next(1,7);
// int roll1 = dice.Next(1,7);

// int total = roll1+roll2+roll3;

// Console.WriteLine($"Dice Roll: {roll1} + {roll2} + {roll3} = Total: {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
//     if ((roll1 == roll2) && (roll2 == roll3)) {
//     Console.WriteLine("You Rolled triple! adding +6 to total");
//     total +=6;
//     Console.WriteLine($"New total: {total}");
//     } else {
//         Console.WriteLine("You rolled a double. Adding +2 to your total");
//         total += 2;
//         Console.WriteLine($"New total: {total}");
//     }
// }


// if (total >= 15) {
//     Console.WriteLine("You win");
// } else {
//     Console.WriteLine("You loose");
// }

// Fourth 
// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// // Your code goes here
// Console.WriteLine($"{daysUntilExpiration}");
// if (daysUntilExpiration <= 10) {
//     if (daysUntilExpiration <=5) {
//         if (daysUntilExpiration > 1) {
//             Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//             discountPercentage = 10;
//             Console.WriteLine($"Renew now and save {discountPercentage}%");
//         } else if (daysUntilExpiration == 1) {
//             Console.WriteLine($"Your subscription expires within a day!");
//             discountPercentage = 20;
//             Console.WriteLine($"Renew now and save {discountPercentage}%");
//         } else {
//                 Console.WriteLine("Your suscription has expired.");
//             }
//     } else {
//         //10 days or less and more than 5
//         Console.WriteLine("Your subscription will expire soon. Renew now!");

//     }
// } else {
//     Console.WriteLine("Your subscription is fine.");
// }

// fifth
/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

// string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// sixth test: foreach

// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum = 0;
// int bin = 0;
// foreach (int items in inventory)
// {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in inventory.");

// string[] inventory = { "B123",
// "C234",
// "A345",
// "C15",
// "B177",
// "G3003",
// "C235",
// "B179" };

// foreach (string name in inventory)
// {
//    if (name.StartsWith("B"))
// {
//     Console.WriteLine($"{name}");
// }
// }

// seventh test: recap to part 1 to continue with the course (was doing part 2 without knowing)
Random coin = new Random();
int coinFlip = coin.Next(2);
Console.WriteLine($"Discount: {coinFlip}");