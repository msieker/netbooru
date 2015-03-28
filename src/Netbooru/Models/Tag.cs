using System;
using System.Collections;
using System.Collections.Generic;

namespace Netbooru.Models
{
    public class Tag
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public virtual ICollection<PostTag> Posts { get; set; }
    }
}