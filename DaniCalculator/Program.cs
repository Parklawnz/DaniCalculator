using System;

namespace DaniCalculator
{
    public enum ProductCodes
    {
        Jam = 1,
        Milk = 2,
        Apple = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer Cust01 = new Customer();
            Cust01.userName = "wtf";
            Cust01.pin = 4200;


            ProductCodes test = ProductCodes.Milk;
            Console.WriteLine((int)test);

            int test2 = 1;
            Console.WriteLine((ProductCodes)test2);

            string test3 = "Milk";
            ProductCodes getParse;
            bool checkParse = Enum.TryParse(test3, out getParse);
            Console.WriteLine(getParse);


            Console.WriteLine("Enter Username, Password");
            string name = Console.ReadLine();
            int pass = Convert.ToInt32(Console.ReadLine());

                do
                {
                    string[] userMethods = new string[4] { "+", "-", "*", "%" };

                    Console.WriteLine("CALCULATOR");
                    Console.WriteLine("\nENTER THE METHOD YOU WOULD LIKE TO USE: + - * %");
                    string input = Console.ReadLine();


                    if (input == userMethods[0])
                    {
                        Console.WriteLine("\nADDITION \nenter the digits you would like to add: ");
                        decimal result = Calc.Add(Convert.ToDecimal(Console.ReadLine()), Convert.ToDecimal(Console.ReadLine()));
                        Console.WriteLine("Total = " + result);
                    }
                    else if (input == userMethods[1])
                    {
                        Console.WriteLine("\nSUBTRACTION \nenter the digits you would like to subtract: ");
                        decimal result = Calc.Sub(Convert.ToDecimal(Console.ReadLine()), Convert.ToDecimal(Console.ReadLine()));
                        Console.WriteLine("Total = " + result);
                    }
                    else if (input == userMethods[2])
                    {
                        Console.WriteLine("\nMULTIPLICATION \nenter the digits you would like to Multiply: ");
                        decimal result = Calc.Mult(Convert.ToDecimal(Console.ReadLine()), Convert.ToDecimal(Console.ReadLine()));
                        Console.WriteLine("Total = " + result);

                    }
                    else if (input == userMethods[3])
                    {
                        Console.WriteLine("\nDIVISION \nenter the digits you would like to Divide: ");
                        decimal result = Calc.Div(Convert.ToDecimal(Console.ReadLine()), Convert.ToDecimal(Console.ReadLine()));
                        Console.WriteLine("Total = " + result);
                    }
                    else
                    {
                        Console.WriteLine("Input not vallid! Refresh and retry");
                    }
                } while (name == Convert.ToString(Customer.namePin.parkerHall));

        }
    }
}
