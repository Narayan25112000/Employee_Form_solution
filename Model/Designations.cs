using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public class Designations
  {
    [Key]
    public int Design_Id { get; set; }
    [Required]
    public string Designation_Name { get; set; }
  }
}
