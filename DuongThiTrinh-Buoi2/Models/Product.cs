using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DuongThiTrinh_Buoi2.Models
{
    public class Product
    {
        [DisplayName ("Ma san pham")]
        public int Id { get; set; }
        [Required, StringLength(100)]
        [DisplayName ("Ten san pham")]
        public string Name { get; set; }
        [Range(0.01, 100000.00)]
        [DisplayName ("Gia ban ")]
        public decimal Price { get; set; }
        [DisplayName ("Mo ta")]
        public string Description { get; set; }
        public int CategoryId { get; set; }
    }

}
