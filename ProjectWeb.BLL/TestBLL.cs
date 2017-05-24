using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectWeb.DAL;
using ProjectWeb.Models;

namespace ProjectWeb.BLL
{
    public class TestBLL
    {

        ProjectWebDbContext context = new ProjectWebDbContext();


        public void TestMethod()
        {
            var sysUsers = new List<SysUser>
            {
                new SysUser { UserName="admin",Email="admin@qq.com", Password="123" },
                new SysUser { UserName="guest",Email="guest@qq.com", Password="456" }
            };

            sysUsers.ForEach(s => context.SysUsers.Add(s));
            context.SaveChanges();


            //var vUser = from u in context.SysUsers
            //            select u;

            //vUser = context.SysUsers;

            //vUser = from u in context.SysUsers
            //        where u.UserName == "Tom"
            //        select u;

            //vUser = context.SysUsers.Where(u => u.UserName == "Tom");
            
        }


        public List<SysUser> GetUser()
        {
            var vUsers = context.SysUsers;
            return vUsers.ToList();
        }

    }
}
