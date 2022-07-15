using Business_Layer.IService;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employee_Form.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DesignationController : ControllerBase
  {
    private readonly IDesignService dsgservice;

    public DesignationController(IDesignService dsgservice)
    {
      this.dsgservice = dsgservice;
    }


    // GET: api/<DesignationController>
    [HttpGet]
    public IEnumerable<Designations> Get()
    {
      List<Designations> designations = dsgservice.GetAllDsg();
      return designations;
    }

    // GET api/<DesignationController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "value";
    }

    // POST api/<DesignationController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<DesignationController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<DesignationController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
