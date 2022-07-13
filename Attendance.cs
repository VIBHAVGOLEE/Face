using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Attendance
    {
        [Key]
        public int ID { get; set; }
        public int StudentID { get; set; }
        public int SchoolShiftID { get; set; }
        public int SchoolID { get; set; }
        public int SyencedID { get; set; }
        public bool IsPresent { get; set; }
        public int AddedBy { get; set; }
        public DateTime AddedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public bool IsActive { get; set; }
        public bool IsSynced { get; set; }
        public DateTime? SyncedOn { get; set; }
    }
}
