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

namespace ExpressionLab.DB
{

    // AnnouncementLog
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class AnnouncementLog
    {

        ///<summary>
        /// 流水識別碼
        ///</summary>
        public int Id { get; set; } // Id (Primary key)

        ///<summary>
        /// 公告代碼
        ///</summary>
        public int AnnouncementId { get; set; } // AnnouncementId

        ///<summary>
        /// AD 帳號
        ///</summary>
        public string Account { get; set; } // Account (length: 50)

        ///<summary>
        /// 資料是否有效  0 : 無效  1 : 有效
        ///</summary>
        public bool Valid { get; set; } // Valid

        ///<summary>
        /// 建立人員
        ///</summary>
        public string CreatorId { get; set; } // CreatorId (length: 50)

        ///<summary>
        /// 建檔時間
        ///</summary>
        public System.DateTime CreatedAt { get; set; } // CreatedAt

        ///<summary>
        /// 維護人員
        ///</summary>
        public string ModifierId { get; set; } // ModifierId (length: 50)

        ///<summary>
        /// 維護時間
        ///</summary>
        public System.DateTime? ModifiedAt { get; set; } // ModifiedAt

        ///<summary>
        /// 建立人
        ///</summary>
        public string CreateBy { get; set; } // CreateBy (length: 50)

        ///<summary>
        /// 建立時間
        ///</summary>
        public System.DateTime? CreateTime { get; set; } // CreateTime

        ///<summary>
        /// 更新人
        ///</summary>
        public string UpdateBy { get; set; } // UpdateBy (length: 50)

        ///<summary>
        /// 更新時間
        ///</summary>
        public System.DateTime? UpdateTime { get; set; } // UpdateTime

        public AnnouncementLog()
        {
            Valid = true;
            CreatedAt = System.DateTime.UtcNow;
            CreateTime = System.DateTime.UtcNow;
        }
    }

}
// </auto-generated>