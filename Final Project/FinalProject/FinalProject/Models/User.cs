using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
	public class User
	{
       
		//UserId, FirstName, LastName, Email, Password.

        [Key]
        public int UserId { get; set; }


		[Required(ErrorMessage = "First name is required")]
		[StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 50 characters")]
		[RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "First name can only contain letters and spaces")]
		[Display(Name = "First Name")]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "Last name is required")]
		[StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 50 characters")]
		[RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Last name can only contain letters and spaces")]
		[Display(Name = "Last Name")]
		public string LastName { get; set; }

		[Required(ErrorMessage = "Email is Required")]
		[EmailAddress(ErrorMessage = "Please Enter a Valid Email Address")]
		[StringLength(100, ErrorMessage = "Email Cannot Exceed 100 Characters")]
		[Display(Name = "Email Address")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Password is Required")]
		[StringLength(100, MinimumLength = 6, ErrorMessage = "Password Must Be At Least 6 Characters Long")]
		[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{6,}$",
		ErrorMessage = "Password Must Contain At Least One Uppercase Letter, One Lowercase Letter, And One Digit")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Display(Name = "Full Name")]
		public string FullName => $"{FirstName} {LastName}";

	

	}
}
