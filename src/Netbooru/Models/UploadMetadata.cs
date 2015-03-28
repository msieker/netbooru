using System;

namespace Netbooru.Models
{
    public class UploadMetadata
    {
		public int Id { get; set; }
		public virtual Upload Upload { get; set; }
		public string Key { get; set; }
		public string Value { get; set; }
	}
}