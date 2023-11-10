
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
// string firstName = "Bob";
// int widgetsPurchased = 7;
// Testing a change to the message.
// int widgetsSold = 7;
// Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
// Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");

// 16th test: create arrays foreach loop

// initialize variables - graded assignments
// int examAssignments = 5;

// int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
// int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
// int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
// int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

// // Student names
// string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

// int[] studentScores = new int[10];

// string currentStudentLetterGrade = "";

// // Write the Report Header to the console
// Console.WriteLine("Student\t\tGrade\n");

// foreach (string name in studentNames)
// {
//     string currentStudent = name;

//     if (currentStudent == "Sophia")
//        studentScores = sophiaScores;

//     else if (currentStudent == "Andrew")
//         studentScores = andrewScores;

//     else if (currentStudent == "Emma")
//         studentScores = emmaScores;

//     else if (currentStudent == "Logan")
//         studentScores = loganScores;

//     // initialize/reset the sum of scored assignments
//     int sumAssignmentScores = 0;

//     // initialize/reset the calculated average of exam + extra credit scores
//     decimal currentStudentGrade = 0;

//     // initialize/reset a counter for the number of assignment 
//     int gradedAssignments = 0;

//     // loop through the scores array and complete calculations for currentStudent
//     foreach (int score in studentScores)
//     {
//         // increment the assignment counter
//         gradedAssignments += 1;

//         if (gradedAssignments <= examAssignments)
//             // add the exam score to the sum
//             sumAssignmentScores += score;

//         else
//             // add the extra credit points to the sum - bonus points equal to 10% of an exam score
//             sumAssignmentScores += score / 10;
//     }

//     currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

//     if (currentStudentGrade >= 97)
//         currentStudentLetterGrade = "A+";

//     else if (currentStudentGrade >= 93)
//         currentStudentLetterGrade = "A";

//     else if (currentStudentGrade >= 90)
//         currentStudentLetterGrade = "A-";

//     else if (currentStudentGrade >= 87)
//         currentStudentLetterGrade = "B+";

//     else if (currentStudentGrade >= 83)
//         currentStudentLetterGrade = "B";

//     else if (currentStudentGrade >= 80)
//         currentStudentLetterGrade = "B-";

//     else if (currentStudentGrade >= 77)
//         currentStudentLetterGrade = "C+";

//     else if (currentStudentGrade >= 73)
//         currentStudentLetterGrade = "C";

//     else if (currentStudentGrade >= 70)
//         currentStudentLetterGrade = "C-";

//     else if (currentStudentGrade >= 67)
//         currentStudentLetterGrade = "D+";

//     else if (currentStudentGrade >= 63)
//         currentStudentLetterGrade = "D";

//     else if (currentStudentGrade >= 60)
//         currentStudentLetterGrade = "D-";

//     else
//         currentStudentLetterGrade = "F";

//     //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
//     Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
// }

// // required for running in VS Code (keeps the Output windows open to view results)
// Console.WriteLine("\n\rPress the Enter key to continue");
// Console.ReadLine();

// 17th test
// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0; //line added for the task 
// bool found = false; //line addedd for fulfillment of the task

// foreach (int number in numbers)
// {
//     // int total;

//     total += number;

//     if (number == 42)
//     {
//        found = true;

//     }

// }

// if (found) 
// {
//     Console.WriteLine("Set contains 42");

// }

// Console.WriteLine($"Total: {total}");

// 18th test: switch statement

// string fruit = "apple";

// switch (fruit)
// {
//     case "apple":
//         Console.WriteLine($"App will display information for apple.");
//         break;

//     case "banana":
//         Console.WriteLine($"App will display information for banana.");
//         break;

//     case "cherry":
//         Console.WriteLine($"App will display information for cherry.");
//         break;
// }

// second code block 

// int employeeLevel = 200;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//         title = "Junior Associate";
//         break;
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");

// 20th test: change if statements for switch

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0])
// {
//     case "01":
//         type = "Sweat shirt";
//         break;
//     case "02":
//         type = "T-Shirt";
//         break;
//     case "03":
//         type = "Sweat pants";
//         break;
//     default:
//         type = "Other";
//         break;
// }

// switch (product[1])
// {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default:
//         color = "White";
//         break;
// }
// switch (product[2])
// {
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One Size Fits All";
//         break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");

// 21th test

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }

