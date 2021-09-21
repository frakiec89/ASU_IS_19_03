using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASU_IS_19_03.DB.Model
{
    public   class Sklad
    {
        [Key] 
        public int  SkladId { get; set; }
        public string Adress { get; set; }

    }
}
