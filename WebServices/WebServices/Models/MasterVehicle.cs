using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebServices.Models
{
    public class MasterVehicle
    {
        [Key] 
        public int Id { get; set; }

        public string VehicleName { get; set; }

        public int EngineCC { get; set; }

        public string Manufacture { get; set; }

        public int YearMake { get; set; }


    }
}
