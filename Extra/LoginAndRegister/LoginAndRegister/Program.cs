using System;

namespace LoginAndRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            var usernames = new string[] { "user1@mail.com", "user2@mail.com", "user3@mail.com" };
            var passwords = new string[] { "Password1&&", "Password2&&", "Password3&&" };
            Console.Write("Do you want to register(1) or login(2)?");
            var input = Console.ReadLine();
            
            //check if user entered 1/2
            while (true)
            {
                if (input == "1" || input == "2")
                {
                    break;
                }
                Console.WriteLine("You need to enter 1 or 2.");
                input = Console.ReadLine();
                
            }

            int.TryParse(input, out int answer);


            switch (answer)
            {
                case 1:
                    //user enters 1
                    {
                        Console.Write("Enter a username: ");
                        var username = Console.ReadLine();


                        while (true)
                        {
                            int check1 = 0;
                            int check2 = 0;
                            char[] letters = username.ToCharArray();
                            //check if username is entered correctly
                            for (int i = 0; i < letters.Length; i++)
                            {
                                if (letters[i] == '@')
                                    check1++;

                                if (letters[i] == '.')
                                    check2++;
                            }
                            if (check1 != 1 || check2 < 1)
                            {
                                Console.WriteLine("You need to enter an email as a username!");
                                Console.WriteLine("Enter a username: ");
                                username = Console.ReadLine();
                                letters = username.ToCharArray();
                                continue;
                            }

                            if (Char.IsDigit(letters[0]) || letters[0] == '%' || letters[0] == '#' || letters[0] == '^' || letters[0] == '!' || letters[0] == '&')
                            {
                                Console.WriteLine("Username cannot start with a number or a special character!");
                                Console.WriteLine("Enter a username: ");
                                username = Console.ReadLine();
                                letters = username.ToCharArray();
                                continue;
                            }

                            if (Char.IsDigit(letters[letters.Length - 1]) || letters[letters.Length - 1] == '%' || letters[letters.Length - 1] == '#' || letters[letters.Length - 1] == '^' || letters[letters.Length - 1] == '!' || letters[letters.Length - 1] == '&')
                            {
                                Console.WriteLine("Username cannot end with a number or a special character!");
                                Console.WriteLine("Enter a username: ");
                                username = Console.ReadLine();
                                letters = username.ToCharArray();
                                continue;
                            }

                            if (letters.Length > 30)
                            {
                                Console.WriteLine("The email should not be over 30 characters long!");
                                Console.WriteLine("Enter a username: ");
                                username = Console.ReadLine();
                                letters = username.ToCharArray();
                                continue;
                            }
                            break;
                        }
                        Array.Resize(ref usernames, usernames.Length + 1);
                        usernames[usernames.Length - 1] = username;


                        Console.Write("Enter a password: ");
                        var input1 = Console.ReadLine();

                        //check if password is entered correctly

                        while (true)
                        {
                            char[] password = input1.ToCharArray();
                            int countSpecial = 0;
                            int countUpper = 0;
                            int countLower = 0;
                            for (int i = 0; i < password.Length; i++)
                            {
                                if (Char.IsUpper(password[i]))
                                    countUpper++;

                                if (Char.IsLower(password[i]))
                                    countLower++;

                                if (password[i] == '%' || password[i] == '&' || password[i] == '!' || password[i] == '^' || password[i] == '#')
                                    countSpecial++;
                            }

                            if (password.Length < 10)
                            {
                                Console.WriteLine("Your password should be at least 10 letters long!");
                                Console.Write("Enter a new password: ");
                                input1 = Console.ReadLine();
                                password = input1.ToCharArray();
                                continue;
                            }

                            if (countSpecial < 2 || countUpper < 1 || countLower < 1)
                            {
                                Console.WriteLine("Your password needs to contain upper case letter, lower case letter and 2 special characters!");
                                Console.Write("Enter a new password: ");
                                input1 = Console.ReadLine();
                                password = input1.ToCharArray();
                                continue;
                            }

                            break;
                        }

                        Array.Resize(ref passwords, passwords.Length + 1);
                        passwords[passwords.Length - 1] = input1;
                    }

                    break;

                case 2:
                    //user enters 2
                    {
                        int tries = 0;
                        while (true)
                        {

                            Console.WriteLine("Enter a username/email: ");
                            var username = Console.ReadLine();
                            while (true)
                            {
                                int check1 = 0;
                                int check2 = 0;
                                char[] letters = username.ToCharArray();
                                //check if username is entered correctly
                                for (int i = 0; i < letters.Length; i++)
                                {
                                    if (letters[i] == '@')
                                        check1++;

                                    if (letters[i] == '.')
                                        check2++;
                                }
                                if (check1 != 1 || check2 < 1)
                                {
                                    Console.WriteLine("You need to enter an email as a username!");
                                    Console.WriteLine("Enter a username: ");
                                    username = Console.ReadLine();
                                    letters = username.ToCharArray();
                                    continue;
                                }

                                if (Char.IsDigit(letters[0]) || letters[0] == '%' || letters[0] == '#' || letters[0] == '^' || letters[0] == '!' || letters[0] == '&')
                                {
                                    Console.WriteLine("Username cannot start with a number or special character!");
                                    Console.WriteLine("Enter a username: ");
                                    username = Console.ReadLine();
                                    letters = username.ToCharArray();
                                    continue;
                                }

                                if (Char.IsDigit(letters[letters.Length - 1]) || letters[letters.Length - 1] == '%' || letters[letters.Length - 1] == '#' || letters[letters.Length - 1] == '^' || letters[letters.Length - 1] == '!' || letters[letters.Length - 1] == '&')
                                {
                                    Console.WriteLine("Username cannot end with a number or special character!");
                                    Console.WriteLine("Enter a username: ");
                                    username = Console.ReadLine();
                                    letters = username.ToCharArray();
                                    continue;
                                }

                                if (letters.Length > 30)
                                {
                                    Console.WriteLine("The email should not be over 30 characters long!");
                                    Console.WriteLine("Enter a username: ");
                                    username = Console.ReadLine();
                                    letters = username.ToCharArray();
                                    continue;
                                }
                                break;
                            }

                            Console.WriteLine("Enter a password: ");
                            var input1 = Console.ReadLine();
                            while (true)
                            {
                                char[] password = input1.ToCharArray();
                                int countSpecial = 0;
                                int countUpper = 0;
                                int countLower = 0;
                                for (int i = 0; i < password.Length; i++)
                                {
                                    if (Char.IsUpper(password[i]))
                                        countUpper++;

                                    if (Char.IsLower(password[i]))
                                        countLower++;

                                    if (password[i] == '%' || password[i] == '&' || password[i] == '!' || password[i] == '^' || password[i] == '#')
                                        countSpecial++;
                                }

                                if (password.Length < 10)
                                {
                                    Console.WriteLine("Your password should be at least 10 letters long!");
                                    Console.Write("Enter a new password: ");
                                    input1 = Console.ReadLine();
                                    password = input1.ToCharArray();
                                    continue;
                                }

                                if (countSpecial < 2 || countUpper < 1 || countLower < 1)
                                {
                                    Console.WriteLine("Your password needs to contain upper case letter, lower case letter and 2 special characters!");
                                    Console.Write("Enter a new password: ");
                                    input1 = Console.ReadLine();
                                    password = input1.ToCharArray();
                                    continue;
                                }

                                break;
                            }

                            int indexOfUsername = Array.IndexOf(usernames, username);
                            int indexOfPassword = Array.IndexOf(passwords, input1);

                            if (indexOfUsername == indexOfPassword)
                            {
                                Console.WriteLine("You have succesfully logged in!");
                                break;
                            }

                            else if (tries <= 3)
                            {
                                Console.WriteLine("You have entered an incorrect username or password! Try again!");
                                tries++;
                                continue;
                            }

                            else
                            {
                                Console.WriteLine("You have entered an incorrect username or password 3 times! User is blocked!");
                                break;
                            }


                        }
                        
                    }
                    break;


            }
        }
    }
}
