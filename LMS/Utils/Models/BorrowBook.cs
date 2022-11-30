using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Utils.Models {
    class BorrowBook {
        //bb.issue_date AS 'Issued Date', bb.due_date As 'Due Date', return_date AS 'Returned Date', bb.Status
        public string RefNo { get; set; }
        public string MID { get; set; }
        public string Title { get; set; }
        public string FullName { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnedDate { get; set; }
        public string Status { get; set; }
    }
}
