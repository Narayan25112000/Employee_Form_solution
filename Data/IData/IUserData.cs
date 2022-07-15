using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.IData
{
  public interface IUserData
  {
    List<Employee> GetAll();
   List<Employee> GetId(int Id);

    void CreateEmps(Employee emp);
    void UpdateEmps(Employee emp, int Id);
    void DeleteEmps(int Id);
  }
}
