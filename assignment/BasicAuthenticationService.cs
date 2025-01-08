using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public bool Authenticate(string username, string password)
        {
            if(username == null || password == null) return false;

            if (username == "Mohamed" && password == "##########")
            {
                return true;
            }
            else
                return false;
        }

        public bool AuthorizeUser(string role)
        {
            if (role == null) return false;
            else if (role == "Admin")
            {
                return true;
            }
            else
                return false ;
        }
    }
}
