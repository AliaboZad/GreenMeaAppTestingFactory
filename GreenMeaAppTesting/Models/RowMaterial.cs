using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GreenMeaAppTesting.Models
{
	public class RowMaterial
	{
		[Key]
		public int RowId { get; set; }
		[Required]
		public string RowName { get; set; }
		public string Description { get; set; }
		public int Quantity { get; set; }
		[ForeignKey("BOM")]
		public int? BOMId { get; set; }
		public int? SupplierId { get; set; }

		//F.K
		public BOM BOM { get; set; }
		public Suppliers Supplier { get; set; }
	}
}
