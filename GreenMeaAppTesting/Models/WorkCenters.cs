using System.ComponentModel.DataAnnotations;

namespace GreenMeaAppTesting.Models
{
	public class WorkCenters
	{
		[Key]
		public int WorkcenterId { get; set; }
		[Required]
		public string WorkcenterName { get; set; }
		public string Description { get; set; }
		public int Capacity { get; set; }
		public int? workOrdersId { get; set; }

		//F.K
		public WorkOrders workOrders { get; set; }
	}
}
