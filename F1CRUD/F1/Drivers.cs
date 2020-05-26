using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace F1CRUD.F1
{
    public class Drivers
    {
        [Key]
        public string driverId { get; set; }
        public string url { get; set; }
        public string givenName { get; set; }
        public string familyName { get; set; }
        public string dateOfBirth { get; set; }
        public string nationality { get; set; }

    }
}
