using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace F1CRUD.F1
{
    public class Circuits
    {
        [Key]
        public string circuitId { get; set; }
        public string url { get; set; }
        public string circuitName { get; set; }
        public string location { get; set; }
        public string country { get; set; }
    }
}
