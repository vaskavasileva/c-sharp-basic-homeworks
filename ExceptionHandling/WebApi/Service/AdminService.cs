using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Fake_Database;
using WebApi.Models;
using System.Linq;
using WebApi.Exceptions;

namespace WebApi.Service
{
    public class AdminService
    {
        public static List<Admin> GetAllAdmins()
        {
            return DB.Admins;
        }
        public static int GetAdminId(string name)
        {
            Admin admin = DB.Admins.Single(admin => admin.FirstName == name);
            return admin.Id;
        }
        public static List<Admin> GetAllAdminHelpers(Admin findAdmin)
        {
            try
            {
                var allAdminHelpers = DB.Admins.Single(admin => admin.Equals(findAdmin));
                if (findAdmin == null)
                {
                    throw new AdminServiceException("You send me a null", new Exception());
                }

                return allAdminHelpers.AdminHelpers;
            }

            catch (Exception ex)
            {

                throw new Exception();
            }

        }
    }
}
