﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of operation do you need? (+,-,*,/)");
            var input = Console.ReadLine();
            var operation = Convert.ToChar(input);


            switch (operation)
            {


                case '+':
                    {
                        Console.WriteLine("Enter the first number: ");
                        var input1 = Console.ReadLine();
                        Console.WriteLine("Enter the second number: ");
                        var input2 = Console.ReadLine();
                        int number1;
                        bool answer1 = int.TryParse(input1, out number1);
                        int number2;
                        bool answer2 = int.TryParse(input2, out number2);

                        if (answer1 == false || answer2 == false)
                        {
                            Console.WriteLine("You need to enter numbers!");
                            break;
                        }

                        int summ = number1 + number2;
                        Console.WriteLine("The summ of those numbers is: " + summ);
                                                
                    }
                    break;

                case '-':
                    {
                        Console.WriteLine("Enter the first number: ");
                        var input3 = Console.ReadLine();
                        Console.WriteLine("Enter the second number: ");
                        var input4 = Console.ReadLine();
                        int number3;
                        bool answer3 = int.TryParse(input3, out number3);
                        int number4;
                        bool answer4 = int.TryParse(input4, out number4);

                        if (answer3 == false || answer4 == false)
                        {
                            Console.WriteLine("You need to enter numbers!");
                            break;
                        }

                        int help = 0;
                        if (number3<number4)
                        {
                            help = number3;
                            number3 = number4;
                            number4 = help;
                        }

                        int difference = 0;
                        difference = number3 - number4;
                        Console.WriteLine("The difference of those numbers is: " + difference);
                    }
                    break;

                case '*':
                    {
                        Console.WriteLine("Enter the first number: ");
                        var input5 = Console.ReadLine();
                        Console.WriteLine("Enter the second number: ");
                        var input6 = Console.ReadLine();
                        int number5;
                        bool answer5 = int.TryParse(input5, out number5);
                        int number6;
                        bool answer6 = int.TryParse(input6, out number6);

                        if (answer5 == false || answer6 == false)
                        {
                            Console.WriteLine("You need to enter numbers!");
                            break;
                        }

                        int product = 0;
                        product = number5 * number6;
                        Console.WriteLine("The product of those numbers is: " + product);
                        
                    }
                    break;

                case '/':
                    {
                        Console.WriteLine("Enter the first number: ");
                        var input7 = Console.ReadLine();
                        Console.WriteLine("Enter the second number: ");
                        var input8 = Console.ReadLine();
                        int number7;
                        bool answer7 = int.TryParse(input7, out number7);
                        int number8;
                        bool answer8 = int.TryParse(input8, out number8);

                        if (answer7 == false || answer8 == false)
                        {
                            Console.WriteLine("You need to enter numbers!");
                            break;
                        }

                        if (number7 == 0 || number8 == 0)
                        {
                            Console.WriteLine("You entered 0, division with 0 is not possible!");
                            break;
                        }

                        int help1 = 0;
                        if (number7 < number8)
                        {
                            help1 = number7;
                            number7 = number8;
                            number8 = help1;
                        }

                        int quotient = 0;
                        quotient = number7 / number8;
                        Console.WriteLine("The quotient of the numbers is: " + quotient);
                    }
                    break;

                default:

                    Console.WriteLine("You entered an invalid input!");
                    break;
            }
        }
    }
}
