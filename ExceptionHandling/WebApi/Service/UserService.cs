using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.Exceptions;
using WebApi.Fake_Database;
using WebApi.Models;

namespace WebApi.Service
{
    public static class UserService
    {
        public static List<User> GetAllUsers()
        {
            return DB.Users;
        }
        public static User GetUserById(int id)
        {
            User user = DB.Users.Single(user => user.Id == id);
            return user;
        }
        public static List<User> GetAllUsersFriends(User findUser)
        {
            try
            {
                var allUsersFriends = DB.Users.Single(user => user.Equals(findUser));
                if (findUser == null)
                {
                    throw new UserServiceException("You send me a null", new Exception());
                }
                
                return allUsersFriends.Friends;
            }
            
            catch (Exception ex)
            {

                throw new Exception();
            }
            
        }
    }
}
