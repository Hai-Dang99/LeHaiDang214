using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeHaiDang214.Models
{
    [Table("UniversityLHD214s")]
    public class UniversityLHD214 : StringProcessLHD214
    {
        [Key]
        [DataType("varchar")]
        [Display(Name ="Mã Trường")]
        [StringLength(20)]
        public string UniversityId { get; set; }
        [DataType("nvarchar")]
        [Display(Name ="Tên Trường Đại Học")]
        [StringLength(50)]
        public string UniversityName { get; set; }
    }
}