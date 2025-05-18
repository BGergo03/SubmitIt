using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Entities;

namespace Persistence.Configurations;

public class SubmissionConfiguration : IEntityTypeConfiguration<Submission>
{
    public void Configure(EntityTypeBuilder<Submission> builder)
    {
        builder.ToTable("submissions");

        builder.HasKey(s => s.Id);
        builder.Property(s => s.Code)
            .IsRequired()
            .HasMaxLength(500);
        builder.Property(s => s.Language)
            .IsRequired();
        builder.Property(s => s.Result)
            .IsRequired();
    }
}