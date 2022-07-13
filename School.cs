using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataBase
{
    public class School
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        public string Email { get; set; }
        public string? Mobile { get; set; }
        public string? Address { get; set; }
        public string SchoolCode { get; set; }
        public string ProjectCode { get; set; }
        public int City { get; set; }
        public int State { get; set; }
        public int PinCode { get; set; }
        public int AddedBy { get; set; }
        public DateTime AddedOn { get; set; }
        public DateTime SyncedOn { get; set; }

    }
}
