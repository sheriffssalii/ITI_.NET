using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
	public class Product
	{
        //ProductId, Title, Price, Description, Quantity, ImagePath.
        [Key]
		public int ProductId { get; set; }

        [Required(ErrorMessage = "Product title is required")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Product title must be between 2 and 200 characters")]
        [Display(Name = "Product Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 999999.99, ErrorMessage = "Price must be between $0.01 and $999,999.99")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Price ($)")]
        public decimal Price { get; set; }

        [StringLength(1000, ErrorMessage = "Description cannot exceed 1000 characters")]
        [Display(Name = "Product Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be 0 or greater")]
        [Display(Name = "Quantity in Stock")]
        public int Quantity { get; set;}

        [StringLength(500, ErrorMessage = "Image path cannot exceed 500 characters")]
        [Display(Name = "Image Path")]
        [DataType(DataType.ImageUrl)]
        public string ImagePath { get; set; }

        // Foreign Key
        [Required(ErrorMessage = "Please select a category")]
        [Display(Name = "Category")]
        public int? CategoryId { get; set; }

        // Navigation property - Many Products belong to One Category
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }


        /* 
        [Display(Name = "In Stock")]
        public bool IsInStock => Quantity > 0;

        [Display(Name = "Status")]
        public string StockStatus => Quantity > 0 ? $"{Quantity} in stock" : "Out of stock";
    }*/

    }
}
