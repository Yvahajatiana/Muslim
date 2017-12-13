using System;
using System.Collections.Generic;
using System.Text;

namespace Muslim.Core.Domain.Posts
{
    public class Post:BaseEntity<Guid>
    {
        public string Content { get; set; }

    }
}
