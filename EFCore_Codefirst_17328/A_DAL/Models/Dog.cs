using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;// Thêm
using System.ComponentModel.DataAnnotations.Schema; // Thêm

namespace EFCore_Codefirst_17328.A_DAL.Models
{
    internal class Dog
    {
        [Key]
        public int ID { get; set; }
        public string TenCho { get; set; }
        public string GiongCho { get; set; }
        public int Tuoi { get; set; }
        public bool GioiTinh { get; set; }
    }
}
