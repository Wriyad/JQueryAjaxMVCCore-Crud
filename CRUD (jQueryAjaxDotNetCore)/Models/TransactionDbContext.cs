using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD__jQueryAjaxDotNetCore_.Models
{
    public class TransactionDbContext:DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
        { }

        public DbSet<TransactionModel> Transactions { get; set; }
    }
} 