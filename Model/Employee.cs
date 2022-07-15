using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
  public class Employee
  {
    [Key]
    public int Id { get; set; }
    [Required]
    public string First_Name { get; set; }
    public string Middle_Name { get; set; }
    [Required]
    public string Last_Name { get; set; }
    [Required]
    public string Hobbies { get; set; }
    [Required]
    public int Gender { get; set; }
    [Required]
    public int Salary { get; set; }
    [Required]
    public DateTime DOB { get; set; }
    [Required]
    public int Dept_Id { get; set; }
    [Required]
    public string DeptName { get; set; }
    [Required]
    public int Design_Id { get; set; }
    [Required]
    public string Designation_Name { get; set; }

  }
}
