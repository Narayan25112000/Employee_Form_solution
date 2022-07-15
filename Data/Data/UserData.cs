using Data.IData;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Data
{
  public partial class UserData: IUserData
  {
   
    public List<Employee> GetAll()
    {
      List<Employee> employees = null;
      employees = GetAllEmps();
      return employees;
    }

    public List<Employee> GetId(int Id)
    {
      List<Employee> emp = null;
      emp = GetEmpById(Id);
      return emp;
    }


    public void CreateEmps(Employee emp)
    {
      Create_Employee(emp);
    }


    public void UpdateEmps(Employee emp, int Id)
    {
      Update_Employee(emp, Id);
    }

    public void DeleteEmps(int Id)
    {
      DeleteEmp(Id);
    }


  }
}
