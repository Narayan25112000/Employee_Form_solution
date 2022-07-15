using Business_Layer.IService;
using Data.Data;
using Data.IData;
using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Demo_Form.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class EmployeesController : ControllerBase
  {
    private IUserService userservice { get; set; }
    public EmployeesController(IUserService userservice)
    {
      this.userservice = userservice;
    }

    //private readonly UserData dataService;
    //public EmployeesController(UserData dataService)
    //{
    //  this.dataService = dataService;
    //}

    [HttpGet]
    public IEnumerable<Employee> Get()
    {
      List<Employee> employees = userservice.GetAllEmployee();
      return employees;
    }

    // GET api/<EmployeesController>/5
    [HttpGet("{id}")]
    public IEnumerable<Employee> Get(int Id)
    {
      List<Employee> emp = userservice.GetEmployee(Id);
      return emp;
    }

    // POST api/<EmployeesController>
    [HttpPost]

    public void Post(Employee emp)
    {

      userservice.CreateEmployee(emp);

    }



    // PUT api/<EmployeesController>/5
    [HttpPut("{id}")]
    public void Put(int Id, Employee emp)
    {
      userservice.UpdateEmployee(emp, Id);
    }

    // DELETE api/<EmployeesController>/5
    [HttpDelete("{id}")]
    public void Delete(int Id)
    {
      userservice.DeleteEmployee(Id);
    }
  }
}
