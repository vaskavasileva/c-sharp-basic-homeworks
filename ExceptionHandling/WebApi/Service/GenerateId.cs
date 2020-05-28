using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Models;

namespace WebApi.Service
{
    public class GenerateId
    {
        public static int GenerateUserId(User user)
        {
            while (true)
            {
                user.Id = new Random().Next(0, 1000);
                foreach (var usedId in User.AllUsers)
                {
                    if (user.Id == usedId.Id)
                    {
                        user.Id = new Random().Next(0, 1000);
                    }
                }
                break;
            }
            return user.Id;
        }

        public static int GenerateAdminId(Admin admin)
        {
            while (true)
            {
                admin.Id = new Random().Next(0, 100);
                foreach (var usedId in Admin.AllAdmins)
                {
                    if (admin.Id == usedId.Id)
                    {
                        admin.Id = new Random().Next(0, 100);
                    }
                }
                break;
            }
            return admin.Id;
        }
    }
}
