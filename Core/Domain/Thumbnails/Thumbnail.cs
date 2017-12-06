﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Muslim.Core.Domain.Thumbnails
{
    public class Thumbnail : EntityBase<Guid>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }
    }
}
