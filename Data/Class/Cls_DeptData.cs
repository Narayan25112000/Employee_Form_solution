using Microsoft.Extensions.Configuration;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataService_Layer.Data
{
  public partial class DeptData
  {
    SqlDataReader _Reader = null;
    SqlConnection con = null;

    public DeptData(IConfiguration config)
    {
      string conString = config.GetConnectionString("cn1");
      con = new SqlConnection(conString);
    }


    #region GetAllDept
    public List<Department> GetAllDepts()
    {
      List<Department> departments = new List<Department>();

      try
      {

        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "SelectAllDepts";
        cmd.Connection = con;
        con.Open();
        SqlDataReader _Reader = cmd.ExecuteReader();

        while (_Reader.Read())
        {
          Department deps = new Department();
          deps.Dept_Id = (int)_Reader["Dept_Id"];
          deps.DeptName = _Reader["DeptName"].ToString();
          
          departments.Add(deps);
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

      return departments;
    }
    #endregion

  }
}
