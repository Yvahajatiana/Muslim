using System;
using System.Collections.Generic;
using System.Text;

namespace Muslim.Core.Domain.Common
{
    public abstract class Child<T> : EntityBase<T>
    {
        public T ParentID { get; set; }
    }
}
