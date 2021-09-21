using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASU_IS_19_03.DB.Model
{
    public class PrinterSklad
    {
        public int PrinterSkladId { get; set; }

        public int Count { get; set; }

        public DateTime Date_of_operation { get; set; }

        /// <summary>
        /// false - списание , true - поступление
        /// </summary>
        public bool Operation { get; set; }


        public int PrinterId { get; set; }
        public virtual Printer Printer { get; set; }

        public int SkladId { get; set; }
        public virtual Sklad Sklad { get; set; }



    }

}
