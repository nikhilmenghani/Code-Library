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
        Write w = new Write(@"D:\nikhil\e1.txt");
        w.WriteStringToFile("Hello");
        w.AppendStringToFile(" Nikhil");
        Read r = new Read(@"D:\nikhil\e1.txt");
        r.getStringFromFile();
    }
}