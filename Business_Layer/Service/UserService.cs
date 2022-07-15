using Business_Layer.IService;
using Data.IData;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Service
{
  public class UserService : IUserService
  {

    private readonly IUserData _userData;

    public UserService(IUserData userData)
    {
      _userData = userData;
    }

    public List<Employee> GetAllEmployee()
    {
      List<Employee> employees = new List<Employee>();
      employees = _userData.GetAll();
      return employees;
    }

    public List<Employee> GetEmployee(int Id)
    {
      List<Employee> emps = new List<Employee>();
      emps = _userData.GetId(Id);
      return emps;
    }

    public void CreateEmployee(Employee emp)
    {
      _userData.CreateEmps(emp);
    }

    public void DeleteEmployee(int Id)
    {
      _userData.DeleteEmps(Id);
    }

    public void UpdateEmployee(Employee emp, int Id)
    {
      _userData.UpdateEmps(emp,Id);
    }


  }
}
