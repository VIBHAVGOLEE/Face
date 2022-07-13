using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataBase
{
    public class SchoolClassSections
    {
        [Key]
        public int ID { get; set; }
        public int SchoolClassID { get; set; }
        public string Sections { get; set; }
        public int AddedBy { get; set; }
        public DateTime AddedOn { get; set; }
        public DateTime SynedOn { get; set; }
        public bool IsActive { get; set; }
    }
}
