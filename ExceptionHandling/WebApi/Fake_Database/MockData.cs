using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Models;

namespace WebApi.Fake_Database
{
    internal static class MockData
    {
        internal static List<User> GetMockedUsers()
        {
            User john = new User()
            {
                FirstName = "John",
                LastName = "Doe"
            };
            User bob = new User()
            {
                FirstName = "Bob",
                LastName = "Bobsky"
            };
            User mark = new User()
            {
                FirstName = "Mark",
                LastName = "Dean",
                Friends = new List<User>() { john, bob }
            };
            User harry = new User()
            {
                FirstName = "Harry",
                LastName = "O'Connel",
                Friends = new List<User>() { mark }
            };
            User jina = new User()
            {
                FirstName = "Jina",
                LastName = "Johnson",
                Friends = new List<User>() { harry, bob, john }
            };
            User ben = new User()
            {
                FirstName = "Ben",
                LastName = "Geller"
            };
            User benjamin = new User()
            {
                FirstName = "Benjamin",
                LastName = "Silvester"
            };
            User tony = new User()
            {
                FirstName = "Tony",
                LastName = "Blair",
                Friends = new List<User>() { ben, john, jina }
            };
            User keisha = new User()
            {
                FirstName = "Keisha",
                LastName = "Betford",
                Friends = new List<User>() { tony, benjamin }
            };
            User lisa = new User()
            {
                FirstName = "Lisa",
                LastName = "Anderson",
                Friends = new List<User>() { keisha, bob, mark, tony }
            };
            return new List<User>() { john, bob, harry, mark, jina, ben, benjamin, tony, keisha, lisa };
        }

        internal static List<Admin> GetMockedAdmins()
        {
            Admin ron = new Admin()
            {
                FirstName = "Ron",
                LastName = "Wesley",
                
            };
            Admin ema = new Admin()
            {
                FirstName = "Ema",
                LastName = "Watson",
                AdminHelpers = new List<Admin>() { ron }
                
            };
            Admin dimitri = new Admin()
            {
                FirstName = "Dimitri",
                LastName = "Swanson",
            };
            Admin mat = new Admin()
            {
                FirstName = "Mat",
                LastName = "Jackson",
                AdminHelpers = new List<Admin>() { dimitri, ema, ron }
            };
            Admin meg = new Admin()
            {
                FirstName = "Meg",
                LastName = "Simpson",
                AdminHelpers = new List<Admin>() { mat } 
            };
            return new List<Admin>() { ron, ema, dimitri, mat, meg };
        }
    }
}