// 22th test

// for (int i = 0; i < 101; i++) {

//     if ((i % 3 == 0) && (i % 5 == 0)) {
//         Console.WriteLine($"{i} - FizzFuzz");
//     } else if (i % 3 == 0) {
//         Console.WriteLine($"{i} - Buzz");
//     } else if (i % 5 == 0) {
//         Console.WriteLine($"{i} - Fizz");
//     } else {
//         Console.WriteLine($"{i}");
//     }
// }

// 23th test

// Random random = new Random();
// int current = random.Next(1, 11);

/*
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");

// 24th test

// Random random = new Random();
// int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue; // if (current >= 8) continue;, our code ensures that a value of current that is greater than or equal to 8 will never be written to the output window.

//     Console.WriteLine(current);
// } while (current != 7);

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/

// 25th test 
// CountTo(5);

// 	void CountTo(int max) 
// 	{
// 		for (int i = 0; i < max; i++)
// 		{
// 			Console.Write($"${i}, ");
// 		}
//         Console.WriteLine("");
// 	}

// 26th test 

// int[] schedule = {800, 1200, 1600, 2000};

// void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT) 
// {
// int diff = 0;
// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
// } 
// else 
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
// }
// for (int i = 0; i < times.Length; i++) 
// {
//     int newTime = ((times[i] + diff)) % 2400;
//     Console.WriteLine($"{times[i]} -> {newTime}");
// }
// }
// DisplayAdjustedTimes(schedule, 6, -6);


// 26th test: method scope

// string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

// DisplayStudents(students);
// DisplayStudents(new string[] {"Robert","Vanya"});

// void DisplayStudents(string[] students) 
// {
//     foreach (string student in students) 
//     {
//         Console.Write($"{student}, ");
//     }
//     Console.WriteLine();
// }

// Notice that the method parameter student takes precedence over the global student array. It's important to be deliberate about what global variables you want your methods to use.

//27th test

// double pi = 3.14159;
// PrintCircleInfo(12);
// PrintCircleInfo(24);


// void PrintCircleArea(int radius)
// {
//     double area = pi * (radius * radius);
//     Console.WriteLine($"Area = {area}");
// }

// void PrintCircleCircumference(int radius)
// {
//     double circumference = 2 * pi * radius;
//     Console.WriteLine($"Circumference = {circumference}");
// }
// void PrintCircleInfo(int radius) 
// {
//     Console.WriteLine($"Circle with radius {radius}");
//     PrintCircleArea(radius);
//     PrintCircleCircumference(radius);
// }

// 28th test
// int a = 3;
// int b = 4;
// int c = 0;

// Multiply(a, b, c);
// Console.WriteLine($"global statement: {a} x {b} = {c}");

// void Multiply(int a, int b, int c) 
// {
//     c = a * b;
//     Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
// }

//  29th test
// int[] array = {1, 2, 3, 4, 5};

// PrintArray(array);
// Clear(array);
// PrintArray(array);

// void PrintArray(int[] array) 
// {
//     foreach (int a in array) 
//     {
//         Console.Write($"{a} ");
//     }
//     Console.WriteLine();
// }

// void Clear(int[] array) 
// {
//     for (int i = 0; i < array.Length; i++) 
//     {
//         array[i] = 0;
//     }
// }

// 30th test
// string status = "Healthy";

// Console.WriteLine($"Start: {status}");
// SetHealth(status, false);
// Console.WriteLine($"End: {status}");

// void SetHealth(string status, bool isHealthy) 
// {
//     status = (isHealthy ? "Healthy" : "Unhealthy");
//     Console.WriteLine($"Middle: {status}");
// }

//31th test final chapter
// string[,] corporate = 
// 	{
// 		{"Robert", "Bavin"}, {"Simon", "Bright"},
// 		{"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
// 		{"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

// 	string[,] external = 
// 	{
// 		{"Vinnie", "Ashton"}, {"Cody", "Dysart"},
// 		{"Shay", "Lawrence"}, {"Daren", "Valdes"}
// 	};

// 	string externalDomain = "hayworth.com";

// 	for (int i = 0; i < corporate.GetLength(0); i++) 
// 	{
// 		DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
// 	}

// 	for (int i = 0; i < external.GetLength(0); i++) 
// 	{
// 		DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
// 	}

// 	void DisplayEmail(string first, string last, string domain = "contoso.com") 
// 	{
// 		string email = first.Substring(0, 2) + last;
// 		email = email.ToLower();
// 		Console.WriteLine($"{email}@{domain}");
// 	}

//32th test 

// double total = 0;
// double minimumSpend = 30.00;

// double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
// double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

// for (int i = 0; i < items.Length; i++)
// {
//     total += GetDiscountedPrice(i);
// }

// total -= TotalMeetsMinimum() ? 5.00 : 0.00;

// Console.WriteLine($"Total: ${FormatDecimal(total)}");

// double GetDiscountedPrice(int itemIndex)
// {
//     return items[itemIndex] * (1 - discounts[itemIndex]);
// }

// bool TotalMeetsMinimum()
// {
//     return total >= minimumSpend;
// }

// string FormatDecimal(double input)
// {
//     return input.ToString().Substring(0, 5);
// }


// 33th test
// double usd = 23.73;
// int vnd = UsdToVnd(usd);

// Console.WriteLine($"${usd} USD = ${vnd} VND");
// Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

// int UsdToVnd(double usd) 
// {
//     int rate = 23500;
//     return (int) (rate * usd);
// }

// double VndToUsd(int vnd) 
// {
//     double rate = 23500;
//     return vnd / rate;
// }

//34th test

// string input = "there are snakes at the zoo";

// Console.WriteLine(input);
// Console.WriteLine(ReverseSentence(input));

// string ReverseSentence(string input) 
// {
//     string result = "";
//     string[] words = input.Split(" ");
//     foreach(string word in words) 
//     {
//         result += ReverseWord(word) + " ";
//     }
//     return result.Trim();
// }

// string ReverseWord(string word) 
// {
//     string result = "";
//     for (int i = word.Length - 1; i >= 0; i--) 
//     {
//         result += word[i];
//     }
//     return result;
// }

// 35th test 
// string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

// Console.WriteLine("Is it a palindrome?");
// foreach (string word in words) 
// {
//     Console.WriteLine($"{word}: {IsPalindrome(word)}");
// }

// bool IsPalindrome(string word) 
// {
//     int start = 0;
//     int end = word.Length - 1;

//     while (start < end) 
//     {
//         if (word[start] != word[end]) 
//         {
//             return false;
//         }
//         start++;
//         end--;
//     }

//     return true;
// }

// 36th test

// int target = 30;
// int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
// int[,] result = TwoCoins(coins, target);

// if (result.Length == 0) 
// {
//     Console.WriteLine("No two coins make change");
// } 
// else 
// {
//     Console.WriteLine("Change found at positions:");
//     for (int i = 0; i < result.GetLength(0); i++) 
//     {
//         if (result[i,0] == -1) 
//         {
//             break;
//         }
//         Console.WriteLine($"{result[i,0]},{result[i,1]}");
//     }
// }

// int[,] TwoCoins(int[] coins, int target) 
// {
//     int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
//     int count = 0;

//     for (int curr = 0; curr < coins.Length; curr++) 
//     {
//         for (int next = curr + 1; next < coins.Length; next++) 
//         {    
//             if (coins[curr] + coins[next] == target) 
//             {
//                 result[count, 0] = curr;
//                 result[count, 1] = next;
//                 count++;
//             }
//             if (count == result.GetLength(0)) 
//             {
//                 return result;
//             }
//         }
//     }
//     return (count == 0) ? new int[0,0] : result;
// }

// 37th test

// Random random = new Random();

// Console.WriteLine("Would you like to play? (Y/N)");
// if (ShouldPlay()) 
// {
//     PlayGame();
// }

// bool ShouldPlay() 
// {
//     string response = Console.ReadLine();
//     return response.ToLower().Equals("y");
// }

// void PlayGame() 
// {
//     var play = true;

//     while (play) {
//         var target = GetTarget();
//         var roll = RollDice();

//         Console.WriteLine($"Roll a number greater than {target} to win!");
//         Console.WriteLine($"You rolled a {roll}");
//         Console.WriteLine(WinOrLose(roll, target));
//         Console.WriteLine("\nPlay again? (Y/N)");

//         play = ShouldPlay();
//     }
// }

// int GetTarget() 
// {
//     return random.Next(1, 6);
// }

// int RollDice() 
// {
//     return random.Next(1, 7);
// }

// string WinOrLose(int roll, int target) 
// {
//     if (roll > target) 
//     {
//         return "You win!";
//     }
//     return "You lose!";
// }

// 38th test

// using System;

// string[] pettingZoo = 
// {
//     "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
//     "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
//     "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
// };

// PlanSchoolVisit("School A");
// PlanSchoolVisit("School B", 3);
// PlanSchoolVisit("School C", 2);

// void PlanSchoolVisit(string schoolName, int groups = 6) 
// {
//     RandomizeAnimals(); 
//     string[,] group1 = AssignGroup(groups);
//     Console.WriteLine(schoolName);
//     PrintGroup(group1);
// }

// void RandomizeAnimals() 
// {
//     Random random = new Random();

//     for (int i = 0; i < pettingZoo.Length; i++) 
//     {
//         int r = random.Next(i, pettingZoo.Length);

//         string temp = pettingZoo[r];
//         pettingZoo[r] = pettingZoo[i];
//         pettingZoo[i] = temp;
//     }
// }

// string[,] AssignGroup(int groups = 6) 
// {
//     string[,] result = new string[groups, pettingZoo.Length/groups];
//     int start = 0;

//     for (int i = 0; i < groups; i++) 
//     {
//         for (int j = 0; j < result.GetLength(1); j++) 
//         {
//             result[i,j] = pettingZoo[start++];
//         }
//     }

//     return result;
// }

// void PrintGroup(string[,] groups) 
// {
//     for (int i = 0; i < groups.GetLength(0); i++) 
//     {
//         Console.Write($"Group {i + 1}: ");
//         for (int j = 0; j < groups.GetLength(1); j++) 
//         {
//             Console.Write($"{groups[i,j]}  ");
//         }
//         Console.WriteLine();
//     }
// }

// 39th back to lesson 4. converting data types

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// decimal decimaling = 3.14m;
// Console.WriteLine($"decimal: {decimaling}");

// int inting = (int)decimaling;
// Console.WriteLine($"int: {inting}");

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");

// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine($"String: {message}");

// string primero = "5";
// string segundo = "7";
// int sum = int.Parse(primero) + int.Parse(segundo);
// Console.WriteLine(sum);

// string value1 = "5";
// string value2 = "7";
// int resultado = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(resultado);

// int valor1 = (int)1.5m; // casting truncates
// Console.WriteLine(valor1);

// int valor2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(valor2);

// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }

// if (result > 0) {
//     Console.WriteLine($"Measurement (w/ offset): {50 + result}");
//     }

// 40th test: excercise test

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// decimal total = 0m;
// string message = "";

// foreach (var value in values)
// {
//     decimal number; // stores the TryParse "out" value
//     if (decimal.TryParse(value, out number)) // if the value that comes out is a number add the number
//     {
//         total += number;
//     } else // else concat the string in a variable
//     {
//         message += value;
//     }
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");

//41th test

// int value1 = 12;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// // The Convert class is best for converting the fractional decimal numbers into whole integer numbers
// // Convert.ToInt32() rounds up the way you would expect.
// int result1 = Convert.ToInt32((decimal)value1 / value2);
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// decimal result2 = value2 / (decimal)value3;
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// float result3 = value3 / value1;
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

//42th test 
// string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

//43th test

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// 44th test

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

//45th test

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

//46th test

// string pangram = "The quick brown fox jumps over the lazy dog";

// // Step 1
// string[] message = pangram.Split(' ');

// //Step 2
// string[] newMessage = new string[message.Length];

// // Step 3
// for (int i = 0; i < message.Length; i++)
// {
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters);
// }

// //Step 4
// string result = String.Join(" ", newMessage);
// Console.WriteLine(result);

// 47th test. final tst

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// string[] items = orderStream.Split(',');
// Array.Sort(items);

// foreach (var item in items)
// {
//     if (item.Length == 4)
//     {
//         Console.WriteLine(item);
//     }
//     else
//     {
//         Console.WriteLine(item + "\t- Error");
//     }
// }

// 48th test

// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// Console.WriteLine($"Dear {customerName},");
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
// Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";

// comparisonMessage = currentProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

// comparisonMessage += "\n";
// comparisonMessage += newProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

// Console.WriteLine(comparisonMessage);

// 49th test

// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

//50 test. string conversion methods built in

string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}