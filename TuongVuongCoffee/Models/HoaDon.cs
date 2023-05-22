using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TuongVuongCoffee.Models
{
    [Table("HoaDon")]
    
    public class HoaDon
    {
        [Key]
        public string HoaDonID {get; set; }
        public string HoaDonName {get; set; }
        public string SoLuong {get; set; }
        
        
        
        
        
    }
}