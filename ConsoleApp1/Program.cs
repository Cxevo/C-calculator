//initialize variables to zero
int nmr1 = 0; int nmr2 = 0;

//title
Console.WriteLine("C sharp calculator\r\n");
Console.WriteLine("----------------------\r\n");

//First user input
Console.WriteLine("Enter a number");
nmr1 = Convert.ToInt32(Console.ReadLine());

//Second user Input
Console.WriteLine("Enter a second number");
nmr2 = Convert.ToInt32(Console.ReadLine());

//ask user to choose operator
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - multiply");
Console.WriteLine("\td - Divide");
Console.Write("Your operator? ");

//doing the math
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {nmr1} + {nmr2} = " + (nmr1 + nmr2));
        break;
    case "s":
        Console.WriteLine($"Your result: {nmr1} - {nmr2} = " + (nmr1 - nmr2));
        break;
    case "m":
        Console.WriteLine($"Your result: {nmr1} * {nmr2} = " + (nmr1 * nmr2));
        break;
    case "d":
        Console.WriteLine($"Your result: {nmr1} / {nmr2} = " + (nmr1 / nmr2));
        break;
}
// wait for user
Console.Write("Press any key too close...");
Console.ReadKey();