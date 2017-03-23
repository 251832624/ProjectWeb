using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWeb.Models
{
    public class SysUser
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public string Password { get; set; }       

        public virtual ICollection<SysUserRole> SysUserRoles { get; set; }
    }
}
