# G7 – Deploying a Web Application Using an ARM Template

**Project:** CarSimulator  
**Course:** DevOps  
**Student:** Mehwish Bajwa  
**Deployment Platform:** Microsoft Azure  
**Deployment Method:** Azure Resource Manager (ARM) Template  
**Deployment Date:** 14 October 2026

---

## 1. Objective

The objective of G7 is to deploy a web application using an Azure Resource Manager (ARM) template and verify that the deployment is successful.

For my CarSimulator project, I used an ARM template to create the Azure infrastructure required to host a web application.

ARM templates are an example of Infrastructure as Code (IaC). They allow Azure resources to be defined in a JSON file instead of being created manually one by one.

The goal of this task was to:

- Create Azure resources using an ARM template.
- Configure an App Service Plan.
- Create an Azure Web App.
- Deploy the resources through Azure Portal.
- Verify that the deployment completed successfully.
- Document the deployment process with screenshots.

## 2. ARM Template

I created an ARM template and saved it in my GitHub repository.

**Template location:** `infra/azuredeploy.json`

[View ARM Template](../infra/azuredeploy.json)

The template contains the configuration for two Azure resources:

| Resource Type | Purpose |
|---|---|
| Microsoft.Web/serverfarms | Creates an Azure App Service Plan |
| Microsoft.Web/sites | Creates an Azure Web App |

The template uses parameters such as `appName`, `planName`, and `location` to configure the deployment.

Using an ARM template makes it possible to define the required infrastructure in code and reuse the configuration for future deployments.

## 3. Azure Resource Configuration

I used my Azure for Students subscription to create the resources.

The following settings were used:

| Setting | Value |
|---|---|
| Subscription | Azure for Students |
| Resource Group | CarSimulator-RG |
| Resource Group Region | Sweden Central |
| Web App Name | mehwish-carsimulator-g7 |
| App Service Plan | carsimulator-g7-plan |
| App Service Location | France Central |
| Pricing Tier | F1 (Free) |
| Operating System | Windows |

The resource group was configured in Sweden Central, while the App Service Plan and Web App were created in France Central.

## 4. Creating the App Service Plan

The first resource was an Azure App Service Plan.

I configured the ARM template to create an App Service Plan using the F1 Free pricing tier.

The F1 tier was suitable for this exercise because it allows basic web application hosting without requiring a paid App Service Plan.

The ARM template included the following configuration for the hosting plan:

```json
"sku": {
  "name": "F1",
  "tier": "Free"
},
"kind": "app",
"properties": {
  "reserved": false
}
```

After deployment, I opened the App Service Plan in Azure Portal and verified that it had been created successfully.

The status was **Ready**, and the pricing tier was **F1**.

### Screenshot – App Service Plan

![App Service Plan created using the F1 Free tier](images/App%20Service%20Plan%20created%20using%20the%20F1%20Free%20tier.png)

## 5. Deploying the ARM Template

I performed the deployment through Microsoft Azure Portal.

The steps were:

1. Signed in to Microsoft Azure Portal.
2. Opened **Deploy a custom template**.
3. Loaded the ARM template.
4. Selected the Azure for Students subscription.
5. Selected the `CarSimulator-RG` resource group.
6. Entered the required deployment parameters.
7. Selected **Review + create**.
8. Reviewed the configuration and clicked **Create**.

Azure started creating the resources defined in the ARM template.

During this process, the Azure Portal displayed:

**Deployment is in progress**

This indicated that Azure was processing the template and provisioning the required resources.

### Screenshot – Deployment in Progress

![Deployment in progress](images/Deployment%20in%20progress.png)

## 6. Successful ARM Deployment

After the deployment process finished, Azure Portal displayed the message:

**Your deployment is complete**

This confirmed that the ARM deployment had completed successfully.

The deployment created the required hosting resources, including the App Service Plan and Azure Web App.

The deployment was performed within the `CarSimulator-RG` resource group.

### Screenshot – Deployment Completed

![ARM deployment completed successfully](images/ARM%20deployment%20completed%20successfully.png)

## 7. Verifying the Azure Web App

After the ARM deployment was completed, I opened the Azure Web App resource to verify its configuration.

The following details were displayed:

| Property | Result |
|---|---|
| Web App | mehwish-carsimulator-g7 |
| Status | Running |
| App Service Plan | carsimulator-g7-plan |
| Location | France Central |
| Operating System | Windows |
| Subscription | Azure for Students |

The Azure Web App showed the status **Running**.

### Screenshot – Azure Web App Running

![Azure Web App created and running](images/Azure%20Web%20App%20created%20and%20running.png)

## 8. Verifying the Website URL

After creating the Azure Web App, I opened its default domain in a web browser.

**Azure Web App URL:**

https://mehwish-carsimulator-g7.azurewebsites.net

The website displayed the Microsoft Azure default welcome page with the message:

**Your web app is running and waiting for your content**

This confirmed that the Azure Web App hosting environment was accessible through its public URL.

At this stage, the Azure infrastructure had been deployed successfully, but the actual CarSimulator application code had not yet been published to the Web App.

Therefore, the verification demonstrates successful infrastructure deployment rather than deployment of the complete CarSimulator application.

## 9. Deployment Verification Summary

I verified the deployment using Azure Portal and the Web App's public URL.

| Verification | Result |
|---|---|
| ARM deployment completed | Successful |
| App Service Plan created | Verified |
| F1 Free pricing tier configured | Verified |
| Azure Web App created | Verified |
| Azure Web App status | Running |
| Public Azure URL accessible | Verified |
| CarSimulator application code published | Not yet completed |

The results confirm that the ARM template successfully created the Azure infrastructure required for hosting the application.

## 10. Evidence and GitHub Repository

The ARM template and screenshots are stored in the CarSimulator GitHub repository.

**ARM template:**

[infra/azuredeploy.json](../infra/azuredeploy.json)

**Evidence folder:**

[docs/images](images/)

The following screenshots document the deployment:

1. `App Service Plan created using the F1 Free tier.png`
2. `Deployment in progress.png`
3. `ARM deployment completed successfully.png`
4. `Azure Web App created and running.png`

These screenshots show the Azure resource configuration, deployment progress, successful completion, and running Web App.

## 11. What I Learned

Through this exercise, I gained practical experience working with Azure Resource Manager templates and Infrastructure as Code.

I learned how to:

- Define Azure resources using a JSON-based ARM template.
- Configure an Azure App Service Plan.
- Create a Web App using an ARM deployment.
- Deploy multiple related resources together.
- Monitor deployment progress in Azure Portal.
- Verify deployed resources and their configuration.
- Document deployment results using screenshots.

I also learned the difference between creating a web application hosting environment and publishing application code to that environment.

## 12. Conclusion

I successfully completed an ARM template deployment for my CarSimulator project using Microsoft Azure.

The ARM template created an Azure App Service Plan and an Azure Web App.

I verified that the deployment completed successfully, that the App Service Plan was ready, and that the Web App had the status Running.

I also confirmed that the Azure Web App was accessible through its public URL.

The deployment demonstrates how Infrastructure as Code can be used to create and configure Azure resources in a consistent and repeatable way.

The next step is to publish the CarSimulator application code to the Azure Web App.

**G7 Result:** The Azure infrastructure was successfully deployed using an ARM template, and the deployment was verified through Azure Portal and supporting screenshots.
