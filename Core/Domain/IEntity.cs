using System;
using System.Collections.Generic;
using System.Text;

namespace Muslim.Core.Domain
{
    public interface IEntity
    {
        object Id { get; }

        DateTime CreationDate { get; set; }

        DateTime ModificationDate { get; set; }

        string CreatedBy { get; set; }

        string ModifiedBy { get; set; }
    }
    public interface IEntity<T> : IEntity
    {
       T Id { get;}
    }
}
