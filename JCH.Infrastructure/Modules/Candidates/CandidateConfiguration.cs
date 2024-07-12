using JCH.Domain.Modules.Candidates;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JCH.Infrastructure.Modules.Candidates;

public class CandidateConfiguration : IEntityTypeConfiguration<Candidate>
{
    /// <summary>
    /// Configures the properties and relationships of the <see cref="Candidate"/> entity.
    /// </summary>
    public void Configure(EntityTypeBuilder<Candidate> builder)
    {   
        builder
            .HasIndex(c => c.Email)
            .IsUnique();
    }
}