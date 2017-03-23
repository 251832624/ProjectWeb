using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using ProjectWeb.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProjectWeb.DAL
{
    public class ProjectWebDbContext : DbContext
    {
        public ProjectWebDbContext() : base("DbConnectionString:ProjectWeb")
        {
        }

        public DbSet<SysUser> SysUsers { get; set; }
        public DbSet<SysRole> SysRoles { get; set; }
        public DbSet<SysUserRole> SysUserRoles { get; set; }


        /// <summary>
        /// OnModelCreating方法中的modelBuilder.Conventions.Remove语句禁止表名称正在多元化。如果你不这样做，所生成的表将命名为Students、Courses和Enrollments。相反，表名称将是Student、Course和Enrollment。开发商不同意关于表名称应该多数。本教程使用的是单数形式，但重要的一点是，您可以选择哪个你更喜欢通过包括或省略这行代码的形式。
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //base.OnModelCreating(modelBuilder);
        }

    }
}
