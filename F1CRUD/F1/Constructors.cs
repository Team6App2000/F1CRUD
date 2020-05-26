using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace F1CRUD.F1
{
    public class Constructors
    {
        [Key]
        public string constructorsId { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public string nationality { get; set; }
    }
}
