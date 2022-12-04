using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;// Thêm
using System.ComponentModel.DataAnnotations.Schema; // Thêm
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Codefirst_17328.A_DAL.Models
{
    internal class Human
    {
        [Key]
        public string CMT { get; set; }
        [Required] // Not null
        [MaxLength(100)] // Độ dài tối đa là 100
        public string Ten { get; set; }
        public DateTime Tuoi { get; set; }
        public bool GioiTinh { get; set; }
        [Column("Address", TypeName = "nvarchar(200)")] // Tên cột là Address, kiểu dlieu là nvarchar(200)
        public string DiaChi { get; set; }
        public string? SoDT { get; set; } // nullable => có thể rỗng
        public List<Dog> Dogs { get; set; } // Thể hiện quan hệ 1 người - nhiều chó
    }
}
