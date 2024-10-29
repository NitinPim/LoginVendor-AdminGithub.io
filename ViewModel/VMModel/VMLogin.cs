using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.VMModel
{
    public class VMLogin:Status
    {
        public int LoginId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> UserRoleId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }

        public bool IsLoginSuccess { get; set; }
    }

    public class VMRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
