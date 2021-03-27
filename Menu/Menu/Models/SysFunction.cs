using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace Menu.Models
{
    public partial class SysFunction
    {
        public SysFunction()
        {
            InverseSysFuncParent = new HashSet<SysFunction>();
            UserFunctions = new HashSet<UserFunction>();
        }

        public int SysFuncCode { get; set; }
        public string SysFuncDesc { get; set; }
        public string SysFuncNameAr { get; set; }
        public string SysFuncNameEn { get; set; }
        public string SysFuncTechName { get; set; }
        public string SysFuncfont { get; set; }
        public string SysFuncAppear { get; set; }
        public int? SysFuncParentId { get; set; }
        public string SysFuncAddB { get; set; }
        public string SysFuncModB { get; set; }
        public string SysFuncDelB { get; set; }
        public bool? SysFuncActive { get; set; }
        public string SysFunccreatedBy { get; set; }
        public DateTime? SysFunccreatedAt { get; set; }
        public string SysFunccreatedChanel { get; set; }
        public string SysFuncupdateBy { get; set; }
        public DateTime? SysFuncupdateAt { get; set; }
        public string SysFuncupdateChanel { get; set; }

        public virtual SysFunction SysFuncParent { get; set; }
        public virtual ICollection<SysFunction> InverseSysFuncParent { get; set; }
        public virtual ICollection<UserFunction> UserFunctions { get; set; }
    }
}
