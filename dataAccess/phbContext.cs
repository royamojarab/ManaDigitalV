﻿using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAccess
{
    public class phbContext: DbContext
    {
        public phbContext():base("rEntities")
        {

        }
        public DbSet<person> persons { get; set; }
        public DbSet<group> groups { set; get; }
        public DbSet<personPhone> phopersonPhones { set; get; }
        public DbSet<personDetail> personDetails { set; get; }
    }
}
