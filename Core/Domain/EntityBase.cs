using System;
using System.Collections.Generic;
using System.Text;

namespace Muslim.Core.Domain
{
    public class EntityBase<T> : IEntity<T>
    {
        private DateTime? creationDate;

        public T Id { get; set; }

        public DateTime CreationDate
        {
            get => creationDate ?? DateTime.UtcNow;
            set => creationDate = value;
        }

        public DateTime ModificationDate { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        object IEntity.Id => Id;
    }
}
