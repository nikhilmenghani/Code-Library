using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Write w = new Write(@"H:\nikhil\e1.txt");
        w.WriteStringToFile("Hello");
        //Write w = new Write(@"H:\e1.xml");
    }
}