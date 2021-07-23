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

		public DbSet<Tag> Tags { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Author>()
				.Property(a => a.Name)
				.IsRequired()
				.HasMaxLength(255);

			modelBuilder.Entity<Course>()
				.Property(c => c.Name)
				.IsRequired()
				.HasMaxLength(255);

			modelBuilder.Entity<Course>()
				.Property(c => c.Description)
				.IsRequired()
				.HasMaxLength(255);

			modelBuilder.Entity<Tag>()
				.Property(t => t.Name)
				.IsRequired()
				.HasMaxLength(255);
			base.OnModelCreating(modelBuilder);
		}
	}
}
