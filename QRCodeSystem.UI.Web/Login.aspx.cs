using System;
using System.Web.Security;
using QRCodeSystem.BusinessLogic;
using QRCodeSystem.DataAccess.Models;

namespace QRCodeSystem.UI.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //FormsAuthentication.SetAuthCookie("chowalit", false);
                //Response.Redirect("Home/Index.aspx");
            }
        }

        protected void btnLogin_ServerClick(object sender, EventArgs e)
        {
            BLUser blUser = new BLUser();
            //User users = new User();
            try
            {
                var users = blUser.GetUser(txtUserName.Value);
                //if (users.UserId == 0)
                //{
                //    //Invalid User
                //}
                //else
                //{
                //    FormsAuthentication.SetAuthCookie(txtUserName.Value, false);
                //    Response.Redirect("Home/Index.aspx");
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}