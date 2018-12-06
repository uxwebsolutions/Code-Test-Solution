using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APITest;
using APITest.BusinessLogic;

namespace MVC.Models
{
    public class UserModel
    {
        public User user { get; set; }

        public UserModel() {
            user = new User();
            UserLogic logic = new UserLogic();
            user = logic.GetUser();

            }

    }
}