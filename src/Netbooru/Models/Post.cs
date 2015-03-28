using System.Collections;
using System.Collections.Generic;

namespace Netbooru.Models
{
	public class Post
	{
		public int Id { get; set; }
		public string Hash { get; set; }
		public string FileName { get; set; }
		public virtual ICollection<PostTag> Tags { get; set; }
		public virtual ICollection<PostView> Views { get; set; }
		public virtual ICollection<PostMetadata> Metadata { get; set; }
	}
}