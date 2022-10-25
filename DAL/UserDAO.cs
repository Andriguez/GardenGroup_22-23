using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace DAL
{
    public class UserDAO : MongoHelper
    {
        public User GetUser()
        {
            return new User()
            {
                Id = 0,
                Name = "",
                Password = "",
                Email = "",
                Phone = 0,
                UserType = 0,
                Location = 0,
            };
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            var document = GetListOfDocumets("User");

            foreach (var info in document)
            {
                int Id = int.Parse(info["ID"]);
                string Email = info["Email"].ToString();
                User u = new User();
                users.Add(u);
            }

                return users;
        }
    }
}

