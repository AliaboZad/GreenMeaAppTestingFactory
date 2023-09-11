using System.ComponentModel.DataAnnotations;

namespace GreenMeaAppTesting.Models
{
	public class Suppliers
	{
		[Key]
		public int SupplierId { get; set; }
		[Required]
		public string? SupplierName { get; set; }
		public string? Address { get; set; }
		[Required]
		[MaxLength(50)]
		public string? ContactName { get; set; }
		[Phone]
		public int PhoneNumber { get; set; }
		[EmailAddress]
		public string? Email { get; set; }

		//F.K
		public ICollection<RowMaterial> rowMaterials { get; set; }
	}
}
