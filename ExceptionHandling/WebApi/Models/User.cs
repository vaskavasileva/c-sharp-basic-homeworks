using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Service;

namespace WebApi.Models
{
    public class User
    {
        public User()
        {
            Id = GenerateId.GenerateUserId(this);
            AllUsers.Add(this);
        }
        public int Id { get; internal set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<User> Friends { get; set; }
        public static List<User> AllUsers { get; set; } = new List<User>();

        public int GetUserId()
        {
            return Id;
        }
    }
}
