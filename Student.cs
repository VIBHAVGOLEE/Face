using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataBase
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Mobile { get; set; }
        public int SchoolID { get; set; }
        public int RoleID { get; set; }
        public int RollNumber { get; set; }
        public string Gender { get; set; }
        public string? ParentName { get; set; }
        public string? ParentMobile { get; set; }
        public string? ParentEmail { get; set; }
        public int SyncedID { get; set; }
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
