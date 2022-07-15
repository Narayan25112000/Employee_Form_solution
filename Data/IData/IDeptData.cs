using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService_Layer.IData
{
  public interface IDeptData
  {
    List<Department> GetAllDptData();
  }
}
