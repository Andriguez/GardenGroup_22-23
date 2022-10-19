using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        int Id { get; set; }
        string Name { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        int Phone { get; set; }
        string UserType { get; set; }
        string Location { get; set; }

    }
}
