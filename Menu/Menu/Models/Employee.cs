using System;
using System.Collections.Generic;

#nullable disable

namespace Menu.Models
{
    public partial class Employee
    {
        public Employee()
        {
            InverseEmpManagerNavigation = new HashSet<Employee>();
        }

        public string EmpCode { get; set; }
        public string EmpNo { get; set; }
        public string EmpNameAr { get; set; }
        public string EmpNameEn { get; set; }
        public string EmpManager { get; set; }
        public int? EmpReligon { get; set; }
        public string EmpSex { get; set; }
        public string EmpMary { get; set; }
        public string EmpCmpCode { get; set; }
        public int? EmpBrCode { get; set; }
        public int? EmpDptCode { get; set; }
        public int? EmpSecCode { get; set; }
        public int? EmpJobCode { get; set; }
        public int? EmpRankCode { get; set; }
        public DateTime? EmpBirthDate { get; set; }
        public string EmpBirthPlaceId { get; set; }
        public string EmpLnuCode { get; set; }
        public bool? EmpActive { get; set; }
        public string EmpCreatedBy { get; set; }
        public DateTime? EmpCreatedAt { get; set; }
        public string EmpCreatedChanel { get; set; }
        public string EmpUpdateBy { get; set; }
        public DateTime? EmpUpdateAt { get; set; }
        public string EmpUpdateChanel { get; set; }

        public virtual Employee EmpManagerNavigation { get; set; }
        public virtual ICollection<Employee> InverseEmpManagerNavigation { get; set; }
    }
}
