﻿using Microsoft.Extensions.Configuration;

namespace Talonario.Infra.CrossCutting.ConfigurationModels;

public class DatabaseConfigure
{
    public const string ConnectionStringsSection = "ConnectionStrings";
    [ConfigurationKeyName("DefaultConnection")]
    public string ConnectionStrings { get; set; } = String.Empty;
}
