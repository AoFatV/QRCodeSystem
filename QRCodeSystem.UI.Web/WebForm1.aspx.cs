using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QRCodeSystem.DataAccess;
using QRCodeSystem.BusinessLogic;

namespace QRCodeSystem.UI.Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                BLRoles roles = new BLRoles();

                DataSet ds = roles.GetRoles("123");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}