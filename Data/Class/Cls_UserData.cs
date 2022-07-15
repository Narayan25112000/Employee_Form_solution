using Microsoft.Extensions.Configuration;
using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Data.Data
{
  public partial class UserData
  {
    SqlDataReader _Reader = null;
    SqlConnection con = null;

    public UserData(IConfiguration config)
    {
      string conString = config.GetConnectionString("cn1");
      con = new SqlConnection(conString);

    }

    #region GetAllEmps
    public List<Employee> GetAllEmps()
    {
      List<Employee> employees = new List<Employee>();

      try
      {

        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "SelectAllEmps";
        cmd.Connection = con;
        con.Open();
        SqlDataReader _Reader = cmd.ExecuteReader();

        while (_Reader.Read())
        {
          Employee emps = new Employee();
          emps.Id = (int)_Reader["Id"];
          emps.First_Name = _Reader["First_Name"].ToString();
          emps.Middle_Name = _Reader["Middle_Name"].ToString();
          emps.Last_Name = _Reader["Last_Name"].ToString();
          emps.Hobbies = _Reader["Hobbies"].ToString();
          emps.Gender = (int)_Reader["Gender"];
          emps.Salary = (int)_Reader["Salary"];
          emps.DOB = (DateTime)_Reader["DOB"];
          emps.DeptName = _Reader["DeptName"].ToString();
          emps.Designation_Name = _Reader["Designation_Name"].ToString();

          employees.Add(emps);
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

      return employees;
    }
    #endregion


    #region GetById
    public List<Employee> GetEmpById(int Id)
    {
      List<Employee> employees = new List<Employee>();

      try
      {

        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "GetById_Emp";
        cmd.Connection = con;
        cmd.Parameters.AddWithValue("@Id", Id);
        con.Open();
        SqlDataReader _Reader = cmd.ExecuteReader();

        while (_Reader.Read())
        {
          Employee emps = new Employee();
          emps.Id = (int)_Reader["Id"];
          emps.First_Name = _Reader["First_Name"].ToString();
          emps.Middle_Name = _Reader["Middle_Name"].ToString();
          emps.Last_Name = _Reader["Last_Name"].ToString();
          emps.Hobbies = _Reader["Hobbies"].ToString();
          emps.Gender = (int)_Reader["Gender"];
          emps.Salary = (int)_Reader["Salary"];
          emps.DOB = (DateTime)_Reader["DOB"];
          emps.DeptName = _Reader["DeptName"].ToString();
          emps.Designation_Name = _Reader["Designation_Name"].ToString();

          employees.Add(emps);
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

      return employees;
    }


    #endregion


    #region CreateEmp
    public void Create_Employee(Employee emp)
    {
      con.Open();


      try
      {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;



        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Create_Emps";
        cmd.Parameters.AddWithValue("@First_Name", emp.First_Name);
        cmd.Parameters.AddWithValue("@Middle_Name", emp.Middle_Name);
        cmd.Parameters.AddWithValue("@Last_Name", emp.Last_Name);
        cmd.Parameters.AddWithValue("@Hobbies", emp.Hobbies);
        cmd.Parameters.AddWithValue("@Gender", emp.Gender);
        cmd.Parameters.AddWithValue("@Salary", emp.Salary);
        cmd.Parameters.AddWithValue("@DOB", emp.DOB);
        cmd.Parameters.AddWithValue("@Dept_Id", emp.Dept_Id);
        cmd.Parameters.AddWithValue("@Design_Id", emp.Design_Id);

        cmd.ExecuteNonQuery();

      }
      catch (Exception ex)
      {
        Console.WriteLine("OOPs, something went wrong.\n" + ex);
      }

      finally
      {
        if (con != null)
        {
          if (con.State == ConnectionState.Open)
          {
            con.Close();
            con.Dispose();
          }
        }
      }
    }
    #endregion


    #region DeleteEmp
    public void DeleteEmp(int Id)
    {
      //Employee emp = new Employee();
      con.Open();


      try
      {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;


        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Delete_Emps";
        cmd.Parameters.Add(new SqlParameter("@Id", Id));

        cmd.ExecuteNonQuery();

      }
      catch
      {
        throw;
      }
      finally
      {
        if (con != null)
        {
          if (con.State == ConnectionState.Open)
          {
            con.Close();
            con.Dispose();
          }
        }
      }
    }

    #endregion


    #region UpdateEmp
    public void Update_Employee(Employee emp, int Id)
    {
      //con.Open();


      try
      {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;


        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Update_Emps";
        cmd.Parameters.Add(new SqlParameter("@Id", Id));
        //cmd.Parameters.AddWithValue("@Id", emp.Id);
        cmd.Parameters.AddWithValue("@First_Name", emp.First_Name);
        cmd.Parameters.AddWithValue("@Middle_Name", emp.Middle_Name);
        cmd.Parameters.AddWithValue("@Last_Name", emp.Last_Name);
        cmd.Parameters.AddWithValue("@Hobbies", emp.Hobbies);
        cmd.Parameters.AddWithValue("@Gender", emp.Gender);
        cmd.Parameters.AddWithValue("@Salary", emp.Salary);
        cmd.Parameters.AddWithValue("@DOB", emp.DOB);
        cmd.Parameters.AddWithValue("@Dept_Id", emp.Dept_Id);
        cmd.Parameters.AddWithValue("@Design_Id", emp.Design_Id);
        con.Open();


        cmd.ExecuteNonQuery();
        con.Close();
      }
      catch (Exception ex)
      {
        throw ex;
      }

    }


    #endregion




  }
}
