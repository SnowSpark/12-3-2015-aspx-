using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for ConnectionDataBase
/// This class for Handling DataBaseConnection 
/// </summary>
public class ConnectionDataBase
{
    //Variables
    string connString ;
 // string connString2 ;
    SqlConnection conn ;
    SqlCommand cmd ;
    DataTable tbl ;



    //================================================================================
    //=================================Constructor====================================
    //================================================================================
    //constructor to intialaize the variables
	public ConnectionDataBase()
	{
        connString = ConfigurationManager.ConnectionStrings["LabConnStr"].ConnectionString;
//connString = ConfigurationManager.ConnectionStrings["3armyDataConnStr"].ConnectionString;
        conn = null;
        cmd= new SqlCommand();
        tbl = new DataTable();
	}

    //================================================================================
    //=================================OpenDataBase===================================
    //================================================================================
    //function to open the database
    public void openDataBase()
    {
        try
        {
            conn = new SqlConnection(connString);
            conn.Open();

        }
        catch (Exception ex)
        {
            //log error 
            //display friendly error to user

        }
    }
    /*
 public void openarmyDataBase()
    {
        try
        {
            conn = new SqlConnection(connString2);
            conn.Open();
          
        }
        catch (Exception ex)
        {
            //log error 
            //display friendly error to user
          
        }


    }*/
    
    //================================================================================
    //=================================CloseDataBase==================================
    //================================================================================
    //function to close the database
    public void closeDataBase()
    {
        if (conn != null)
        {
            conn.Close();
        }
    }

    //================================================================================
    //=================================InsertToDataBase===============================
    //================================================================================
    //function to insert into table in the database
    public void insertIntoDataBase(String query)
    {
        try
        {
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            //log error 
            //display friendly error to user
        }
    }

    //================================================================================
    //=================================SelectFromDataBase=============================
    //================================================================================
    //function to Select From database & Save in dataTable
    public DataTable SelectFromDataBase(String query)
    {
        try
        {
            cmd.Connection = conn;
            cmd.CommandText = query;
            //cmd.CommandType = System.Data.CommandType.Text;
            tbl = new DataTable();
            tbl.Load(cmd.ExecuteReader());
        }
        catch (Exception ex)
        {
            //log error 
            //display friendly error to user
        }

        return tbl;
    }

    //================================================================================
    //=================================UpdateFromDataBase=============================
    //================================================================================
    //function to Update records From database
    public void UpdateIntoDataBase(String query)
    {
        try
        {
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            //log error 
            //display friendly error to user
        }
    }
 /*   public DataTable serach(string pb_areaid, string pb_DepID, string pb_tpId ,string pb_name, string filed )
    {
        try
        {
            string q = ("SELECT phoneBook.pb_areaID, phoneBook.pb_depID, phoneBook.pb_tpID,phoneBook.pb_job, phoneBook.pb_rankID, phoneBook.pb_name, phoneBook.pb_central, phoneBook.pb_strategy, phoneBook.pb_cdm, phoneBook.pb_intercom, phoneBook.pb_fax, phoneBook.pb_mob, phoneBook.pb_sorya, departments.dep_name, areas.area_name, troops.tp_name FROM phoneBook LEFT JOIN departments ON phoneBook.pb_depID = departments.dep_id LEFT JOIN areas ON phoneBook.pb_areaID = areas.area_id LEFT JOIN troops ON phoneBook.pb_tpID = troops.tp_id where ");

            
                if (pb_areaid != "-1")
                {
                    q = q + (" pb_areaID ='" + pb_areaid + "'  ");
                    
                    if (pb_DepID != "-1")
                {
                    q = q + (" and pb_depID ='" + pb_DepID + "' ");
                        if (pb_tpId != "-1")
                {
                    q = q + (" and pb_tpID ='" + pb_tpId + "'  ");
                }//3
                }//2
                }//1

                else if (pb_name != "")
                {
                    q = q +(string.Format(" {0} like '%{1}%'",filed ,pb_name));
                }
            
       
            cmd.Connection = conn;
            cmd.CommandText = q;
            tbl = new DataTable();
            tbl.Load(cmd.ExecuteReader());
        }
        catch (Exception ex)
        {
            //log error 
            //display friendly error to user
        }
      
        return tbl;
    }*/
 
}