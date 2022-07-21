using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AW_FullStack_W6D4_Aspi_Testi.Models
{
    public class Topic
    {
        public int ID { get; set; }

        public string Description { get; set; }

        public DateTime? StartTime { get; set; }

        public string Source { get; set; }
    }
}
