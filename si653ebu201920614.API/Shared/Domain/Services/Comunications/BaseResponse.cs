﻿namespace si653ebu201920614.API.Shared.Domain.Services.Comunications;

public abstract class BaseResponse<T>
{
    protected BaseResponse(string message)
    {
        Success = false;
        Message = message;
        Resource = default;
    }

    protected BaseResponse(T resource)
    {
        Success = true;
        Message = string.Empty;
        Resource = resource;
    }

    public bool Success { get; set; }
    public string Message { get; set; }
    public T? Resource { get; set; }
}