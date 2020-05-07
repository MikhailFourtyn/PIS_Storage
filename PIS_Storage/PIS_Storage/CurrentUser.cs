using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS_Storage
{
    class CurrentUser
    {
        private static User _user;
        public CurrentUser(User user)
        {
            _user = user;
        }
        public static void Set(User user) 
        { 
            CurrentUser._user = user; 
        }
        public static User Get() 
        { 
            return _user; 
        }
    }
}
