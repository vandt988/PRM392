using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FAP_API.Models;

public partial class Prm392Context : DbContext
{
    public Prm392Context()
    {
    }

    public Prm392Context(DbContextOptions<Prm392Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<ExamSchedule> ExamSchedules { get; set; }

    public virtual DbSet<ExamUser> ExamUsers { get; set; }

    public virtual DbSet<Letter> Letters { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<Slot> Slots { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<SystemKey> SystemKeys { get; set; }

    public virtual DbSet<TimeTable> TimeTables { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=103.142.25.34,1433;Database=PRM392;User Id=conght;Password=hathanhcong;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.ClassId).HasName("class_classid_primary");

            entity.ToTable("Class");

            entity.Property(e => e.ClassId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ClassCode)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ExamSchedule>(entity =>
        {
            entity.HasKey(e => e.EsId).HasName("examschedule_esid_primary");

            entity.ToTable("ExamSchedule");

            entity.Property(e => e.EsId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RoomId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SlotId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SubjectId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Room).WithMany(p => p.ExamSchedules)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("examschedule_roomid_foreign");

            entity.HasOne(d => d.Slot).WithMany(p => p.ExamSchedules)
                .HasForeignKey(d => d.SlotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("examschedule_slotid_foreign");

            entity.HasOne(d => d.Subject).WithMany(p => p.ExamSchedules)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("examschedule_subjectid_foreign");
        });

        modelBuilder.Entity<ExamUser>(entity =>
        {
            entity.HasKey(e => e.EsId).HasName("examuser_esid_primary");

            entity.ToTable("ExamUser");

            entity.Property(e => e.EsId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UserId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.User).WithMany(p => p.ExamUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("examuser_userid_foreign");
        });

        modelBuilder.Entity<Letter>(entity =>
        {
            entity.HasKey(e => e.LetterId).HasName("letter_letterid_primary");

            entity.ToTable("Letter");

            entity.Property(e => e.LetterId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodeSubject)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Reason).HasMaxLength(255);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.User).WithMany(p => p.Letters)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("letter_userid_foreign");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.RoomId).HasName("room_roomid_primary");

            entity.ToTable("Room");

            entity.Property(e => e.RoomId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Deparment)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Floor)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Number)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Slot>(entity =>
        {
            entity.HasKey(e => e.SlotId).HasName("slot_slotid_primary");

            entity.ToTable("Slot");

            entity.Property(e => e.SlotId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SlotName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.SubjectId).HasName("subjects_subjectid_primary");

            entity.Property(e => e.SubjectId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.SubjectCode)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SubjectName).HasMaxLength(255);
        });

        modelBuilder.Entity<SystemKey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("systemkey_id_primary");

            entity.ToTable("SystemKey");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CodeKey)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(255);
        });

        modelBuilder.Entity<TimeTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TimeTable");

            entity.Property(e => e.ClassId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RoomId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SlotId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SubjectId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UserId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Class).WithMany()
                .HasForeignKey(d => d.ClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("timetable_classid_foreign");

            entity.HasOne(d => d.Room).WithMany()
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("timetable_roomid_foreign");

            entity.HasOne(d => d.Slot).WithMany()
                .HasForeignKey(d => d.SlotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("timetable_slotid_foreign");

            entity.HasOne(d => d.Subject).WithMany()
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("timetable_subjectid_foreign");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("timetable_userid_foreign");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("users_userid_primary");

            entity.Property(e => e.UserId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FullName).HasMaxLength(255);
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.StudentCode)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
