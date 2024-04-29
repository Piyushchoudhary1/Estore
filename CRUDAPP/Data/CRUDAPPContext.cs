using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDAPP.MODEL;

namespace CRUDAPP.Data
{
    public class CRUDAPPContext : DbContext
    {
        public CRUDAPPContext (DbContextOptions<CRUDAPPContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDAPP.MODEL.User> User { get; set; } = default!;
    }
}
