using Microsoft.AspNetCore.Identity;
using System;

namespace UtilityLibrary
{
    public interface IBaseEntity<T> : IModifiedEntity
    {
        T Id { get; set; }
    }

    public abstract class BaseEntity<T> : IBaseEntity<T>
    {
        public T Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Deleted { get; set; }
        public string UserCreatedId { get; set; }
        public string UserUpdatedId { get; set; }
        public string UserDeletedId { get; set; }

        public virtual IdentityUser UserCreated { get; set; }
        public virtual IdentityUser UserUpdated { get; set; }
        public virtual IdentityUser UserDeleted { get; set; }
    }
}
