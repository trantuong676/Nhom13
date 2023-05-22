using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuongVuongCoffee.Models
{
    [Table("Kho")]
    public class Kho
    {
        [Key]
        public string KhoID {get; set; }
        public string SanPhamName {get; set; }
        [ForeignKey("SanPhamName")]
        public SanPham? SanPham {get; set;}
        public string NumberKho {get; set; }
        public string KhoStoreExists{get; set; }//so luong tonng
        public string InventoryKho {get; set; }//sach trong kho
        public string ExportKho {get; set; }//hanbg xuat
        
     
    }
}  