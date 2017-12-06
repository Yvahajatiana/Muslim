using Muslim.Core.Domain.Thumbnails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebClient.Models.Home
{
    public class HomeVM : BaseVM
    {
        public IEnumerable<Thumbnail> Features { get; set; }

        public IEnumerable<Thumbnail> Galleries { get; set; }

        public IEnumerable<Thumbnail> Services { get; set; }
    }
}
