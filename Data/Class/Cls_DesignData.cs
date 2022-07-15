using Microsoft.Extensions.Configuration;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataService_Layer.Data
{
  public partial class DesignData
  {
    SqlDataReader _Reader = null;
    SqlConnection con = null;

    public DesignData(IConfiguration config)
    {
      string conString = config.GetConnectionString("cn1");
      con = new SqlConnection(conString);
    }



    #region GetAllDesignation
    public List<Designations> GetAllDesigns()
    {
      List<Designations> designations = new List<Designations>();

      try
      {

        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "SelectAllDesign";
        cmd.Connection = con;
        con.Open();
        SqlDataReader _Reader = cmd.ExecuteReader();

        while (_Reader.Read())
        {
          Designations desg = new Designations();
          desg.Design_Id = (int)_Reader["Design_Id"];
          desg.Designation_Name = _Reader["Designation_Name"].ToString();

          designations.Add(desg);
        }
      }

      catch (Exception ex)
      {
        throw ex;
      }

      finally
      {
        //_Reader.Close();
        if (con.State == ConnectionState.Open)
          con.Close();
      }

      return designations;
    }
    #endregion



  }
}
