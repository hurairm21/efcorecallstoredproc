using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskPlannerApi.Repositories.Entities;

namespace TaskPlannerApi.Repositories.Configurations
{
    public class NoteConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.ToTable("Note");
            builder.HasKey(note => note.Id);
            builder.Property(note => note.Id).ValueGeneratedOnAdd();

            builder.Property(note => note.Title).IsRequired().HasMaxLength(128);
            builder.Property(note => note.Description).IsRequired(false);

            builder.HasOne(note => note.TaskItem).WithMany(task => task.Notes).HasForeignKey(note => note.TaskItemId);
        }
    }
}
