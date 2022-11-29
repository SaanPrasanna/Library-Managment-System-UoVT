using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Utils.Models {
    internal class Member {
        public string MID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Category { get; set; }
        public DateTime RenewDate { get; set; }
    }
}
