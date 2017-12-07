using Muslim.Core.Domain.Thumbnails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebClient.Models.Home
{
    public class HomeVM : BaseVM
    {
        public HomeSectionVM Features { get; set; }

        public HomeSectionVM Galleries { get; set; }

        public HomeSectionVM Services { get; set; }
    }
}
