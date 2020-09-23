using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator_Interface;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int option = 0, result = 0, number1 = 0, number2 = 0;

                Console.WriteLine("1.Add\n2.Subtract\n3.Multiply\n4.Divide\n5.Exit");
                Console.WriteLine("Choose One Option :");
                var optionStr = Console.ReadLine();

                if (Int32.TryParse(optionStr, out option) && option > 0)
                {
                    if (option <= 4)
                        {
                        while (true)
                        {
                            string arg1, arg2;
                            Console.WriteLine("Start :");
                            arg1 = Console.ReadLine();

                            if (option == 1 || option == 2)
                                Console.WriteLine("Amount :");
                            else
                                Console.WriteLine("By :");
                            arg2 = Console.ReadLine();

                            if (Int32.TryParse(arg1, out number1) && Int32.TryParse(arg2, out number2))
                            {
                                CalculatorInject calculatorObj = new CalculatorInject(new CalculatorAdapter());
                                switch (option)
                                {
                                    case 1:
                                        result = calculatorObj.Add(number1, number2);
                                        Console.WriteLine("Adding Of Two Numbers " + number1 + "+" + number2 + " and Result is: " + result);
                                        break;
                                    case 2:
                                        result = calculatorObj.Subtract(number1, number2);
                                        Console.WriteLine("Subtracting Of Two Numbers " + number1 + "-" + number2 + " and Result is: }" + result);
                                        break;
                                    case 3:
                                        result = calculatorObj.Multiply(number1, number2);
                                        Console.WriteLine("Multiply Of " + number1 + "*" + number2 + " and Result is: " + result);
                                        break;
                                    case 4:
                                        result = calculatorObj.Divide(number1, number2);
                                        Console.WriteLine("Divide Of " + number1 + "/" + number2 + " and Result is: " + result);
                                        break;
                                }
                                Console.WriteLine("----------------------------------");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("---------Invalid Numbers---------");
                            }
                        }
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("---------Invalid Option---------");
                }
            }
        }
    }
}

