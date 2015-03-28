using System;

namespace Netbooru.Models
{
    public class PostView
    {
		public int Id { get; set; }
		public virtual Post Post { get; set; }
		public string Name { get; set; }
		public virtual Upload Upload { get; set; }
    }
}