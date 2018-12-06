using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITest.BusinessLogic
{
    public class UserLogic
    {

        /// <summary>
        ///Get a Test User Object
        /// </summary>
        /// <remarks>
        /// The implementation can use a Database or web service
        /// </remarks>
        public User GetUser()
        {
            User user = new User();
            user.Name = "Test User";
            user.EmailAddress = "test@123.com";
            user.UserRole = new Role();
            user.UserRole.Name = "Administrator";
            return user;


        }

        /// <summary>
        ///Get a list of Roles
        /// </summary>
        /// <remarks>
        /// The implementation can use a Database or web service
        /// </remarks>
        public List<Role> GetRoles()
        {
            List<Role> roles = new List<Role>();
            Role role = new Role();
            role.Name = "Administrator";
            roles.Add(role);
            role = new Role();
            role.Name = "User";
            roles.Add(role);
            role = new Role();
            role.Name = "Manager";
            roles.Add(role);

            return roles;

        }

        /// <summary>
        /// Checks if a User is Active
        /// </summary>
        /// <remarks>
        /// The implementation can use a Database or web service
        /// </remarks>
        public bool IsUserActive(int UserId)
        {

            return UserId < 1 ? true: false;
        }

    }
    
}
