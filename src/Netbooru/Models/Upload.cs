using System;
using System.Collections;
using System.Collections.Generic;

namespace Netbooru.Models
{
	public class Upload
	{
		public int Id { get; set; }
		public DateTimeOffset? Created { get; set; }
		public string Hash { get; set; }
		public virtual Post Post { get; set; }
		public string Status { get; set; }
		public string StorePath { get; set; }
		public string FileName { get; set; }

		public virtual ICollection<UploadMetadata> Metadata { get; set; }
	}
}