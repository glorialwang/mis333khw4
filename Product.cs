using System.ComponentModel.DataAnnotations;

namespace Wang_Gloria_HW4.Models
{
    public enum ProductType { NewHardback, NewPaperback, UsedHardback, UsedPaperback, Other}
    public class Product
    {
        [Display(Name = "Product ID")]
        public Int32 ProductID { get; set; }


        [Required]
        [Display(Name = "Name")]
        public String Name { get; set; }

        [Display(Name = "Description")]
        public String Description { get; set; }

        [Required]
        [Display(Name = "Price")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal Price { get; set; }

        [Display(Name = "Product Type")]
        public ProductType ProductType { get; set; }
    }
}
