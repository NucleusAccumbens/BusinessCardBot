﻿namespace Domain.Common;

public class BaseAuditableEntity : BaseEntity
{
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModified { get; set; }
}
