using System;
using System.Collections.Generic;

#nullable disable

namespace Menu.Models
{
    public partial class LoginUser
    {
        public string LnuCode { get; set; }
        public string LnuEmail { get; set; }
        public string LnuPassword { get; set; }
        public DateTime? LnuPassExpdt { get; set; }
        public int? LnuRoleCode { get; set; }
        public bool? LnuActive { get; set; }
        public string LnuPassStatus { get; set; }
        public string LnuCreatedBy { get; set; }
        public DateTime? LnuCreatedAt { get; set; }
        public string LnuCreatedChanel { get; set; }
        public string LnuUpdateBy { get; set; }
        public DateTime? LnuUpdateAt { get; set; }
        public string LnuUpdateChanel { get; set; }
    }
}
