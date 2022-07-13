using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataBase
{
    public class StudentClassSections
    {
        [Key]
        public int ID { get; set; }
        public int StudentID { get; set; }
        public int SchoolClassSec { get; set; }
        public DateTime SyncedId { get; set; }
        public int AddedBy { get; set; }
        public DateTime AddedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public byte IsActive { get; set; }
        public byte IsSynced { get; set; }
        public DateTime? SyncedOn { get; set; }
    }
}
