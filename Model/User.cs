using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        string idUser, usernom, password;

        public string IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }

        public string Usernom
        {
            get { return usernom; }
            set { usernom = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
