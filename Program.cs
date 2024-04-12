// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int  : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long  : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");
// Console.WriteLine($"byte  : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort  : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint  : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");


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

// Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// decimal total = 0;
// string checkedString = "";
// decimal checkedValue;

// foreach (var value in values)
// {
//     if (decimal.TryParse(value, out checkedValue))
//     {
//         total += checkedValue;
//     }
//     else
//     {
//         checkedString += value;
//     }

// }

// Console.WriteLine($"Message: {checkedString}");
// Console.WriteLine($"Total: {total}");

// using System.ComponentModel;

// int value1 = 12;
// decimal value2 = 6.2m;
// float value3 = 4.3f;


// int result1 = Convert.ToInt32(value1 / value2);

// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");


// decimal result2 = value2 / (decimal)value3;

// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// float result3 = value3 / value1;

// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

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

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0].ToLower()}");
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"After: {pallets[0].ToLower()}");


// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

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

// string pangram = "The quick brown fox jumps over the lazy dog";

// string reversedPangram = "";

// string[] splitWords = pangram.Split(" ");

// for (int i = 0; i < splitWords.Length; i++)
// {
//     char[] charValue = splitWords[i].ToCharArray();
//     Array.Reverse(charValue);
//     string output = String.Join("", charValue);

//     // reversedPangram = reversedPangram + " " + output;
//     reversedPangram = $"{reversedPangram} {output}";
// }

// Console.WriteLine(reversedPangram);


// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// string[] orderStreamArray = orderStream.Split(",");

// Array.Sort(orderStreamArray);

// foreach (string order in orderStreamArray)
// {
//     if (order.Length != 4)
//     {
//         Console.WriteLine($"{order} \t - Error");
//     }
//     else
//     {
//         Console.WriteLine(order);

//     }
// }

// decimal price = 500.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N1} units");

// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P1}");

// decimal price = 67.55m;
// decimal salesPrice = 59.99m;

// string yourDiscount = $"You saved {(price - salesPrice):C2} off the regular price.";

// yourDiscount += $" A discount of {((price - salesPrice) / price):P2}!";
// Console.WriteLine(yourDiscount);

// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"    Shares: {productShares:N3} Product");
// Console.WriteLine($"        Sub Total: {subtotal:C}");
// Console.WriteLine($"            Tax: {taxPercentage:P2}");
// Console.WriteLine($"        Total Billed: {total:C}");

// string input = "Pad this";
// Console.WriteLine(input);
// Console.WriteLine(input.PadLeft(12));
// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));

// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";

// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);


// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);

// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// // Your logic here


// string formattedMsg = $"Dear {customerName},\nAs a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\nCurrently, you own {currentShares.ToString("#,##0")} shares at a return of {currentReturn:P2}.\n\nOur new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}\n\n";

// string comparisonMessage = "";

// // Your logic here
// comparisonMessage += formattedMsg;


// Console.WriteLine(comparisonMessage);
// Console.WriteLine("Here's a quick comparison:\n");
// Console.WriteLine($"{currentProduct.PadRight(20)} {currentReturn:P2} {currentProfit.ToString("C").PadLeft(15)}");
// Console.WriteLine($"{newProduct.PadRight(20)} {newReturn:P2} {newProfit.ToString("C").PadLeft(15)}");

// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf("(");
// int closingPosition = message.IndexOf(")");

// openingPosition += 1;

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "What is the value <span>between the tag</span>";

// int openingPosition = message.IndexOf("<span>");
// int closingPosition = message.IndexOf("</span>");

// openingPosition += 6;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "(What if) I am (only interested) in the last (set of parentheses) learning C# has been interesting (E make sense die)?";
// int openingPosition = message.LastIndexOf('(');

// openingPosition += 1;
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

//string message = "(what if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char arrays of characters.
// You want to look for:

//char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

//int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);

// Now find the matching closing symbol
// char matchingSymbol = ' ';

// switch (currentSymbol)
// {
//     case "[":
//         matchingSymbol = ']';
//         break;
//     case "{":
//         matchingSymbol = '}';
//         break;
//     case "(":
//         matchingSymbol = ')';
//         break;


// }

// To find the closingPosition, use an overload of the IndexOf method to specify 
// that the search for the matchingSymbol should start at the openingPosition in the string. 
// openingPosition += 1;
// closingPosition = message.IndexOf(matchingSymbol, openingPosition);

// Finally, use the techniques you've already learned to display the sub-string:

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));
// }

// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);

//const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

//string quantity = "";
//string output = "";

//// Your work here

//int spanBegins = input.IndexOf("<span>");
//int spanEnds = input.IndexOf("</span>");

//spanBegins += 6;

//int length = spanEnds - spanBegins;
//quantity = input.Substring(spanBegins, length);


//output = input.Replace("<div>", "");
//output = input.Replace("&trade", "&reg");


//Console.WriteLine($"Quantity: {quantity}");
//Console.WriteLine($"Output: {output}");




//void DisplayRandomNumbers(int howManyTimes)
//{
//    Random random = new Random();

//    for (int i = 0; i < howManyTimes; i++)
//    {
//       int randomNumber =  random.Next(1, 100);
//       Console.WriteLine(randomNumber.ToString());
//    }

//}

//DisplayRandomNumbers(100);


using System;

int[] times = { 800, 1200, 1600, 2000 };
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");

DisplayTimes();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
{
    AdjustTimes();
}
else
{
    AdjustTimes();
}

Console.WriteLine("New Medicine Schedule:");

DisplayTimes();

void DisplayTimes()
{
    /* Format and display medicine times */
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        else
        {
            time = time.Insert(0, "0:0");
        }

        Console.Write($"{time} ");
    }

    Console.WriteLine();
}

void AdjustTimes()
{

    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    for (int i = 0; i < times.Length; i++)
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}
