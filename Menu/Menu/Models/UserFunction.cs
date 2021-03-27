using System;
using System.Collections.Generic;

#nullable disable

namespace Menu.Models
{
    public partial class UserFunction
    {
        public int Id { get; set; }
        public int UfLnuCode { get; set; }
        public int UfFuncCode { get; set; }
        public string UfFuncDesc { get; set; }
        public string UfFuncNameAr { get; set; }
        public string UfFuncNameEn { get; set; }
        public string UfFont { get; set; }
        public string UfAppear { get; set; }
        public int? UfParentId { get; set; }
        public string UfAddB { get; set; }
        public string UfModB { get; set; }
        public string UfDelB { get; set; }
        public bool? UfActive { get; set; }
        public string UfCreatedBy { get; set; }
        public DateTime? UfCreatedAt { get; set; }
        public string UfCreatedChanel { get; set; }
        public string UfUpdateBy { get; set; }
        public DateTime? UfUpdateAt { get; set; }
        public string UfUpdateChanel { get; set; }

        public virtual SysFunction UfFuncCodeNavigation { get; set; }
    }
}
