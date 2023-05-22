using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TuongVuongCoffee.Models
{
    [Table("SanPham")]
    
    public class SanPham
    {
        [Key]
        public string SanPhamID {get; set; }
        public string SanPhamName {get; set; }
        
        
        
        
        
        
    }
}