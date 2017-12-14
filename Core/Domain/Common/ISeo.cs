using System;
using System.Collections.Generic;
using System.Text;

namespace Muslim.Core.Domain.Common
{
    public interface ISeo
    {
        string SeoTitle { get; set; }

        string SeoMetaDescription { get; set; }

        string SeoSlug { get; set; }
    }
}
