using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntityConfig
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(u => u.Id);

            Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(u => u.Birthday)
                .IsRequired();
            
            Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);
            
            Property(u => u.Telephone)
                .IsRequired();
        }
    }
}