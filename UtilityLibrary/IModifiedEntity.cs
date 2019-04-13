using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityLibrary
{
    public interface IModifiedEntity
    {
        DateTime Created { get; set; }
        DateTime? Updated { get; set; }
        DateTime? Deleted { get; set; }
        string UserCreatedId { get; set; }
        string UserUpdatedId { get; set; }
        string UserDeletedId { get; set; }
        IdentityUser UserCreated { get; set; }
        IdentityUser UserUpdated { get; set; }
        IdentityUser UserDeleted { get; set; }
    }
}
