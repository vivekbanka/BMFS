//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BMFS
{
    using System;
    using System.Collections.Generic;
    
    public partial class file
    {
        public int PrimaryInvestigatorID { get; set; }
        public int FileID { get; set; }
        public string FileShortDescription { get; set; }
        public string FileDescription { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedAt { get; set; }
    
        public virtual primaryinvestigatoryear primaryinvestigatoryear { get; set; }
    }
}
