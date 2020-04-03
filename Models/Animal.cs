using System;
namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }
 
    public string Name { get; set; }
    public string Info { get; set; }
  }
}

  //  [Required]
  //   [StringLength(25, ErrorMessage = "Don't")]