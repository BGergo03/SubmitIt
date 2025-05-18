using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Entities;

namespace Persistence.Configurations;

public class ProblemConfiguration : IEntityTypeConfiguration<Problem>
{
    public void Configure(EntityTypeBuilder<Problem> builder)
    {
        builder.ToTable("problems");
        
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Title)
            .IsRequired()
            .HasMaxLength(30);
        builder.Property(p => p.Description)
            .IsRequired();
        builder.Property(p => p.Difficulty)
            .IsRequired();

        builder.HasMany(p => p.TestCases)
            .WithOne(t => t.Problem)
            .HasForeignKey(t => t.ProblemId);
        builder.HasMany(p => p.Submissions)
            .WithOne(s => s.Problem)
            .HasForeignKey(s => s.ProblemId);
    }
}