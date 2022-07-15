using Business_Layer.IService;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employee_Form.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DepartmentController : ControllerBase
  {
    private readonly IDeptService _dptservice;

    public DepartmentController(IDeptService deptService)
    {
      _dptservice = deptService;
    }
    // GET: api/<DepartmentController>
    [HttpGet]
    public IEnumerable<Department> Get()
    {
      List<Department> departmentList = _dptservice.GetAllDep();
      return departmentList;
    }

    // GET api/<DepartmentController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "value";
    }

    // POST api/<DepartmentController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<DepartmentController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<DepartmentController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
