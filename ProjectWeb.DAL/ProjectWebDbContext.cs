﻿using System;
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
        public ProjectWebDbContext() : base("ProjectWebDbContext")
        {
        }

        public DbSet<SysUser> SysUsers { get; set; }
        public DbSet<SysRole> SysRoles { get; set; }
        public DbSet<SysUserRole> SysUserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //base.OnModelCreating(modelBuilder);
        }

    }
}
