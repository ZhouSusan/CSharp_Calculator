class Program
{
    public static void Main(string[] args)
    {
        bool endApp = false;
        Console.WriteLine("Calculator in console: ");
        Console.WriteLine("-----------------------------------------\n");

        while (!endApp)
        {
            //Declare Variables and set to empty
            string numInput1 = "";
            string numInput2 = "";
            double result = 0;

            Console.Write("Type a number, and then press Enter: ");
            numInput1 = Console.ReadLine();


            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("This is not a valid input. Please enter an integer value: ");
                numInput1 = Console.ReadLine();
            }

            Console.Write("Type another number, and then press Enter: ");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while(!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("This is not a valid number. Please enter an intger value: ");
                numInput2 = Console.ReadLine();
            }

            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Substract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your Option: ");

            string operand = Console.ReadLine();

            try {
                result = Calculator.Calculator.DoOperation(cleanNum1, cleanNum2, operand);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("This operation will result in a mathamtical error.\n");
                } else
                {
                    Console.WriteLine("Yor result: {0:0.##}\n", result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Oh, no!An expection occurred trying to do the math.\n - Details " + e.Message);

            }

            Console.WriteLine("Press 'n' and Enter to close the app,\n or press any other key and Enter to coninue: ");
            if (Console.ReadLine() == "n")
            {
                endApp = true; 
            }

           Console.WriteLine("\n");
        }
        return;
    }
}