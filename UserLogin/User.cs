using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {
        private String name;
        private String pass;
        private String facNum;
        private UserRoles role;

        public String Name { get; set; }
        public String Pass { get; set; }
        public String FacNum { get; set; }
        public UserRoles Role { get; set; }

        public DateTime Created;

        //internal string? facNum;

        public User()
        {
            
        }

    }
}
