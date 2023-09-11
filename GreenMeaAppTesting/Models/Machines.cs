using System.ComponentModel.DataAnnotations;

namespace GreenMeaAppTesting.Models
{
	public class Machines
	{
		[Key]
		public int MachineId { get; set; }
		public string MachineName { get; set; }
		public string Description { get; set; }
		public int MachineOfLineNumber { get; set; }
	}
}
