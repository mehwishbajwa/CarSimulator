# CarSimulator – DevOps Project

## Project Overview

CarSimulator is an ASP.NET Core web application developed using C# and .NET 9. The application simulates driving actions and displays information such as direction, fuel level, energy level, and vehicle status.

This project is used to demonstrate version control, automated testing, continuous deployment, Azure hosting, and DevOps practices.

## Technologies Used

- C# and .NET 9
- ASP.NET Core
- Git and GitHub
- GitHub Actions
- Microsoft Azure App Service
- Automated unit testing

## Gitflow and Branch Management (G2)

The project uses multiple Git branches to organize development:

- `main` – Main project branch.
- `develop` – Integration branch for development work.
- `feature/add-tests` – Development of unit tests.
- `feature/github-actions-tests` – GitHub Actions testing and Azure deployment configuration.

Pull requests and commits are used to track and review changes.

See [G2 – Gitflow Documentation](docs/G2-Gitflow.md).

## Version Comparison (G1)

GitHub commit history and file comparisons are used to review source code changes.

See [G1 – Version Comparison](docs/G1-Version-Comparison.md).

## Application Configuration Management (G3)

The application uses different methods to manage configuration settings across development and production environments.

### appsettings.json

The `CarSimulator.Server/appsettings.json` file contains general application settings, including logging levels and allowed hosts.

### appsettings.Development.json

The `CarSimulator.Server/appsettings.Development.json` file contains development-specific configuration settings.

### Environment Variables

Environment variables can override application settings without changing the source code. This allows different settings to be used in development and production.

### GitHub Actions Secrets

GitHub Actions repository secrets are used to store Azure authentication information required for deployment. Secret values are not written directly into the workflow file.

### Azure App Service Configuration

Azure App Service provides application settings that can be configured separately from the source code.

Sensitive information, such as passwords, API keys, and authentication credentials, should not be committed to the repository.

See [G3 – Application Configuration Documentation](docs/G3-Application-Configuration.md).

## Automated Testing (G5)

The project contains a separate unit testing project, `DataLogicLibrary.Tests`, for checking simulation logic.

Tests are executed through the .NET CLI and the GitHub Actions workflow.

## CI/CD Pipeline (G6)

GitHub Actions is configured to:

1. Restore project dependencies.
2. Build the .NET solution.
3. Run automated unit tests.
4. Publish the web application.
5. Deploy the application to Azure App Service when the preceding stages succeed.

## Azure Deployment (G4)

The application is hosted using Microsoft Azure App Service.

The deployed application is accessible through an Azure-provided public hostname.

## Documentation

Additional assignment documentation is stored in the `docs` folder.

## Project Repository

https://github.com/mehwishbajwa/CarSimulator
