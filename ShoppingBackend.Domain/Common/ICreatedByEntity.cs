﻿namespace ShoppingBackend.Domain.Common;

public interface ICreatedByEntity
{
    DateTimeOffset CreatedOn { get; set; }
    string CreatedByUserId { get; set; }
}
