using DBRelationsEF.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBRelationsEF.Domain
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options)
				: base(options)
		{
		}

		public DbSet<Author> Authors { get; set; }

		public DbSet<Course> Courses { get; set; }
	}
}
