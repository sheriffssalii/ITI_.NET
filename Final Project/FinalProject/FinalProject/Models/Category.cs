using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
	public class Category
	{
		[Key]
		public int CategoryId { get; set; }

		[Required(ErrorMessage = "Category Name is Required")]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "Category Name Must Be Between 2 and 100 Characters")]
		[Display(Name = "Category Name")]
		public string Name { get; set; }

		[StringLength(500, ErrorMessage = "Description Cannot Exceed 500 Characters")]
		[Display(Name = "Category Description")]
		[DataType(DataType.MultilineText)]
		public string? Description { get; set; }

		// Navigation property - One Category has Many Products
		public virtual ICollection<Product> Products { get; set; } = new List<Product>();

		[Display(Name = "Number of Products")]
		public int ProductCount
		{
			get
			{
				if (Products == null)
				{
					return 0;
				}
				return Products.Count;
			}
		}
	}
}
