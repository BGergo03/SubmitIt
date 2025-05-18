using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Entities;

namespace Persistence.Configurations;

public class TestCaseConfiguration : IEntityTypeConfiguration<TestCase>
{
    public void Configure(EntityTypeBuilder<TestCase> builder)
    {
        builder.ToTable("testcases");

        builder.HasKey(t => t.Id);
        builder.Property(t => t.InputData)
            .IsRequired();
        builder.Property(t => t.ExpectedOutput)
            .IsRequired();
    }
}