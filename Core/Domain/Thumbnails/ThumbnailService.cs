using Muslim.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Muslim.Core.Domain.Thumbnails
{
    public class ThumbnailService : CrudService<Thumbnail>, IThumbnailService
    {
        public ThumbnailService(IRepository<Thumbnail> repository) : base(repository)
        {
        }
    }
}
