using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using APITest;
using APITest.BusinessLogic;

namespace Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if(!Page.IsPostBack)
            {
                LoadUser();
            }
        }

        protected void LoadUser()
        {
            UserLogic logic = new UserLogic();
            var user = logic.GetUser().Name;
            var role = logic.GetUser().UserRole.Name;
            LtMessage.Text = user;
            LtMessage.Text += "<br>" + role;


        }
    }
}