using ClassRoom.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace ClassRoom.Context;

public class AppDbContext:DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Science> Sciences { get; set; }
    public DbSet<Grading> Grades { get; set; }
    public DbSet<StudentScience> StudentSciences { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Grading>()
            .HasKey(g => new { g.StudentId, g.ScienceId });

        modelBuilder.Entity<StudentScience>()
            .HasKey(s => new { s.StudentId, s.ScienceId });
    }
}