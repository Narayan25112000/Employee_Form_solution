using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public class Department
  {
    [Key]
    public int Dept_Id { get; set; }
    [Required]
    public string DeptName { get; set; }
  }
}
