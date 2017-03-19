using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWeb.Models
{
    public class SysUserRole
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public int RoleID { get; set; }

        public virtual SysUser sysUser { get; set; }

        public virtual SysRole sysRole { get; set; }

    }
}
