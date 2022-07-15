using Business_Layer.IService;
using DataService_Layer.IData;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Service
{
  public class DesignService : IDesignService
  {
    private readonly IDesignData _dsgData;
    public DesignService(IDesignData dsgdata)
    {
      _dsgData = dsgdata;
    }

    public List<Designations> GetAllDsg()
    {
      List<Designations> list = new List<Designations>();
      list = _dsgData.GetAll();
      return list;
    }
  }
}
