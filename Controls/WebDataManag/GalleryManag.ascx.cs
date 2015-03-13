using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Controls_WebDataManag_GalleryManag : System.Web.UI.UserControl
{
    ConnectionDataBase conn = new ConnectionDataBase();
    DataTable tbl = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            conn.openDataBase();
            tbl = conn.SelectFromDataBase("select id , name from WebData");
            conn.closeDataBase();

            DataRow r = tbl.NewRow();
            r["id"] = -1;
            r["name"] = "اختار";
            tbl.Rows.InsertAt(r, 0);
            DDLName.DataSource = tbl;
            DDLName.DataTextField = "name";
            DDLName.DataValueField = "id";
            DDLName.DataBind();
        }



    }

    protected void DDLName_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        if (DDLName.SelectedValue == "-1")
        {
            dataName.Text = "اختار من القائمة";

        }
        else
        {
            DataTable ss = new DataTable();
            conn.openDataBase();
          ss = conn.SelectFromDataBase("select txt from  WebData Where  id  like '"+DDLName.SelectedValue+"'");
            conn.closeDataBase();
            txtData.Text = ss.Rows[0]["txt"].ToString();

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DDLName.SelectedValue == "-1")
        {
            dataName.Text = "اختار من القائمة";

        }
        else
        {
            conn.openDataBase();
            conn.UpdateIntoDataBase("update WebData Set txt = '" + txtData.Text + "' where id like '" + DDLName.SelectedValue + "'");
            conn.closeDataBase();
            dataName.Text = "تم تعديل البيانات";

        }
    }
}