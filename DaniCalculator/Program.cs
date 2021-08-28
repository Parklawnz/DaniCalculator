using System;
using System.IO;

namespace DaniCalculator
{
  

    class Program
    {
        // DATABASE ------------------------------------

        public static void databaseWrite(string userName, string userPin, string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    file.Write(userName + "," + userPin + ",");
                }

            }catch(Exception ex)
            {
                throw new Exception("something happened, idk");
            }
        }
        // READ DATABASE
        public static string[] databaseRead(string searchTerm, string filepath, int positionofTerm)
        {
            positionofTerm--;
            string[] recordNotFound = { "User Name/Passowrd Not Recognized" };
            try
            {
                string[] lines = System.IO.File.ReadAllLines(@filepath);
                {
                    for(int i = 0; i < lines.Length; i++)
                    {
                        string[] fields = lines[i].Split(",");
                        if(validateCredentials(searchTerm,fields,positionofTerm))
                            {
                            Console.WriteLine("Hello!");
                            return fields;
                            }
                    }
                    return recordNotFound;
                }
            }catch(Exception ex)
            {
                throw new Exception("something happened, idk");
            }

        }
        // VALIDATE DATABASE INQUIRY ----------------------------------
        
        public static bool validateCredentials( string credential, string[] record, int positionOfTerm)
        {
            if(record[positionOfTerm].Equals(credential))
            {
                return true;
            }
            return false;
        }
        // VALIDATE INPUT ------------------------------
        public static string validateInput()
        {
            while(true)
            {
                string userInput = Console.ReadLine();
                int i = 0;

                if(userInput == "1" ||
                   userInput == "2" ||
                   userInput == "3" ||
                   userInput == "4" ||
                   userInput == "5" ||
                   userInput == "6")
                {
                    Console.Clear();
                    return userInput;
                }
                if(int.TryParse(userInput, out i) || i < 0 || i > 7)
                {
                    Console.WriteLine("Error, enter a valid number");
                }else
                {
                    Console.WriteLine("Error, enter a valid number");
                }

            }
        }
        // CALCULATOR -------------------------------------------
        public static int Calculator()
        {
            int ctrl = 0;
            do
            {
                string[] userMethods = new string[5] { "+", "-", "*", "%", "Esc"};

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
                }else if(input == userMethods[4])
                {
                    ctrl = 2;
                }
                else
                {
                    Console.WriteLine("Input not vallid! Refresh and retry");
                    ctrl++;
                }
            } while (ctrl < 2);
            return ctrl;
        }

        //M A I N --------------------------------------------

        static void Main(string[] args)
        {
            string userInput;
            int num;

            Console.WriteLine(string.Join(" ",databaseRead("PaulaDean", "Users.csv",1)));
            Console.ReadLine();

            



            string[] menueOptions = new string[7]
                {"1","2","3","4","5","6","7"};

            Console.WriteLine("WELCOME");
            Console.WriteLine("\n MAIN MENUE");
            Console.WriteLine("\n 0 = NO" +
                              "\n1 = Yes" +
                              "\n2 = Escape" +
                              "\n3 = Calculator");
            userInput = validateInput();
            if(userInput == "3")
            {
                userInput = Convert.ToString(Calculator());
            }


            Console.WriteLine("Enter Username, Password");
            string name = Console.ReadLine();
            int pass = Convert.ToInt32(Console.ReadLine());
            int ctrl = 0;

          
            
        }
    }
}
