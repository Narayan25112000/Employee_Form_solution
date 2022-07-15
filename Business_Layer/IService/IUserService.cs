using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.IService
{
  public interface IUserService
  {
    List<Employee> GetAllEmployee();
    List<Employee> GetEmployee(int Id);
    void CreateEmployee(Employee employee);
    void UpdateEmployee(Employee employee, int Id);
    void DeleteEmployee(int Id);
  }
}
