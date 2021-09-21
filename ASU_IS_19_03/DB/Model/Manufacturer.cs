using System.ComponentModel.DataAnnotations;

namespace ASU_IS_19_03.DB.Model
{
    public class Manufacturer
    {
        [Key]
        public int ManufacturerId { get; set; }
        public string Name { get; set; }
      
    }
}