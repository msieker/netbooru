using System;

namespace Netbooru.Models
{
    public class PostMetadata
    {
		public int Id { get; set; }
		public virtual Post Post { get; set; }
		public string Key { get; set; }
		public string Value { get; set; }
    }
}