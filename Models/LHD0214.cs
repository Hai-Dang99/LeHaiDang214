using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeHaiDang214.Models
{
    [Table("LHD0214s")]
    public class LHD0214
    {
        [Key]
        [DataType("varchar")]
        [Display(Name ="ID")]
        [StringLength(20)]
        public string LHDID { get; set; }
        [DataType("nvarchar")]
        [Display(Name ="Họ và tên")]
        [StringLength(50)]
        [Required]
        public string LHDName { get; set; }
        public bool LHDGender { get; set; }
    }
}