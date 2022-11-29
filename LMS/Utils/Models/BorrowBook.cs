using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Utils.Models {
    class BorrowBook {
        public string RefNo { get; set; }
        public string MID { get; set; }
        public string ISBN { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Status { get; set; }
        public decimal FineFee { get; set; }
    }
}
