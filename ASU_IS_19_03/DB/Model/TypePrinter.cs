using System.ComponentModel.DataAnnotations;

namespace ASU_IS_19_03.DB.Model
{
    public class TypePrinter
    {

        [Key]
        public int TypePrinterId { get; set; }
        public string Name { get; set; }
    }
}