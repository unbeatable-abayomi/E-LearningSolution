using ELearningWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningWebApp.Data
{
    public class DataContext: DbContext 
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {

        }


        public DbSet<ELearningModel> ELearningTable { get; set; }
    }
}
