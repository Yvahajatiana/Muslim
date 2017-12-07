using Muslim.Core.Domain.Thumbnails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebClient.Models.Home
{
    public class HomeSectionVM
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public IEnumerable<Thumbnail> Thumbnails { get; set; }
    }
}
