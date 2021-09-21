using System.ComponentModel.DataAnnotations;


namespace ASU_IS_19_03.DB.Model
{
    public class Printer
    {
        [Key]
        public int PrinterId { get; set; }
        public string Name { get; set; }


        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }

        public int TypePrinterId { get; set; }

        public virtual TypePrinter TypePrinter { get; set; }


    }
}
