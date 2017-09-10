using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration.UserSecrets;
using SpectrumDemoRadcliffe.Models;

namespace SpectrumDemoRadcliffe.Data
{
    public class DbInitializer
    {
        public static void Initialize(FileContext context)
        {
            context.Database.EnsureCreated();

            // Returns due to already existent DB
            if (context.Persons.Any())
            {
                return;
            }

            // Create mock people for DB
            var persons = new Person[]
            {
                new Person {FirstName = "Jacob", LastName = "Radcliffe"},
                new Person {FirstName = "Theo", LastName = "Radcliffe"},
                new Person {FirstName = "Erin", LastName = "Radcliffe"}
            };
            foreach (Person p in persons)
            {
                context.Persons.Add(p);
            }
            context.SaveChanges();

            // All passwords SHA256 encrypted over string "password"
            var users = new User[]
            {
                new User{PersonId = 1, Email = "jacob@gmail.com", Password = "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8"},
                new User{PersonId = 2, Email = "theo@gmail.com", Password = "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8"},
                new User{PersonId = 3, Email = "erin@gmail.com", Password = "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8"}
            };
            foreach(User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();
        }
    }
}
