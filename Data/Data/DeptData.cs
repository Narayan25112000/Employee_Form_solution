using DataService_Layer.IData;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService_Layer.Data
{
  public partial class DeptData : IDeptData
  {
    public List<Department> GetAllDptData()
    {
      List<Department> deptList = new List<Department>();
      deptList = GetAllDepts();
      return deptList;
    }
  }
}
