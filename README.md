# CarSimulator – DevOps Project

## Project Overview

CarSimulator is an ASP.NET Core web application developed with C# and .NET 9. It simulates driving actions and displays direction, fuel level, energy level, and vehicle status.

The project demonstrates Git version control, Gitflow, automated unit testing, GitHub Actions CI/CD, Azure App Service deployment, and Azure infrastructure and security configuration.

**Repository:** [CarSimulator on GitHub](https://github.com/mehwishbajwa/CarSimulator)  
**Working branch:** [`develop`](https://github.com/mehwishbajwa/CarSimulator/tree/develop)  
**Live application:** [CarSimulator on Azure App Service](https://mehwish-carsimulator-acdnbwefemcsbpgc.francecentral-01.azurewebsites.net)

## Technologies

- C# and .NET 9
- ASP.NET Core
- Git and GitHub
- GitHub Actions
- Automated .NET unit testing
- Microsoft Azure App Service
- Azure Resource Manager (ARM), Azure monitoring, IP restrictions, and Azure SQL firewall configuration (documented in G7–G10)

## Repository Structure

-CarSimulatorApp.sln                         .NET solution 
-CarSimulator.Server/                         Web application 
-DataLogicLibrary.Tests/                      Unit tests 
-.github/workflows/azure-deploy.yml           Build, test, publish, and deploy workflow 
-docs/  G1–G10 assessment documentation 
-docs/images/                                 Supporting screenshots and evidence 

## Prerequisites

- .NET 9 SDK
- Git
- An Azure App Service deployment requires the appropriate Azure permissions and GitHub Actions secrets.

## Build and Test Locally

From the repository root:

dotnet restore CarSimulatorApp.sln
dotnet build CarSimulatorApp.sln --configuration Release --no-restore
dotnet test DataLogicLibrary.Tests/DataLogicLibrary.Tests.csproj --configuration Release

To run the web application locally:

dotnet run --project CarSimulator.Server/CarSimulator.Server.csproj

The local URL is printed in the terminal when the application starts. Any environment-specific configuration must be supplied through the appropriate application settings or environment variables.

## Branch Strategy (G2)

- main — main project branch.
- develop — integration branch and automatic CI/CD deployment trigger.
- feature/add-tests — unit test development.
- feature/github-actions-tests — earlier workflow and Azure deployment configuration work.

Changes are tracked using Git commits and pull requests. See [G2 – Gitflow](docs/G2-Gitflow.md).

## Application Configuration (G3)

- `CarSimulator.Server/appsettings.json` contains general application configuration.
- `CarSimulator.Server/appsettings.Development.json` contains development-specific configuration.
- Environment variables and Azure App Service application settings can override configuration without editing source code.
- GitHub Actions secrets provide the Azure identity identifiers used by the deployment workflow.
- Sensitive passwords, access tokens, and connection strings must not be committed to source control.

See [G3 – Application Configuration](docs/G3-Application-Configuration.md).

## Continuous Integration and Deployment (G5–G6)

The GitHub Actions workflow [`.github/workflows/azure-deploy.yml`](.github/workflows/azure-deploy.yml) runs automatically on pushes to `develop`. It can also be started manually.

The workflow performs the following stages:

1. Check out the repository and install the .NET 9 SDK.
2. Restore dependencies and build the solution in Release mode.
3. Run automated unit tests from `DataLogicLibrary.Tests`.
4. Publish the `CarSimulator.Server` application.
5. Upload the published application as a GitHub Actions artifact.
6. Authenticate to Azure using OpenID Connect (OIDC) and deploy to Azure App Service.

The deployment job depends on the successful completion of the build-and-test job. If build or tests fail, the deployment job does not proceed.

**Verified result:** GitHub Actions run **#8** was automatically triggered by a push to `develop` and completed successfully, including deployment. A separate unit-test workflow also completed successfully.

(https://github.com/mehwishbajwa/CarSimulator/actions)

For screenshots and details, see [G5 – GitHub Actions Testing](docs/G5-GitHub-Actions-Testing.md) and [G6 – Continuous Deployment](docs/G6-Continuous-Deployment.md).


![Successful automatic CI/CD pipeline](docs/images/G6-CICD-automatic-success.png)


## Azure Deployment (G4)

CarSimulator is deployed to the Azure App Service named `mehwish-carsimulator`, hosted in the France Central region. The deployment pipeline publishes the web application and deploys the resulting files to the App Service.

**Live website:** [Open CarSimulator](https://mehwish-carsimulator-acdnbwefemcsbpgc.francecentral-01.azurewebsites.net)

Azure uses a generated hostname that includes a suffix; the shorter `mehwish-carsimulator.azurewebsites.net` address is not the confirmed website address.

See [G4 – Azure Deployment](docs/G4-Azure-Deployment.md).

## Infrastructure, Security, and Monitoring (G7–G10)

The assignment documentation includes evidence and explanations of:

- **G7:** Azure Resource Manager (ARM) deployment.
- **G8:** Monitoring and logging.
- **G9:** App Service IP restrictions.
- **G10:** Azure SQL firewall configuration.

See the individual documentation files below for the exact configuration, screenshots, and results. These documented Azure configurations are distinct from container deployment; this README does not claim that CarSimulator is deployed as a container.

For infrastructure security, Azure access controls, firewall rules, IP restrictions, and secret handling help limit unauthorized access. Azure resources should remain available during grading, and their cost should be monitored.

## DevOps Assignment – G1–G10 Evidence


## DevOps Assignment – G1–G10 Evidence

| Requirement | Documentation |
|---|---|
| G1 – Version Comparison | [G1 Documentation](docs/G1-Version-Comparison.md) |
| G2 – Gitflow | [G2 Documentation](docs/G2-Gitflow.md) |
| G3 – Application Configuration | [G3 Documentation](docs/G3-Application-Configuration.md) |
| G4 – Azure Deployment | [G4 Documentation](docs/G4-Azure-Deployment.md) |
| G5 – GitHub Actions Testing | [G5 Documentation](docs/G5-GitHub-Actions-Testing.md) |
| G6 – Continuous Deployment | [G6 Documentation](docs/G6-Continuous-Deployment.md) |
| G7 – ARM Deployment | [G7 Documentation](docs/G7-arm-deployment.md) |
| G8 – Monitoring and Logging | [G8 Documentation](docs/G8-Monitoring-Logging.md) |
| G9 – IP Restrictions | [G9 Documentation](docs/G9-IP-Restriction.md) |
| G10 – Azure SQL Firewall | [G10 Documentation](docs/G10-Azure-SQL-Firewall.md) |
Supporting screenshots are stored in [`docs/images/`](docs/images/).

## Submission Notes

- The submitted branch is `develop`, where the G1–G10 documentation and successful CI/CD workflow are maintained.
- The repository must be accessible to the assessor.
- The Azure application and relevant resources should remain available until grading is complete.
- No passwords, tokens, or sensitive connection strings should be included in the submission.
