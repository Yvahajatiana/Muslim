using System;
using System.Collections.Generic;
using System.Text;

namespace Muslim.Core.Domain.Posts
{
    public class Post:EntityBase<Guid>
    {
        public string Content { get; set; }

    }
}
