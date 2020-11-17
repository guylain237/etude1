using System.Collections;
using System.Collections.Generic;

namespace etude1
{
    public interface IUserrepository
    {
       void ADD(User user);
        IEnumerable<User> getall();
    }
}