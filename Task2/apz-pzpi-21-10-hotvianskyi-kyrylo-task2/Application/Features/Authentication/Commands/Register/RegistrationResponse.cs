﻿namespace Application.Features.Authentication.Commands.Register;

public class RegistrationResponse
{
    public string Id { get; set; } = null!;
    public string Token { get; set; } = null!;
}