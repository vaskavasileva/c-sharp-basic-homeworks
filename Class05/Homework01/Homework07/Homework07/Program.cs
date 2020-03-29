using System;

namespace Homework07
{

    class Dog
    {

        public string name;
        public string race;
        public string color;

        public static void Eat()
        {
            Console.WriteLine("The dog is now eating.");
        }

        public static void Play()
        {
            Console.WriteLine("The dog is now playing.");
        }

        public static void ChaseTail()
        {
            Console.WriteLine("The dog is now chasing its tail.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            Console.WriteLine("Enter a name for your dog: ");
            dog1.name = Console.ReadLine(); 
            Console.WriteLine("Enter a race for your dog: ");
            dog1.race = Console.ReadLine();  
            Console.WriteLine("Enter a color for your dog: ");
            dog1.color = Console.ReadLine();

            Console.WriteLine("Please choose what you want your dog to do: Eat, Play or Chase Tail and enter your choise");
            var input = Console.ReadLine();
            string choise = input.ToLower();
            if (choise == "eat")
            {
                Dog.Eat();
            }

            else if (choise == "play")
            {
                Dog.Play();
            }

            else if(choise == "chase tail")
            {
                Dog.ChaseTail();
            }

            else
            {
                Console.WriteLine("You did not enter a valid choise");
            }
        }

        
    }
}
