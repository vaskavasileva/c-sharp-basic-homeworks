using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyApp.Entities
{
    public class Student : Participant
    {
        public int Group;

        public void FavoriteHomework(Subject subject)
        {
            switch (subject.Title)
            {
                case "C# Basic" :
                    Console.WriteLine("Traffic light");
                    break;
                default:
                    break;
            }
        }
    }
}
