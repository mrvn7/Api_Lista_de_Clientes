using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidacaoDeEmail.Models
{
    public class TestModelsContext : DbContext
    {
        public TestModelsContext(DbContextOptions<TestModelsContext> options) : base(options)
        {

        }

        public DbSet<TestModels> testDetails { get; set; }

    }
}
