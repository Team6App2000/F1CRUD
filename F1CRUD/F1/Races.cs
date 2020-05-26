using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace F1CRUD.F1
{
    public class Races
    {
        [Key]
        public string raceName { get; set; }
        [ForeignKey("circuitId")]
        public Circuits circuits { get; set; }
        public string circuitId { get; set; }
        public string url { get; set; }
        public int season { get; set; }
        public string round { get; set; }
        public string date { get; set; }
        public string time { get; set; }
    }
}
