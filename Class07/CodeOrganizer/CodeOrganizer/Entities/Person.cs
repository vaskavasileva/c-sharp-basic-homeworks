﻿using CodeOrganizer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeOrganizer.Entities
{
    class Person
    {
        public string Name;
        public int Age;
        public Address Address;
        public Job Job;
        public long SSN;

        public Person()
        {
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void PrintPerson()
        {
            Console.WriteLine($"Name:{Name}, Age:{Age}, SSN:{SSN}");
        }

        public void DevelopersSeacret()
        {
            if (Job.Role == Role.WebDeveloper)
            {
                Console.WriteLine("The secret of success is DEDUCATION");
            }
            else
            {
                Console.WriteLine($"{Name} is not developer, this is secret only for developers!");
            }
        }

    }
}
