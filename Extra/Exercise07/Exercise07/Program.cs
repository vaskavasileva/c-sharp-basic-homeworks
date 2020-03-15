using System;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            var userNames = new string[] { "user1", "user2", "user3" };
            var passwords = new string[] { "first", "second", "third" };
            var check = false;
            do
            {
            Console.WriteLine("Enter a username");
            var user = Console.ReadLine();
                if (user == userNames[0] || user == userNames[1] || user == userNames[2])
                {
                    for (int i = 0; i <= 2; i++)
                    {
                        if (user == userNames[i])
                        {
                            Console.WriteLine("Enter a password");
                            var pass = Console.ReadLine();
                            if (pass == passwords[i])
                            {
                                Console.WriteLine("You are logged in succesfully");
                                check = true;
                                break;
                            }
                            else
                                Console.WriteLine("Incorrect user or password");

                        }
                    }
                }
                else
                {
                    Console.WriteLine("Enter a password");
                    Console.ReadLine();
                    Console.WriteLine("Incorrect user or password");
                }
            } while (check == false);
        }
    }
}
