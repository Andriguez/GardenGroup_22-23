using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public UserType UserType { get; set; }
        public Location Location { get; set; }

        public User(int id, string name, string email, long phone, int usertype, int location)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            UserType = (UserType)usertype;
            Location = (Location)location;

        }

    }
}
