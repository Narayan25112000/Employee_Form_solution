using DataService_Layer.IData;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService_Layer.Data
{
  public partial class DesignData : IDesignData
  {
    public List<Designations> GetAll()
    {
      List<Designations> list = null;
      list = GetAllDesigns();
      return list;
    }
  }
}
