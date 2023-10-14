using handMadeShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace handMadeShop.ViewModels.System.Users
{
    public class RoleAssignRequest
    {
        public Guid Id { get; set; }
        public List<SelectItem> Roles { get; set; } = new List<SelectItem>();
    }
}