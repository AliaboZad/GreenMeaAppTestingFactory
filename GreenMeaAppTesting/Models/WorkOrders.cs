using System.ComponentModel.DataAnnotations;

namespace GreenMeaAppTesting.Models
{
	public class WorkOrders
	{
		[Key]
		public int WorkorderId { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public int? statusId { get; set; }


		//F.K
		public ICollection<ProductionOrder> productionOrders { get; set; }
		public ICollection<WorkCenters> workcenter { get; set; }
		public OrderStatus status { get; set; }
	}
}
