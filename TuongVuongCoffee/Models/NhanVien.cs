using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TuongVuongCoffee.Models
{
    [Table("NhanVien")]
    
    
    public class NhanVien
    {
        [Key]
        public string NhanVienCode {get; set; }
        public string NhanVienName {get; set; }
        public string Sex {get; set; }
        public string PhoneNumber {get; set; }
        public string Address {get; set; }
        
        
        
        
        
    }
}