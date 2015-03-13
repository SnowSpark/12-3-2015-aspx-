using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for validation
/// </summary>
public class c4validation
{

    public void chk( string page)
    {

        try
        {
         
            if ( HttpContext.Current.Session["userName"] == null)
            {
                 HttpContext.Current.Response.Redirect("login.aspx");
            }
            else
            { 
                 string s =  HttpContext.Current.Session["rank"].ToString();
                switch (page) 
                {
                    case "archiv" :
                        
                if ( s== "a") 
                {

                }
                else
                {
                    if (s == "m")
                    {

                    }
                    else
                    {
                        if (s == "im")
                        {
                        }
                        else
                        {
                            if (s == "ms")
                            { }
                            else
                            {
                                if (s == "full")
                                { }
                                else
                                { HttpContext.Current.Response.Redirect("erorr.aspx"); }
                            }
                        }

                    }
                 
                }
                        break;
                    case "admin":
                        if (s != "a" )
                        {

                            HttpContext.Current.Response.Redirect("erorr.aspx");
                        }
                        else
                        {

                        }
                        break;
                    case "mint":
                        if (s == "a")
                        {

                        }
                        else
                        {
                            if (s == "s")
                            {

                            }
                            else
                            {
                                if (s == "is")
                                {
                                }
                                else
                                {
                                    if (s == "ms")
                                    { }
                                    else
                                    {
                                        if (s == "full")
                                        { }
                                        else
                                        { HttpContext.Current.Response.Redirect("erorr.aspx"); }
                                    }
                                }

                            }
                            
                        }
                      
                        break; 
                          case "invin":
                        if (s == "a")
                        {

                        }
                        else
                        {
                            if (s == "i")
                            {

                            }
                            else
                            {
                                if (s == "im")
                                {
                                }
                                else
                                {
                                    if (s == "is")
                                    { }
                                    else
                                    {
                                        if (s == "full")
                                        { }
                                        else
                                        { HttpContext.Current.Response.Redirect("erorr.aspx"); }
                                    }
                                }

                            }
                         
                        }
                        break; 


                }
              

                }


            }

        
        catch { }
        


    }
}