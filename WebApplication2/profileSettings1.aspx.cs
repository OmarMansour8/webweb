using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class profileSettings1 : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string username = "";
            string lName = "";

            if (Request.Cookies["userInfo"] != null)
            {
                username = Request.Cookies["userInfo"].Values["usern"];
                lName = Request.Cookies["userInfo"].Values["lName"];



            }



            if (fupPic.HasFile) {
                fupPic.SaveAs(Server.MapPath("userPic") + "\\" + username + "jpg");
                imgUserPic.ImageUrl = "~/userPic/" + username + ".jgp";
        }
        }
            
    }
}