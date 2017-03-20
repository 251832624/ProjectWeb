using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectWeb.Models;

namespace ProjectWeb.DAL
{
    public class AccountInitializer: DropCreateDatabaseIfModelChanges<AccountContext>
    {
        protected override void Seed(AccountContext context)
        {
            //base.Seed(context);
            var sysUsers = new List<SysUser>
            {
                new SysUser { UserName = "Tom", Email = "Tom@qq.com", Password = "123" },
                new SysUser { UserName = "Jerry",Email = "Jerry@qq.com",Password = "456" }
            };

            sysUsers.ForEach(s => context.SysUsers.Add(s));
            context.SaveChanges();


            var sysRoles = new List<SysRole>
            {
                new SysRole { RoleName="admin",RoleDesc = "admin user remark..." },
                new SysRole { RoleName="guest",RoleDesc = "guest user remark..." }
            };

            sysRoles.ForEach(s => context.SysRoles.Add(s));
            context.SaveChanges();


        }
    }
}
