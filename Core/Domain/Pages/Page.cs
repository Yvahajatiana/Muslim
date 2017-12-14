using Muslim.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Muslim.Core.Domain.Pages
{
    public class Page : BaseEntity<Guid>, ISeo
    {
        public string Title { get; set; }

        public string SeoTitle { get; set; }

        public string SeoMetaDescription { get; set; }

        public string SeoSlug { get; set; }
    }
}
