using Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
    public class UserDataMapper
    {
        private UserTDG userTable { get; }

        public UserDataMapper()
        {
            userTable = new UserTDG();
        }
        public User GetUserById(int id)
        {
            var data = userTable.GetUserById(id);
            return Map(data);
        }

        private User Map(DataTable dataTable)
        {
            // DO Mapping column to property
            return new User();
        }
    }
}
