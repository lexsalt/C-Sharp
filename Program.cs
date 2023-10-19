
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
// Random coin = new Random();
// int coinFlip = coin.Next(2);
// Console.WriteLine($"Coin Flip: {(coinFlip > 0 ? "heads": "tails")}");

// eight test

// string permission = "Admin|Manager";
// int level = 55;

// Console.WriteLine();
// if (permission.Contains("Admin")) {
//     if (level <= 55) {
//         Console.WriteLine("Welcome, Admin user.");

//     } else {
//         Console.WriteLine("Welcome, Super Admin user.");
//     }
// } else if (permission.Contains("Manager")) {
//         if (level <= 20) {
//         Console.WriteLine("You do not have sufficient privileges.");

//     } else {
//         Console.WriteLine("Contact an Admin for access.");
//     }
// } else {
//     Console.WriteLine("You do not have sufficient privileges.");
// }

// 9th test:
// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// 10th test
// Console.WriteLine("Generating random numbers:");
// DisplayRandomNumbers();

// void DisplayRandomNumbers() 
// {
//     Random random = new Random();

//     for (int i = 0; i < 5; i++) 
//     {
//         Console.Write($"{random.Next(1, 100)} ");
//     }

//     Console.WriteLine();
// }

// 11th test
// int[] times = {800, 1200, 1600, 2000};
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");
// DisplayTimes();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     AdjustTimes();
// } 
// else 
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     AdjustTimes();
// }

// Console.WriteLine("New Medicine Schedule:");
// DisplayTimes();

// void DisplayTimes()
// {
//     /* Format and display medicine times */
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time} ");
//     }
//     Console.WriteLine();
// }

// void AdjustTimes() 
// {
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++) 
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }

//12th test
// string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
// string[] address;
// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;

// foreach (string ip in ipv4Input) 
// {
//     address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

//     ValidateLength(); 
//     ValidateZeroes(); 
//     ValidateRange();

//     if (validLength && validZeroes && validRange) 
//     {
//         Console.WriteLine($"{ip} is a valid IPv4 address");
//     } 
//     else 
//     {
//         Console.WriteLine($"{ip} is an invalid IPv4 address");
//     }
// }

// void ValidateLength() 
// {
//     validLength = address.Length == 4;
// };

// void ValidateZeroes() 
// {
//     foreach (string number in address) 
//     {
//         if (number.Length > 1 && number.StartsWith("0")) 
//         {
//             validZeroes = false;
//             return;
//         }
//     }

//     validZeroes = true;
// }

// void ValidateRange() 
// {
//     foreach (string number in address) 
//     {
//         if (int.Parse(number) > 255) 
//         {
//             validRange = false;
//             return;
//         }
//     }
//     validRange = true;
// }

// 13th test

// Random random = new Random();
// int luck = random.Next(100);

// string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
// string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
// string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
// string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

// void tellFortune() {
// Console.WriteLine("A fortune teller whispers the following words:");
// string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
// for (int i = 0; i < 4; i++) 
// {
//     Console.Write($"{text[i]} {fortune[i]} ");
// }
// Console.WriteLine();
// };
// tellFortune();

//14th
// initialize variables - graded assignments 
// int currentAssignments = 5;

// int sophia1 = 93;
// int sophia2 = 87;
// int sophia3 = 98;
// int sophia4 = 95;
// int sophia5 = 100;

// int nicolas1 = 80;
// int nicolas2 = 83;
// int nicolas3 = 82;
// int nicolas4 = 88;
// int nicolas5 = 85;

// int zahirah1 = 84;
// int zahirah2 = 96;
// int zahirah3 = 73;
// int zahirah4 = 85;
// int zahirah5 = 79;

// int jeong1 = 90;
// int jeong2 = 92;
// int jeong3 = 98;
// int jeong4 = 100;
// int jeong5 = 97;

// Console.WriteLine("Student\t\tGrade");
// int sophiaGrade = (sophia1+sophia2+sophia3+sophia4+sophia5) /currentAssignments;
// int nicolasGrade = (nicolas1+nicolas2+nicolas3+nicolas4+nicolas5) /currentAssignments;
// int zahirahGrade = (zahirah1+zahirah2+zahirah3+zahirah4+zahirah5) /currentAssignments;
// int jeongGrade = (jeong1+jeong2+jeong3+jeong4+jeong5) /currentAssignments;
// Console.WriteLine($"Sophia:\t\t{sophiaGrade}\t {(sophiaGrade > 90 ? "A":"B")}");
// Console.WriteLine($"Nicolas:\t{nicolasGrade}\t {(nicolasGrade > 90 ? "A":"B")}");
// Console.WriteLine($"Zahirah:\t{zahirahGrade}\t {(zahirahGrade > 90 ? "A":"B")}");
// Console.WriteLine($"Jeong:\t\t{jeongGrade}\t {(jeongGrade > 90 ? "A":"B")}");

// 15th test
string firstName = "Bob";
int widgetsPurchased = 7;
// Testing a change to the message.
// int widgetsSold = 7;
// Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");