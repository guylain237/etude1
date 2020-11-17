using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etude1
{
    class user4repositorymemory : IUserrepository
    {
        private static List<User> users;
        public user4repositorymemory()
        {
            if (users == null)
                users = new List<User>
                {
                    new User("tata", "1021021", "bienvenue")

                };
        }
        public void ADD(User user)
        {
            users.Add(user);
        }

        public IEnumerable<User> getall()
        {
            return users;
        }
    }
}

