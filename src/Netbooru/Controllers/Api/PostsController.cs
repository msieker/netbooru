using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Netbooru.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Netbooru.Controllers.Api
{
	[Route("api/[controller]")]
	public class PostsController : Controller
	{
		private NetbooruDbContext _context;

		public PostsController(NetbooruDbContext context)
		{
			_context = context;
		}

		// GET: api/values
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var post = await _context.Posts.FirstOrDefaultAsync(p => p.Id == id);

			if (post == null)
			{
				return new HttpNotFoundResult();
			}
			else
			{
				return new ObjectResult(post);
			}
		}

		// POST api/values
		[HttpPost]
		public void Post([FromBody]string value)
		{
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
