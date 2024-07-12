using JCH.Domain.Modules.Candidates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace JCH.Infrastructure.Modules.Candidates;

public class CandidateConfiguration : IEntityTypeConfiguration<Candidate>
{
    public void Configure(EntityTypeBuilder<Candidate> builder)
    {
        builder
            .HasIndex(c => c.Email)
            .IsUnique();
    }
}

