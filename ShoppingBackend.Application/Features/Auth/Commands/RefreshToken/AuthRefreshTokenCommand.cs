﻿using MediatR;
using ShoppingBackend.Application.Common.Models.General;
using ShoppingBackend.Application.Features.Auth.Commands.RefreshToken;

namespace ChatGPTClone.Application.Features.Auth.Commands.RefreshToken;

public sealed class AuthRefreshTokenCommand : IRequest<ResponseDto<AuthRefreshTokenResponse>>
{
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }
    public AuthRefreshTokenCommand()
    {

    }
    public AuthRefreshTokenCommand(string accessToken, string refreshToken)
    {
        AccessToken = accessToken;
        RefreshToken = refreshToken;
    }
}
