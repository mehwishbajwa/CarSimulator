# G4 – Azure App Service Deployment and Domain Configuration

## Objective

The objective of this task is to demonstrate how to create and configure a web application in Microsoft Azure and publish the CarSimulator project to a publicly accessible website.

## Project Information

- **Project:** CarSimulator
- **Platform:** Microsoft Azure
- **Service:** Azure App Service
- **App Service name:** mehwish-carsimulator
- **Runtime:** .NET 9.0
- **Publishing model:** Code
- **Repository:** https://github.com/mehwishbajwa/CarSimulator

## Azure Website

The CarSimulator application is hosted on Microsoft Azure App Service.

**Public URL:**

https://mehwish-carsimulator-acdnbwefemcsbpgc.francecentral-01.azurewebsites.net

The website is accessible through the Azure-generated domain using HTTPS.

## Deployment and Configuration

An Azure App Service was configured for the CarSimulator ASP.NET Core application.

The App Service uses the .NET 9.0 runtime and provides a publicly accessible hosting environment.

The application homepage was successfully opened through the Azure App Service URL.

The repository also contains GitHub Actions deployment workflow configuration.

## Domain Configuration

Azure automatically provides a default domain for the App Service.

For this project, the Azure-generated hostname is used instead of purchasing a custom domain.

The Azure Portal provides domain management settings where a custom domain could be added if required.

## Verification

The deployed CarSimulator application was tested through its public Azure URL. I started the simulation and selected the Reverse action. The application displayed the updated simulation status, including direction South, gas 15, energy 19, and the message "Car reverses and drives backwards." This demonstrates that the deployed application can process user actions.

The following verification has been completed:

- Azure App Service exists.
- The application is configured with .NET 9.0.
- A public Azure-generated domain is available.
- The CarSimulator homepage loads successfully in a web browser.

## Evidence

Evidence can be provided through screenshots of:

1. Azure App Service Overview showing the application configuration.
2. Azure App Service default domain settings.
3. The running CarSimulator homepage in the browser.
4. GitHub Actions deployment workflow and successful deployment run, if verified.

## Conclusion

The CarSimulator application has been published to a publicly accessible Azure App Service website.

This demonstrates how an ASP.NET Core web application can be hosted in Azure and accessed using an Azure-generated domain without purchasing a custom domain.
