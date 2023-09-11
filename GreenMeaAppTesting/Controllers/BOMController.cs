using GreenMeaAppTesting.Data;
using GreenMeaAppTesting.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GreenMeaAppTesting.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BOMController : ControllerBase
	{
		private readonly TestingforProjectDbContext _projectDbContext;
        public BOMController(TestingforProjectDbContext projectDbContext)
        {
			_projectDbContext = projectDbContext;
        }
		[HttpGet]
		public IActionResult GetAllBOM()
		{
			IEnumerable<BOM> BomList = _projectDbContext.bom.ToList(); //_dbContext.bom.ToList();
			_projectDbContext.bom.ToList();
			return Ok(BomList);
		}
	}
}
