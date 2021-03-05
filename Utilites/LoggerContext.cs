using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilites
{
    public class LoggerContext:DbContext
    {
        public LoggerContext(DbContextOptions<LoggerContext> options) : base(options)
        {
        }
      

        public DbSet<ExceptionDetail> ExceptionDetails { get; set; }
    }
}
