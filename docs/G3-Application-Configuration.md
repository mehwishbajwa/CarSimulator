# G3 – Application Configuration Management

## Objective

The objective of this task is to explain how application configuration can be managed in different locations in an ASP.NET Core application and how sensitive information can be protected.

In my CarSimulator project, I use JSON configuration files and GitHub Actions secrets. Azure App Service also supports environment-based configuration for deployed applications.

## 1. Configuration Using appsettings.json

The CarSimulator application contains the following file:

`CarSimulator.Server/appsettings.json`

This file stores general application settings, including logging levels and allowed hosts.

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

The `Information` logging level allows the application to record informational messages and more serious events.

The `Warning` level for Microsoft.AspNetCore reduces the amount of framework logging by recording warnings and more serious events.

The `AllowedHosts` setting determines which hostnames the application accepts when host filtering is applied. The value `*` permits all hostnames.

## 2. Development Environment Configuration

The project also contains:

`CarSimulator.Server/appsettings.Development.json`

This file provides configuration settings for the Development environment.

It contains logging settings with the same values as the general configuration file.

ASP.NET Core can load environment-specific configuration files to override corresponding default settings.

This makes it possible to use different settings for development and production without modifying the application code.

## 3. Environment Variables

Environment variables provide another way to configure ASP.NET Core applications.

They are useful for settings that may change between local development, testing, and production.

For example, the logging level can be configured using:

`Logging__LogLevel__Default=Warning`

In ASP.NET Core configuration, double underscores represent nested configuration sections.

Environment variables can override values from appsettings files when using the standard ASP.NET Core configuration providers.

In Azure App Service, these values can be configured under:

**App Service → Settings → Environment variables**

Environment variables are useful for production settings that should not be hardcoded in source files.

## 4. GitHub Actions Secrets and Pipeline Configuration

My CarSimulator project uses GitHub Actions to build, test, and deploy the application to Azure App Service.

The repository contains three Azure authentication secrets:

- Azure client ID
- Azure tenant ID
- Azure subscription ID

These values are stored in GitHub repository secrets and referenced by the deployment workflow.

The configuration is managed through:

**GitHub Repository → Settings → Secrets and variables → Actions**

The workflow accesses the secrets using GitHub Actions expressions rather than storing their values directly in the YAML file.

The workflow also contains non-secret configuration values, including the .NET SDK version, solution path, and Azure App Service name.

This separates deployment configuration from sensitive authentication values.

## 5. Protecting Sensitive Information

Sensitive information should not be committed directly to a GitHub repository.

Examples include passwords, API keys, database credentials, and private authentication keys.

Suitable locations for sensitive configuration include:

- GitHub Actions secrets for CI/CD authentication
- Azure App Service environment variables for application configuration
- Azure Key Vault for centrally managed secrets
- .NET User Secrets for local development

GitHub Actions secrets help prevent sensitive values from appearing directly in the repository's workflow files.

However, access to secrets must still be controlled through appropriate repository permissions and secure workflows.

The appsettings files inspected for this assignment contain logging and host settings rather than passwords or API keys.

## 6. Configuration Management in CarSimulator

The following configuration locations are relevant to my project:

| Configuration location | Purpose |
|---|---|
| appsettings.json | General application settings |
| appsettings.Development.json | Development-specific settings |
| Environment variables | Environment-specific runtime configuration |
| GitHub Actions secrets | Azure deployment authentication |
| GitHub Actions workflow | Build, test, and deployment settings |
| Azure App Service settings | Production configuration managed through Azure |

## 7. Evidence

**General configuration file:**

https://github.com/mehwishbajwa/CarSimulator/blob/develop/CarSimulator.Server/appsettings.json

**Development configuration file:**

https://github.com/mehwishbajwa/CarSimulator/blob/develop/CarSimulator.Server/appsettings.Development.json

**GitHub Actions workflow:**

https://github.com/mehwishbajwa/CarSimulator/tree/develop/.github/workflows

**GitHub Actions secrets:**

Repository Settings → Secrets and variables → Actions

The repository secrets have been configured for Azure authentication, and the GitHub Actions deployment workflow has successfully deployed CarSimulator to Azure App Service.

## 8. Conclusion

Through this task, I have learned that application configuration can be managed in multiple locations depending on its purpose and environment.

JSON configuration files are useful for general application settings, environment variables allow configuration without changing source code, and GitHub Actions secrets protect deployment authentication values.

Separating configuration from application code improves maintainability, supports deployment across different environments, and reduces the risk of exposing sensitive information.
