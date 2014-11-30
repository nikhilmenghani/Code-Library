using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using database_connectiom;
using System.Data;
using System.Data.SqlClient;

public partial class Home : System.Web.UI.Page
{
    DBConnect dbc = new DBConnect();
    protected void Page_Load(object sender, EventArgs e)
    {
        //Write w = new Write(@"D:\nikhil\e1.txt");
        //w.WriteStringToFile("Hello");
        //w.AppendStringToFile(" Nikhil");
        //Read r = new Read(@"D:\nikhil\e1.txt");
        //r.getStringFromFile();
        //WriteXML wx = new WriteXML(@"D:\nikhil\e2.xml");
        //wx.Initialize();
        //wx.CreateRootElement("Root");
        //wx.CreateNode("Parent");
        //wx.createElement("Element1", "Value1");
        //wx.createElement("Element2", "Value2");
        //wx.EndNode();
        //wx.EndRootElement();
        //wx.Terminate();

        //ReadXML rx = new ReadXML(@"D:\nikhil\e2.xml");
        //rx.readXml();
        //rx.readXmlDoc();
    }
    protected void btnGridDisplay_Click(object sender, EventArgs e)
    {
        string qry = "select * from emp";
        //dbc.executeIUD("insert into emp values (4, 'Ruhita', 20000, 2)");
        //DataTable dt = dbc.executeSelectQueryWithDT(qry);
        //SqlDataReader dr = dbc.executeSelectQueryWithDR(qry);
        DataSet ds = new DataSet();
        ds = dbc.executeSelectQueryWithDS(qry);
        //DG1.AutoGenerateColumns = true;
        GV1.DataSource = ds.Tables[0];
        GV1.DataBind();
        DG1.DataSource = ds.Tables[0];
        DG1.DataBind();
        //Persist.print = "<br />Success!";
    }
}