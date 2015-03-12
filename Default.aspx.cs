using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        ConnectionDataBase conn = new ConnectionDataBase();
        DataTable tbl  = new DataTable();
        conn.openDataBase();
        tbl = conn.SelectFromDataBase("select * from WebData");
        gp1.InnerHtml = tbl.Rows[0]["txt"].ToString();
        gP2.InnerHtml = tbl.Rows[1]["txt"].ToString();
        gP3.InnerHtml = tbl.Rows[2]["txt"].ToString();
        gP4.InnerHtml = tbl.Rows[0]["txt"].ToString();
        slid2.InnerHtml = tbl.Rows[0]["txt"].ToString();
        sl3.InnerHtml = tbl.Rows[0]["txt"].ToString();
    }
}