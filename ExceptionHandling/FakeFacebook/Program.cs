using FakeFacebook.Logger;
using System;
using WebApi.Exceptions;
using WebApi.Service;

namespace FakeFacebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var allUsers = UserService.GetAllUsers();
            
            try
            {
                var userByID = UserService.GetUserById(4);
                Console.WriteLine(userByID.FirstName);
                var usersFriends = UserService.GetAllUsersFriends(null);
                foreach (var user in usersFriends)
                {
                    Console.WriteLine(user.FirstName);
                }
                
            }
            catch (UserServiceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                var logger = new UserExceptionsLogger();
                logger.LogException(ex);
                Console.WriteLine(ex.Message);
            }

            var allAdmins = AdminService.GetAllAdmins();

            try
            {
                var adminId = AdminService.GetAdminId("Ron");
                Console.WriteLine(adminId);
                var adminHelpers = AdminService.GetAllAdminHelpers(null);
                foreach (var admin in adminHelpers)
                {
                    Console.WriteLine(admin.FirstName);
                }
                
            }
            catch (AdminServiceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                var logger = new UserExceptionsLogger();
                logger.LogException(ex);
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
