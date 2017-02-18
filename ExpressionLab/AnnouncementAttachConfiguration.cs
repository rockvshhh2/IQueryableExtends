// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

namespace ExpressionLab
{

    // AnnouncementAttach
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class AnnouncementAttachConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AnnouncementAttach>
    {
        public AnnouncementAttachConfiguration()
            : this("dbo")
        {
        }

        public AnnouncementAttachConfiguration(string schema)
        {
            ToTable("AnnouncementAttach", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.AnnouncementId).HasColumnName(@"AnnouncementId").IsRequired().HasColumnType("int");
            Property(x => x.DispalyFileName).HasColumnName(@"DispalyFileName").IsRequired().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.AttachFilePath).HasColumnName(@"AttachFilePath").IsRequired().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.AttachType).HasColumnName(@"AttachType").IsRequired().HasColumnType("tinyint");
            Property(x => x.Valid).HasColumnName(@"Valid").IsRequired().HasColumnType("bit");
            Property(x => x.CreatorId).HasColumnName(@"CreatorId").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CreatedAt).HasColumnName(@"CreatedAt").IsRequired().HasColumnType("datetime");
            Property(x => x.ModifierId).HasColumnName(@"ModifierId").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ModifiedAt).HasColumnName(@"ModifiedAt").IsOptional().HasColumnType("datetime");
            Property(x => x.CreateBy).HasColumnName(@"CreateBy").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CreateTime).HasColumnName(@"CreateTime").IsOptional().HasColumnType("datetime");
            Property(x => x.UpdateBy).HasColumnName(@"UpdateBy").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.UpdateTime).HasColumnName(@"UpdateTime").IsOptional().HasColumnType("datetime");
        }
    }

}
// </auto-generated>