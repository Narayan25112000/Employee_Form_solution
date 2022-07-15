using Business_Layer.IService;
using DataService_Layer.IData;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Service
{
  public class DeptService : IDeptService
  {
    private readonly IDeptData _deptdata;
    public DeptService(IDeptData deptData)
    {
      _deptdata = deptData;
    }

    public List<Department> GetAllDep()
    {
      List<Department> deptList = new List<Department>();
      deptList = _deptdata.GetAllDptData();
      return deptList;
    }
  }
}
