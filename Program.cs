// See https://aka.ms/new-console-template for more information
double num1 = 0;
double num2 = 0;

Console.WriteLine("Calulator\r");
Console.WriteLine("--------------------------------\n");


//User's First number
Console.WriteLine("Type a number, and then press Enter");
num1 = Convert.ToDouble(Console.ReadLine());


//User's Second Number
Console.WriteLine("Type another number, and then press Enter.");
num2 = Convert.ToDouble(Console.ReadLine());

//User's option
Console.WriteLine("Choose an option from the following list: ");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.Write("You have selected option: ");

switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Result: {num1} + {num2} = " + Math.Round((num1 + num2), 2));
        break;
    case "s":
        Console.WriteLine($"Result : {num1} - {num2} = " + Math.Round((num1 - num2), 2));
        break;
    case "m":
        Console.WriteLine($"Result: {num1} * {num2} = " + Math.Round((num1 * num2), 2));
        break;
    case "d":
        Console.WriteLine($"Result : {num1} / {num2} = " + Math.Round((num1 / num2), 2));
        break;
}

Console.WriteLine("Press any key to close the Calculator console app");
Console.ReadKey();