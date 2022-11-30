using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Utils.Models {
    //bm.ISBN, b.Title, bm.Quantity, Action, Description, bm.Date, bm.Time, s.Username
    class ManageBooks {
        public string Title { get; set; }
        public int Quantity { get; set; }
        public string Action { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Username { get; set; }
    }
}
