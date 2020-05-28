using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Service;

namespace WebApi.Models
{
    public class Admin
    {
        public Admin()
        {
            Id = GenerateId.GenerateAdminId(this);
            AllAdmins.Add(this);
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; internal set; }
        public static List<Admin> AllAdmins { get; set; } = new List<Admin>();
        public List<Admin> AdminHelpers { get; set; };

        public int GetAdminId()
        {
            return Id;
        }
    }
}
