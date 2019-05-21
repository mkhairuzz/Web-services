using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebServices.Models
{
    public class MasterUser
    {
        [Key] 
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(12)]
        public int IC { get; set; }
        [StringLength(200)]
        public string Address { get; set; }
        [StringLength(50)]
        public string State { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        public string Gender { get; set; }


    }
}
