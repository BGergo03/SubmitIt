using Microsoft.EntityFrameworkCore;
using Persistence.Configurations;
using Persistence.Entities;

namespace Persistence;

public class ApplicationDbContext : DbContext
{
    public DbSet<Problem> Problems;
    public DbSet<TestCase> TestCases;
    public DbSet<Submission> Submissions;
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new ProblemConfiguration());
        builder.ApplyConfiguration(new TestCaseConfiguration());
        builder.ApplyConfiguration(new SubmissionConfiguration());
    }
}