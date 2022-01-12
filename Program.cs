 // Console
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Title = "Calculator Test";
 // Code
int num01 = 0;
int num02 = 0;
Console.WriteLine("Console Calculator by Ram\r");
Console.WriteLine("-------------------------\n");
Console.WriteLine("\n Press enter to star :)\n");
Console.ReadLine();
Console.WriteLine("Insert a number: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
num01 = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("Insert another number: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
num02 = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("Choose an option:");
Console.WriteLine("\ta - Add ");
Console.WriteLine("\ts - Substarct");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.WriteLine("What's you'r option: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
switch (Console.ReadLine())
{
case "a":
Console.WriteLine($"Your result: {num01} + {num02} = " + (num01 + num02));
break;
case "s":
Console.WriteLine($"Your result: {num01} - {num02} = " + (num01 - num02));
break;
case "m":
Console.WriteLine($"Your result: {num01} * {num02} = " + (num01 * num02));
break;
case "d":
Console.WriteLine($"Your result: {num01} / {num02} = " + (num01 / num02));
break;
}
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("\nPress enter to leave\n");
Console.ReadLine();
 //Finish