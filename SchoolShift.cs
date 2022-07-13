using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataBase
{
    public class SchoolShift
    {
        [Key]
        public int ID { get; set; }
        public int SchoolID { get; set; }
        public string ShiftName { get; set; }
        public int Order { get; set; }
        public int AddedBy { get; set; }
        public DateTime AddedOn { get; set; }
        public DateTime SynedOn { get; set; }
        public byte IsActive { get; set; }
    }
}
