using System.ComponentModel.DataAnnotations;

namespace GreenMeaAppTesting.Models
{
	public class OrderStatus
	{
		[Key]
		public int StatusId { get; set; }
		[Required]
		public string StatusName { get; set; }

		//f.k
		public ICollection<ProductionOrder> productionOrders { get; set; }
		public ICollection<WorkOrders> WorkOrders { get; set; }
	}
}
