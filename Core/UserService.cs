using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class UserService
    {
        private UserDataMapper userDataMapper { get; }

        public UserService()
        {
            userDataMapper = new UserDataMapper();
        }

        public User GetById( int id)
        {
            var user = userDataMapper.GetUserById(id);
            return user;
        }
    }
}
