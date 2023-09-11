using GreenMeaAppTesting.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenMeaAppTesting.Data
{
	public class TestingforProjectDbContext : DbContext
	{
        public TestingforProjectDbContext()
        {
            
        }
        public TestingforProjectDbContext(DbContextOptions options):base(options)
        {
            
        }

		public DbSet<BOM> bom { get; set; }
		public DbSet<Machines> machines { get; set; }
		public DbSet<OrderStatus> orderStatuses { get; set; }
		public DbSet<ProductionOrder> productionOrders { get; set; }
		public DbSet<Products> products { get; set; }
		public DbSet<RowMaterial> rowMaterials { get; set; }
		public DbSet<Suppliers> suppliers { get; set; }
		public DbSet<WorkCenters> workCenters { get; set; }
		public DbSet<WorkOrders> workOrders { get; set; }
	}
}
