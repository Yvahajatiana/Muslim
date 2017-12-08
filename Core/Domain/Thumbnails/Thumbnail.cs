using Muslim.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Muslim.Core.Domain.Thumbnails
{
    public class Thumbnail : Child<Guid>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }
    }
}
