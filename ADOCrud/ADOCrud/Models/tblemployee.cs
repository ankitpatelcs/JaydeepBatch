using System;
using System.Collections.Generic;

namespace ADOCrud.Models
{   
    public partial class tblemployee
    {
        public int emp_id { get; set; }
        public string f_name { get; set; }
        public Nullable<int> salary { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
    
    }
}
