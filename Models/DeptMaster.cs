using System.ComponentModel.DataAnnotations;

namespace WebAPIProject1.Models
{
    public class DeptMaster
    {
        [Key]
        public int DeptCode { get; set; }
        public string DeptName { get; set; }
        public virtual ICollection<EmpProfile> EmpProfiles { get; set; }
    }
    public class EmpProfile
    {
        [Key]
        public int EmpCode { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }
        public int DeptCode { get; set; }
        
    }
}
