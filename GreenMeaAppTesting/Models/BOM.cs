using System.Text.Json.Serialization;

namespace GreenMeaAppTesting.Models
{
	public class BOM
	{
		public int BomId { get; set; }
		public int Quantity { get; set; }

		//F.K
		[JsonIgnore]
		public ICollection<Products> ProductId { get; set; } = new HashSet<Products>();
		[JsonIgnore]
		public ICollection<RowMaterial> RowMaterialId { get; set; } = new HashSet<RowMaterial>();
	}
}
