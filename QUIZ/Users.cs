using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ
{
    public class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Email { get; set; }
        public string DateOfBirthday { get; set; }

        public Users() { }
    }
}
