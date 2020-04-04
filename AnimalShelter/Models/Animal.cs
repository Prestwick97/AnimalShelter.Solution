using System;
using System.ComponentModel.DataAnnotations;
namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
 
    public string Name { get; set; }
    [Required]
    [StringLength(1000, ErrorMessage = "stop")]
    public string Info { get; set; }
  }
}

  //  [Required]
  //   [StringLength(25, ErrorMessage = "Don't")]