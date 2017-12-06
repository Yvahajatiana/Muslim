using System;
using System.Collections.Generic;
using System.Text;

namespace Muslim.Core.Domain.Comments
{
    public class Comment : EntityBase<Guid>
    {
        public string Content { get; set; }

        public Guid ParentId { get; set; }

        public bool IsChild { get; set; }
    }
}
