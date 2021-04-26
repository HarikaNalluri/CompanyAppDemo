using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Data
{
    [NotMapped]
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public string ProfileImage { get; set; }
        public string FbprofileLink { get; set; }
        public string TwitterProfileLink { get; set; }
        public string DepartmentName { get; set; }
        public string SubDepartmentName { get; set; }
    }
}
