using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebClient.Models.Home;

namespace WebClient.Data
{
    public interface IContentService
    {
        HomeVM GetHomeContent();
    }
}
