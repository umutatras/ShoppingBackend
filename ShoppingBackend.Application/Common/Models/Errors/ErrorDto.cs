﻿namespace ShoppingBackend.Application.Common.Models.Errors;

public sealed class ErrorDto
{
    public string PropetyName { get; set; }
    public IReadOnlyList<string> Messages { get; set; }

    public ErrorDto(string propertyName, List<string> messages)
    {
        PropetyName = propertyName;
        Messages = messages;
    }
}