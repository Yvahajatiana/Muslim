using Muslim.Core.Domain.Thumbnails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebClient.Models.Home;

namespace WebClient.Data.Mocks
{
    public class ContentMock : IContentService
    {
        public HomeVM GetHomeContent()
        {
            var Thumbnail = new Thumbnail
            {
                Title = "Lorem ipsum dolor",
                Description = "Lorem ipsum dolor sit amet consectetur",
                Image = "images/"
            };

            var HomeSectionVM = new HomeSectionVM
            {
                Title = "Lorem ipsum dolor sit amet consectetur adipisicing elit",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit",
                Thumbnails = new List<Thumbnail> { Thumbnail, Thumbnail, Thumbnail, Thumbnail }
            };

            var HomeContent = new HomeVM
            {
                Features = HomeSectionVM,
                Galleries = HomeSectionVM,
                Services = HomeSectionVM
            };

            return HomeContent;
        }
    }
}
