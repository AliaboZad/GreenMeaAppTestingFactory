using System.ComponentModel.DataAnnotations;

namespace GreenMeaAppTesting.Models
{
	public class ProductionOrder
	{
		[Key]
		public int OrderID { get; set; }
		[Required]
		public string OrderNumber { get; set; }
		[Required]
		public int Quantity { get; set; }
		public DateTime StartDate { get; set; } = DateTime.Now;
		public DateTime EndDate { get; set; }
		public int? OrderStatusId { get; set; }
		public int? workOrdersId { get; set; }
		//F.K
		public OrderStatus OrderStatus { get; set; }
		public ICollection<Products> products { get; set; }
		public WorkOrders workOrders { get; set; }
	}
}
