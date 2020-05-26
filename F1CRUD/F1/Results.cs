using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace F1CRUD.F1
{
    public class Results
    {
        [Key]
        public int resultId { get; set; }
        [ForeignKey("constructorId")]
        public Constructors Constructors { get; set; }
        public string constructorId { get; set; }
        [ForeignKey("raceName")]
        public Races Races { get; set; }
        public string raceName { get; set; }
        [ForeignKey("circuitId")]
        public Circuits circuits { get; set; }
        public string circuitId { get; set; }
        [ForeignKey("driverId")]
        public Drivers Drivers { get; set; }
        public string driverId { get; set; }
        public int number { get; set; }
        public int position { get; set; }
        public int points { get; set; }
        public int grid { get; set; }
        public int laps { get; set; }
        public string status { get; set; }


    }
}
