using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GreenMeaAppTesting.Models
{
	public class Products
	{
		[Key]
		public int ProductId { get; set; }
		[Required]
		public string ProductName { get; set; }
		[Required]
		public string Description { get; set; }
		[ForeignKey("BOM")]
		public int? BOMId { get; set; }
		public int? productionId { get; set; }

		//F.ks	
		public BOM BOM { get; set; }
		public ProductionOrder production { get; set; }
	}
}
